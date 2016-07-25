<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL As String = "select Year(m.OrderDate) As TheYear, Month(m.OrderDate) As TheMonth, sum(d.UnitPrice*d.Quantity) as Amount " _
            & "from Orders m inner join OrderDetails as d on m.OrderId=d.OrderId " _
            & "group by Year(m.OrderDate),Month(m.OrderDate) " _
            & "order by Year(m.OrderDate),Month(m.OrderDate)"
        
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>