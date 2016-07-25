<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select * from Products " _
            & "where ProductID>={0} and ProductID<={1} " _
            & "order by ProductID", Request.QueryString("BeginNo"), Request.QueryString("EndNo"))
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>