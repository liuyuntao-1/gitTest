<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format( _
        "select d.Productid,p.ProductName,Month(m.OrderDate) As MonthNo,d.Quantity,d.UnitPrice*d.Quantity as Amount " _
    & "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " _
    & "on m.orderid=d.orderid " _
    & "where m.OrderDate between {0}1997-1-1{0} And {0}1997-12-31{0} " _
    & "order by d.Productid,m.OrderDate", OledbReportData.DateSqlBracketChar)
        OledbReportData.FullGenNodeXmlData(Me, QuerySQL, False)
    End Sub
</script>