<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        OledbXMLReportData.GenOneRecordset(Me, "select * from categories")
    End Sub
</script>