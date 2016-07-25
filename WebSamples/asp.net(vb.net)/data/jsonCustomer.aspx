<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        OledbJsonReportData.GenOneRecordset(Me, "select * from Customers order by Region,City")
    End Sub
</script>