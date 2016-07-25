Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Configuration
Imports System.IO
Imports System.IO.Compression
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Public Enum ResponseDataType
    PlainText '报表数据为XML或JSON文本，在调试时可以查看报表数据。数据未经压缩，大数据量报表采用此种方式不合适
    ZipBinary '报表数据为XML或JSON文本经过压缩得到的二进制数据。此种方式数据量最小(约为原始数据的1/10)，但用Ajax方式加载报表数据时不能为此种方式
    ZipBase64 '报表数据为将 ZipBinary 方式得到的数据再进行 BASE64 编码的数据。此种方式适合用Ajax方式加载报表数据
End Enum

'class ReportQueryItem
Public Class ReportQueryItem
    Public QuerySQL As String
    Public RecordsetName As String

    Public Sub New(ByRef AQuerySQL As String, ByRef ARecordsetName As String)
        QuerySQL = AQuerySQL
        RecordsetName = ARecordsetName
    End Sub
End Class


'class ReportDataBase 产生报表需要的xml数据
Public Class ReportDataBase
    '指定报表的默认数据类型，便于统一定义整个报表系统的数据类型
    '在报表开发调试阶段，通常指定为 ResponseDataType.PlainText, 以便在浏览器中查看响应的源文件时能看到可读的文本数据
    '在项目部署时，通常指定为 ResponseDataType.ZipBinary 或 ResponseDataType.ZipBase64，这样可以极大减少数据量，提供报表响应速度
    Public Const DefaultDataType As ResponseDataType = ResponseDataType.PlainText 'PlainText ZipBinary ZipBase64 

    '将报表XML数据文本输出到HTTP请求
    Public Shared Sub ResponseData(ByRef DataPage As System.Web.UI.Page, ByRef XMLText As String, ByVal DataType As ResponseDataType)
        '报表XML数据的前后不能附加任何其它数据，否则XML数据将不能成功解析，所以调用ClearContent方法清理网页中前面多余的数据
        DataPage.Response.ClearContent()

        If (DataType = ResponseDataType.PlainText) Then
            ' 把xml对象发送给客户端
            DataPage.Response.Write(XMLText)
        Else
            '将string数据转换为byte[]，以便进行压缩
            Dim Converter As New System.Text.UTF8Encoding()
            Dim XmlBytes As Byte() = Converter.GetBytes(XMLText)

            '在 HTTP 头信息中写入报表数据压缩信息
            DataPage.Response.AppendHeader("gr_zip_type", "deflate")                  '指定压缩方法
            DataPage.Response.AppendHeader("gr_zip_size", XmlBytes.Length.ToString()) '指定数据的原始长度
            DataPage.Response.AppendHeader("gr_zip_encode", Converter.HeaderName)     '指定数据的编码方式 utf-8 utf-16 ...

            If (DataType = ResponseDataType.ZipBinary) Then
                ' 把压缩后的xml数据发送给客户端
                Dim compressedzipStream As New DeflateStream(DataPage.Response.OutputStream, CompressionMode.Compress, True)
                compressedzipStream.Write(XmlBytes, 0, XmlBytes.Length)
                compressedzipStream.Close()
            Else
                Dim memStream As New MemoryStream()
                Dim compressedzipStream As New DeflateStream(memStream, CompressionMode.Compress, True)
                compressedzipStream.Write(XmlBytes, 0, XmlBytes.Length)
                compressedzipStream.Close() '这句很重要，这样数据才能全部写入 MemoryStream

                memStream.Seek(0, SeekOrigin.Begin) 'Set the position to the beginning of the stream.
                Dim count As Integer = memStream.Length
                Dim byteArray As Byte() = New Byte(count) {}
                memStream.Read(byteArray, 0, count)

                Dim Base64Text As String = Convert.ToBase64String(byteArray)
                DataPage.Response.Write(Base64Text)
            End If
        End If

        '报表XML数据的前后不能附加任何其它数据，否则XML数据将不能成功解析，所以调用End方法放弃网页中后面不必要的数据
        DataPage.Response.End()
    End Sub
End Class

'产生报表需要的xml数据
Public Class XMLReportData
    '根据 DataSet 产生提供给报表需要的XML数据，参数DataType指定压缩编码数据的形式
    Public Shared Sub GenDataSet(ByRef DataPage As System.Web.UI.Page, ByRef myds As DataSet, ByVal DataType As ResponseDataType)
        Dim XMLText As String = myds.GetXml()
        ReportDataBase.ResponseData(DataPage, XMLText, DataType)
    End Sub

    '根据 DataTable 产生提供给报表需要的XML数据，参数DataType指定压缩编码数据的形式
    Public Shared Sub GenDataTable(ByRef DataPage As System.Web.UI.Page, ByRef mydt As DataTable, ByVal DataType As ResponseDataType)
        Dim ds As DataSet = New DataSet()
        ds.Tables.Add(mydt)
        GenDataSet(DataPage, ds, DataType)
    End Sub

    '根据IDataReader, 产生提供给报表需要的XML数据，其中的空值字段也会产生XML节点，参数DataType指定压缩编码数据的形式
    Public Shared Sub GenNodeXmlDataFromReader(ByRef DataPage As System.Web.UI.Page, ByRef dr As IDataReader, ByVal DataType As ResponseDataType)
        Dim XMLText As String = "<xml>" & vbCrLf
        While dr.Read()
            XMLText += "<row>"
            Dim I As Integer
            For I = 0 To dr.FieldCount - 1
                Dim FldName As String = dr.GetName(I)
                If (FldName = "") Then
                    FldName = "Fld" & I
                End If
                XMLText += String.Format("<{0}>{1}</{0}>", FldName, HttpUtility.HtmlEncode(dr.GetValue(I)))
            Next
            XMLText += "</row>" & vbCrLf
        End While
        XMLText += "</xml>" & vbCrLf

        ReportDataBase.ResponseData(DataPage, XMLText, DataType)
    End Sub
