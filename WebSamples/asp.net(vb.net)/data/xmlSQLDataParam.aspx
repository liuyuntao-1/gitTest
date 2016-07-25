<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        '★特别提示★：
        '不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlReportData，Oracle数据库用OracleReportData
        'OledbReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        '从客户端发送的数据包中获取报表查询参数，URL有长度限制，当要传递的参数数据量比较大时，应该采用这样的方式
        '这里演示了用这样的方式传递一个超长查询SQL语句。
        Dim FormData As Byte() = Request.BinaryRead(Request.TotalBytes)
        Dim Unicode as UTF8Encoding  = new UTF8Encoding()
        Dim charCount As Integer = Unicode.GetCharCount(FormData, 0, Request.TotalBytes)
        Dim chars() As Char = new Char(charCount){}
        Dim charsDecodedCount As Integer = Unicode.GetChars(FormData, 0, Request.TotalBytes, chars, 0)
        Dim QuerySQL as String = new String(chars)

        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>