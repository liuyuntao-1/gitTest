<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        OledbXMLReportData.GenOneRecordset(Me, "select * from Products order by ProductName")
    End Sub
</script>