End Class


'class JSONReportData 产生报表需要的 JSON 格式数据
Public Class JSONReportData
    '根据 DataSet 产生提供给报表需要的JSON数据，参数DataType指定压缩编码数据的形式
    Public Shared Sub GenDataSet(ByRef DataPage As System.Web.UI.Page, ByRef myds As DataSet, ByVal DataType As ResponseDataType)
        Dim Out As String = GenDetailText(myds)
        ReportDataBase.ResponseData(DataPage, Out, DataType)
    End Sub

    '根据 DataTable 产生提供给报表需要的JSON数据，参数DataType指定压缩编码数据的形式
    Public Shared Sub GenDataTable(ByRef DataPage As System.Web.UI.Page, ByRef mydt As DataTable, ByVal DataType As ResponseDataType)
        Dim ds As DataSet = New DataSet()
        ds.Tables.Add(mydt)
        GenDataSet(DataPage, ds, DataType)
    End Sub

    '根据 IDataReader 产生提供给报表需要的JSON参数数据包
    Public Shared Function GenDetailText(ByRef ds As DataSet) As String
        'Dim sbJSONText As New StringBuilder("{""recordset"":[" & vbCrLf)
        '"recordset":[
        Dim sbJSONText As New StringBuilder("{" & vbCrLf)
        For Each dt As DataTable In ds.Tables
            sbJSONText.Append(""""c)
            sbJSONText.Append(dt.TableName)
            sbJSONText.Append(""":[" & vbCrLf)
            For Each dr As DataRow In dt.Rows
                sbJSONText.Append("{")
                Dim I As Integer
                For I = 0 To dt.Columns.Count - 1
                    If dr.IsNull(I) = False Then
                        Dim Value As String
                        If dt.Columns(I).DataType.IsArray = True Then
                            Value = Convert.ToBase64String(dr(I))
                        Else
                            Value = dr(I).ToString()
                            PrepareValueText(Value)
                        End If
                        sbJSONText.AppendFormat("""{0}"":""{1}"",", dt.Columns(I).ColumnName, Value)
                    End If
                Next
                sbJSONText.Remove(sbJSONText.Length - 1, 1) '去掉每笔记录最后一个字段后面的","
                sbJSONText.Append("}," & vbCrLf)
            Next
            sbJSONText.Remove(sbJSONText.Length - 3, 1) '去掉最后一条记录后面的","
            sbJSONText.Append("]," & vbCrLf)
        Next
        sbJSONText.Remove(sbJSONText.Length - 3, 1) '去掉最后一记录集后面的","
        sbJSONText.Append("}"c)

        Return sbJSONText.ToString()
    End Function

    '将 DataReader 中的数据打包为报表需要的参数数据包形式
    Public Shared Function GenParameterText(ByRef drParamer As IDataReader) As String
        Dim sbJSONText As New StringBuilder()
        If drParamer.Read() = True Then
            Dim I As Integer
            For I = 0 To drParamer.FieldCount - 1
                If drParamer.IsDBNull(I) = False Then
                    Dim Value As String
                    If drParamer.GetFieldType(I).IsArray = True Then
                        Dim DataSize As Long = drParamer.GetBytes(I, 0, Nothing, 0, 0)
                        Dim buffer(DataSize) As Byte
                        drParamer.GetBytes(I, 0, buffer, 0, DataSize)
                        Value = Convert.ToBase64String(buffer)
                    Else
                        Value = drParamer.GetValue(I).ToString()
                        PrepareValueText(Value)
                    End If

                    sbJSONText.AppendFormat("""{0}"":""{1}"",", drParamer.GetName(I), Value)
                End If
            Next
        End If
        sbJSONText.Remove(sbJSONText.Length - 1, 1) '去掉最后一个字段后面的","
        Return sbJSONText.ToString()
    End Function

    '如果数据中包含有JSON规范中的特殊字符(" \ \r \n \t)，多特殊字符加 \ 编码
    Public Shared Sub PrepareValueText(ByVal ValueText As String)
        Dim HasSpecialChar As Boolean = False
        For Each ch As Char In ValueText
            If ch = """" Or ch = "\" Or ch = vbCr Or ch = vbLf Or ch = vbTab Then
                HasSpecialChar = True
                Exit For
            End If
        Next

        If HasSpecialChar = True Then
            Dim NewValueText As New StringBuilder()
            For Each ch As Char In ValueText
                If ch = """" Or ch = "\" Or ch = vbCr Or ch = vbLf Or ch = vbTab Then
                    NewValueText.Append("\")
                    If (ch = """" Or ch = "\") Then
                        NewValueText.Append(ch)
                    ElseIf (ch = vbCr) Then
                        NewValueText.Append("r")
                    ElseIf (ch = vbLf) Then
                        NewValueText.Append("n")
                    ElseIf (ch = vbTab) Then
                        NewValueText.Append("t")
                    Else
                        NewValueText.Append(ch)
                    End If
                End If
            Next
            ValueText = NewValueText.ToString()
        End If
    End Sub
End Class
