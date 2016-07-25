<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        
        Const CustomerQuerySQL As String = "select * from Customers where CustomerID>='B' and CustomerID<'C' order by CustomerID"
        Const OrderQuerySQL As String = "select * from Orders where CustomerID>='B' and CustomerID<'C' and OrderID<10600 order by OrderID"
        Const OrderDetailQuerySQL As String = "select d.* from Orders m, OrderDetails d where m.OrderID=d.OrderID and m.CustomerID>='B' and m.CustomerID<'C'and m.OrderID<10600 order by d.OrderID"
        
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem(CustomerQuerySQL, "Customer"))
        QueryList.Add(New ReportQueryItem(OrderQuerySQL, "Order"))
        QueryList.Add(New ReportQueryItem(OrderDetailQuerySQL, "OrderDetail"))
        'OledbXMLReportData.GenMultiRecordset(Me, QueryList)
        OledbJsonReportData.GenMultiRecordset(Me, QueryList)
    End Sub
</script>