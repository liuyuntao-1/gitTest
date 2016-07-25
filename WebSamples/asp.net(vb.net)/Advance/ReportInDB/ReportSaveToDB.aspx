<%@ Page Language="VB" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.IO" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.SqlClient" %>
<script runat="server"> 

    '将提交的报表模板数据保存到数据库表中
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ReportName as String = Request.QueryString("Report")    '报表名称
        Dim FormData As Byte() = Request.BinaryRead(Request.TotalBytes) '报表模板数据

        '数据库连接
        Dim myConn as SqlConnection = new SqlConnection(SqlReportData.SqlConnStr)
        myConn.Open()

        '首先判断是否存在同名报表
        Dim cmd as SqlCommand = new SqlCommand("Select ReportName from Report where ReportName='" & ReportName & "'", myConn)
        Dim dr as SqlDataReader = cmd.ExecuteReader()
        Dim Existed as Boolean = dr.HasRows
        dr.Close()

        '报表模板数据写入表中
        Dim strSQL as String
        if (Existed) then
            strSQL = "UPDATE Report SET ReportData=@ReportData where ReportName=@ReportName"
        else
            strSQL = "INSERT INTO Report(ReportName,ReportData) VALUES(@ReportName, @ReportData)"
        End If
        Dim cmdSave as SqlCommand = new SqlCommand(strSQL, myConn)
        cmdSave.Parameters.Add(new SqlParameter("@ReportName", SqlDbType.VarChar)).Value = ReportName
        cmdSave.Parameters.Add(new SqlParameter("@ReportData", SqlDbType.Image)).Value = FormData
        cmdSave.ExecuteNonQuery()
     End Sub
</script>