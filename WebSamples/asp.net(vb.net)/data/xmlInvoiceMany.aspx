<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL As String = "select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,c.ContactName+c.Phone as Remark, " _
            & "d.OrderID,d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount " _
            & "from (Orders m inner join (OrderDetails d inner join Products p on p.ProductID=d.ProductID) " _
            & "on d.OrderID=m.OrderID) left join Customers c on c.CustomerID=m.CustomerID " _
            & "where m.OrderID>=10255 and m.OrderID<10260 "
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>