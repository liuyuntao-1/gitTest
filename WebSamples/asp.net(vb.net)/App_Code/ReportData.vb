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
    PlainText '��������ΪXML��JSON�ı����ڵ���ʱ���Բ鿴�������ݡ�����δ��ѹ������������������ô��ַ�ʽ������
    ZipBinary '��������ΪXML��JSON�ı�����ѹ���õ��Ķ��������ݡ����ַ�ʽ��������С(ԼΪԭʼ���ݵ�1/10)������Ajax��ʽ���ر�������ʱ����Ϊ���ַ�ʽ
    ZipBase64 '��������Ϊ�� ZipBinary ��ʽ�õ��������ٽ��� BASE64 ��������ݡ����ַ�ʽ�ʺ���Ajax��ʽ���ر�������
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


'class ReportDataBase ����������Ҫ��xml����
Public Class ReportDataBase
    'ָ�������Ĭ���������ͣ�����ͳһ������������ϵͳ����������
    '�ڱ��������Խ׶Σ�ͨ��ָ��Ϊ ResponseDataType.PlainText, �Ա���������в鿴��Ӧ��Դ�ļ�ʱ�ܿ����ɶ����ı�����
    '����Ŀ����ʱ��ͨ��ָ��Ϊ ResponseDataType.ZipBinary �� ResponseDataType.ZipBase64���������Լ���������������ṩ������Ӧ�ٶ�
    Public Const DefaultDataType As ResponseDataType = ResponseDataType.PlainText 'PlainText ZipBinary ZipBase64 

    '������XML�����ı������HTTP����
    Public Shared Sub ResponseData(ByRef DataPage As System.Web.UI.Page, ByRef XMLText As String, ByVal DataType As ResponseDataType)
        '����XML���ݵ�ǰ���ܸ����κ��������ݣ�����XML���ݽ����ܳɹ����������Ե���ClearContent����������ҳ��ǰ����������
        DataPage.Response.ClearContent()

        If (DataType = ResponseDataType.PlainText) Then
            ' ��xml�����͸��ͻ���
            DataPage.Response.Write(XMLText)
        Else
            '��string����ת��Ϊbyte[]���Ա����ѹ��
            Dim Converter As New System.Text.UTF8Encoding()
            Dim XmlBytes As Byte() = Converter.GetBytes(XMLText)

            '�� HTTP ͷ��Ϣ��д�뱨������ѹ����Ϣ
            DataPage.Response.AppendHeader("gr_zip_type", "deflate")                  'ָ��ѹ������
            DataPage.Response.AppendHeader("gr_zip_size", XmlBytes.Length.ToString()) 'ָ�����ݵ�ԭʼ����
            DataPage.Response.AppendHeader("gr_zip_encode", Converter.HeaderName)     'ָ�����ݵı��뷽ʽ utf-8 utf-16 ...

            If (DataType = ResponseDataType.ZipBinary) Then
                ' ��ѹ�����xml���ݷ��͸��ͻ���
                Dim compressedzipStream As New DeflateStream(DataPage.Response.OutputStream, CompressionMode.Compress, True)
                compressedzipStream.Write(XmlBytes, 0, XmlBytes.Length)
                compressedzipStream.Close()
            Else
                Dim memStream As New MemoryStream()
                Dim compressedzipStream As New DeflateStream(memStream, CompressionMode.Compress, True)
                compressedzipStream.Write(XmlBytes, 0, XmlBytes.Length)
                compressedzipStream.Close() '������Ҫ���������ݲ���ȫ��д�� MemoryStream

                memStream.Seek(0, SeekOrigin.Begin) 'Set the position to the beginning of the stream.
                Dim count As Integer = memStream.Length
                Dim byteArray As Byte() = New Byte(count) {}
                memStream.Read(byteArray, 0, count)

                Dim Base64Text As String = Convert.ToBase64String(byteArray)
                DataPage.Response.Write(Base64Text)
            End If
        End If

        '����XML���ݵ�ǰ���ܸ����κ��������ݣ�����XML���ݽ����ܳɹ����������Ե���End����������ҳ�к��治��Ҫ������
        DataPage.Response.End()
    End Sub
End Class

'����������Ҫ��xml����
Public Class XMLReportData
    '���� DataSet �����ṩ��������Ҫ��XML���ݣ�����DataTypeָ��ѹ���������ݵ���ʽ
    Public Shared Sub GenDataSet(ByRef DataPage As System.Web.UI.Page, ByRef myds As DataSet, ByVal DataType As ResponseDataType)
        Dim XMLText As String = myds.GetXml()
        ReportDataBase.ResponseData(DataPage, XMLText, DataType)
    End Sub

    '���� DataTable �����ṩ��������Ҫ��XML���ݣ�����DataTypeָ��ѹ���������ݵ���ʽ
    Public Shared Sub GenDataTable(ByRef DataPage As System.Web.UI.Page, ByRef mydt As DataTable, ByVal DataType As ResponseDataType)
        Dim ds As DataSet = New DataSet()
        ds.Tables.Add(mydt)
        GenDataSet(DataPage, ds, DataType)
    End Sub

    '����IDataReader, �����ṩ��������Ҫ��XML���ݣ����еĿ�ֵ�ֶ�Ҳ�����XML�ڵ㣬����DataTypeָ��ѹ���������ݵ���ʽ
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


'class JSONReportData ����������Ҫ�� JSON ��ʽ����
Public Class JSONReportData
    '���� DataSet �����ṩ��������Ҫ��JSON���ݣ�����DataTypeָ��ѹ���������ݵ���ʽ
    Public Shared Sub GenDataSet(ByRef DataPage As System.Web.UI.Page, ByRef myds As DataSet, ByVal DataType As ResponseDataType)
        Dim Out As String = GenDetailText(myds)
        ReportDataBase.ResponseData(DataPage, Out, DataType)
    End Sub

    '���� DataTable �����ṩ��������Ҫ��JSON���ݣ�����DataTypeָ��ѹ���������ݵ���ʽ
    Public Shared Sub GenDataTable(ByRef DataPage As System.Web.UI.Page, ByRef mydt As DataTable, ByVal DataType As ResponseDataType)
        Dim ds As DataSet = New DataSet()
        ds.Tables.Add(mydt)
        GenDataSet(DataPage, ds, DataType)
    End Sub

    '���� IDataReader �����ṩ��������Ҫ��JSON�������ݰ�
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
                sbJSONText.Remove(sbJSONText.Length - 1, 1) 'ȥ��ÿ�ʼ�¼���һ���ֶκ����","
                sbJSONText.Append("}," & vbCrLf)
            Next
            sbJSONText.Remove(sbJSONText.Length - 3, 1) 'ȥ�����һ����¼�����","
            sbJSONText.Append("]," & vbCrLf)
        Next
        sbJSONText.Remove(sbJSONText.Length - 3, 1) 'ȥ�����һ��¼�������","
        sbJSONText.Append("}"c)

        Return sbJSONText.ToString()
    End Function

    '�� DataReader �е����ݴ��Ϊ������Ҫ�Ĳ������ݰ���ʽ
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
        sbJSONText.Remove(sbJSONText.Length - 1, 1) 'ȥ�����һ���ֶκ����","
        Return sbJSONText.ToString()
    End Function

    '��������а�����JSON�淶�е������ַ�(" \ \r \n \t)���������ַ��� \ ����
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
