<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL As String = "select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight," _
            & "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount, " _
            & "d.UnitPrice*d.Quantity as Amount, d.UnitPrice*d.Quantity*d.Discount as DiscountAmt, " _
            & "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount " _
            & "from (Orders m inner join " _
            & "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " _
            & "left join Customers c on c.CustomerID=m.CustomerID " _
            & "where m.OrderID<=10300 " _
            & "order by m.OrderDate, m.OrderID"
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>