<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select d.Productid,sum(d.Quantity) as Quantity,sum(d.UnitPrice*d.Quantity) as Amount " _
   & "from orders m inner join OrderDetails d on m.orderid=d.orderid " _
   & "where (m.OrderDate between {0}1997-1-1{0} And {0}1997-3-31{0}) " _
   & "group by d.ProductID " _
   & "order by d.ProductID ", OledbReportData.DateSqlBracketChar)
        OledbReportData.FullGenNodeXmlData(Me, QuerySQL, False)
    End Sub
</script>