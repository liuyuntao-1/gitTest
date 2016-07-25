<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        '★特别提示★：
        '不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlReportData，Oracle数据库用OracleReportData
        'OledbReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        '查询SQL从URL的参数中获得
        Dim QuerySQL As String = Request.QueryString("QuerySQL")
   
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>