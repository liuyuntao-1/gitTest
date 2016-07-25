<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim QuerySQL As String = "select * from Customers where City='" & Request.QueryString("City") & "'"
        'OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
        Dim CustomerQuerySQL As String = "select * from Customers where City='" & Request.QueryString("City") & "'"
        Dim SupplierQuerySQL As String = "select * from Suppliers where City='" & Request.QueryString("City") & "'"
        
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem(CustomerQuerySQL, "Detail1"))
        QueryList.Add(New ReportQueryItem(SupplierQuerySQL, "Detail2"))
        OledbXMLReportData.GenMultiRecordset(Me, QueryList)
        'OledbJsonReportData.GenMultiRecordset(Me, QueryList)
    End Sub
</script>