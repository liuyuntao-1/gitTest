<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem("select * from Customers order by CustomerID", "Customer"))
        QueryList.Add(New ReportQueryItem("select * from Products order by ProductName", "Product"))
        QueryList.Add(New ReportQueryItem("select * from Customers order by CustomerID", "Customer2"))
        OledbXMLReportData.GenMultiRecordset(Me, QueryList)
        'OledbJsonReportData.GenMultiRecordset(Me, QueryList)
    End Sub
</script>