<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL as String = "select CategoryID,CategoryName,Description,Picture,PictureFile " _
            & "From Categories " _
            & "Order by CategoryID"
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>