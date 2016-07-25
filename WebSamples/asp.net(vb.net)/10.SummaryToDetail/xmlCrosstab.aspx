<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select d.ProductID,p.ProductName,m.OrderDate,d.UnitPrice*d.Quantity as Amount " _
            & "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " _
            & "left join Products p on d.ProductID=p.ProductID " _
            & "where m.OrderDate between {0}1997-1-1{0} and {0}1997-12-31{0} " _
            & "order by p.ProductName, m.OrderDate", OledbReportData.DateSqlBracketChar)
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>