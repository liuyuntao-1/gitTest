<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select m.OrderID,m.CustomerId,c.CompanyName,c.ContactName,c.Address,c.city,c.Region,c.Country,c.Postalcode," _
            & "m.OrderDate,M.Freight,d.ProductID,p.ProductName," _
            & "d.UnitPrice,d.Quantity,d.Discount," _
            & "d.UnitPrice*d.Quantity as Amount," _
            & "d.UnitPrice*d.Quantity*d.Discount as DiscountAmt," _
            & "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount " _
            & "from (Orders m inner join " _
            & "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " _
            & "left join Customers c on c.CustomerID=m.CustomerID " _
            & "where m.OrderDate between {0}1997-1-1{0} And {0}1997-1-15{0} " _
            & "order by m.CustomerID,m.OrderDate, m.OrderID", OledbReportData.DateSqlBracketChar)
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>