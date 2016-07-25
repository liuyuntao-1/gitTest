<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = "EXEC ""Employee Sales by Country"" ""1/1/1997"", ""12/31/1997"""
        SqlReportData.GenNodeXmlData(Me, QuerySQL, False)
    End Sub
</script>