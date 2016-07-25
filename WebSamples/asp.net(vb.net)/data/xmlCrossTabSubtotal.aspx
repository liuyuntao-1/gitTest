<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select t.CategoryName, p.ProductName,c.City,c.CompanyName,d.Quantity " _
            & "from (Orders m inner join  " _
            & "(OrderDetails as d inner join (Products p inner join Categories t on p.CategoryID=t.CategoryID) " _
            & "on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " _
            & "left join Customers c on c.CustomerID=m.CustomerID " _
            & "where m.OrderDate between {0}1997-1-1{0} and {0}1997-3-31{0} " _
            & "order by t.CategoryName,p.ProductName,c.City,c.CompanyName ", OledbReportData.DateSqlBracketChar)
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>