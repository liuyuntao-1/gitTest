<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format( _
            "select p.ProductName,Month(m.OrderDate)-1 As MonthData,sum(d.UnitPrice*d.Quantity) as Amount " _
            & "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " _
            & "where m.OrderDate between {0}{1}{0} and {0}{2}{0} and p.ProductID < 5 " _
            & "group by p.ProductName,Month(m.OrderDate)-1 " _
            & "order by p.ProductName,Month(m.OrderDate)-1", _
            OledbReportData.DateSqlBracketChar, Request.QueryString("BeginDate"), Request.QueryString("EndDate"))
        OledbReportData.FullGenNodeXmlData(Me, QuerySQL, False)
    End Sub
</script>