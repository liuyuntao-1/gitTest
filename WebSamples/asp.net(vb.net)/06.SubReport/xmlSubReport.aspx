<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const Top10CustomerQuerySQL As String = _
            "select top 10 c.CustomerID, c.CompanyName, sum(o.Quantity*o.UnitPrice) As SumAmt " _
            & "from OrderDetails o, Orders m, customers c " _
            & "where o.OrderID=m.OrderID and m.CustomerID=c.CustomerID " _
            & "group by c.CustomerID, c.CompanyName " _
            & "order by sum(o.Quantity*o.UnitPrice) desc"
        Const Top10ProductQuerySQL As String = _
            "select top 10 p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty " _
            & "from OrderDetails o, Products p " _
            & "where o.ProductID=p.ProductID " _
            & "group by p.ProductID, p.ProductName " _
            & "order by sum(Quantity*o.UnitPrice) desc"
        
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem("select * from Customers order by CustomerID", "Customer"))
        QueryList.Add(New ReportQueryItem("select * from Products order by ProductName", "Product"))
        QueryList.Add(New ReportQueryItem(Top10CustomerQuerySQL, "Top10Customer"))
        QueryList.Add(New ReportQueryItem(Top10ProductQuerySQL, "Top10Product"))
        
        OledbXMLReportData.GenMultiRecordset(Me, QueryList)
        'OledbJsonReportData.GenMultiRecordset(Me, QueryList)
    End Sub
</script>