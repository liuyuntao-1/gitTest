<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity, " _
            & "d.UnitPrice*d.Quantity as Amount " _
            & "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " _
            & "on m.orderid=d.orderid " _
            & "where (m.OrderDate between {0}{1}{0} And {0}{2}{0}) and d.Productid={3} " _
            & "order by m.OrderDate ", _
            OledbReportData.DateSqlBracketChar, Request.QueryString("BeginDate"), Request.QueryString("EndDate"), Request.QueryString("ProductID"))
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>