<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL As String = "select m.OrderID,m.CustomerId,m.OrderDate,d.ProductID,p.ProductName,d.UnitPrice,d.Quantity, " _
            & "d.UnitPrice*d.Quantity as Amount " _
            & "from (Orders m inner join OrderDetails as d on m.OrderID=d.OrderID) " _
            & "left outer join Products p on p.ProductID=d.ProductID " _
            & "where m.OrderID<=10300 " _
            & "order by m.OrderDate, m.OrderID"
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>