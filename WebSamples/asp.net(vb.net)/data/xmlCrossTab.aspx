<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL As String = "select c.City,m.CustomerId,c.CompanyName,d.ProductID,p.ProductName," _
            & "d.Quantity, d.UnitPrice*d.Quantity as Amount " _
            & "from (Orders m inner join " _
            & "(OrderDetails as d inner join Products p " _
            & "on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " _
            & "left join Customers c on c.CustomerID=m.CustomerID " _
            & "where d.ProductID<8 " _
            & "order by c.City,m.CustomerId, d.ProductID"
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>