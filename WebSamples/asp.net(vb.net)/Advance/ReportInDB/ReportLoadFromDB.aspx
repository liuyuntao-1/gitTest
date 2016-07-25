<%@ Page Language="VB" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.IO" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.SqlClient" %>
<script runat="server"> 
    
    '根据报表名称，从数据库表中读出报表模板
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ReportName As String = Request.QueryString("Report")

        '数据库连接
        Dim myConn as SqlConnection = new SqlConnection(SqlReportData.SqlConnStr)
        myConn.Open()

        Dim cmd as SqlCommand = new SqlCommand("Select ReportData from Report where ReportName='" & ReportName & "'", myConn)
        Dim dr as SqlDataReader = cmd.ExecuteReader()
        dr.Read()
        Response.BinaryWrite(dr.GetSqlBinary(0).Value)
        dr.Close()
    End Sub
</script>