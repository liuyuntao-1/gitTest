<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select c.CompanyName,m.OrderDate,d.UnitPrice*d.Quantity as Amount " _
            & "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " _
            & "left join Customers c on c.CustomerID=m.CustomerID " _
            & "where m.OrderDate between {0}1997-7-1{0} and {0}1997-7-10{0} " _
            & "order by c.CompanyName, m.OrderDate", OledbReportData.DateSqlBracketChar)
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>