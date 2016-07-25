<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select d.Productid,p.ProductName,sum(d.Quantity) as Quantity, " _
            & "sum(d.UnitPrice*d.Quantity) as Amount " _
            & "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " _
            & "on m.orderid=d.orderid " _
            & "where m.OrderDate between {0}1997-1-1{0} And {0}1997-12-31{0} " _
            & "group by d.Productid,p.ProductName " _
            & "order by d.Productid", OledbReportData.DateSqlBracketChar)
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>