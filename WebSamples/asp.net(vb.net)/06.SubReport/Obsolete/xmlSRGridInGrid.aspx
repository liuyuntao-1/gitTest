<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        OledbXMLReportData.GenOneRecordset(Me, "select * from Orders where OrderID<=10255 order by OrderID")
    End Sub
</script>