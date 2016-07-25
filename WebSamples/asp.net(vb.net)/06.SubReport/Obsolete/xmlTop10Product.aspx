<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL As String = "select top 10 p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty " _
            & "from OrderDetails o, Products p " _
            & "where o.ProductID=p.ProductID " _
            & "group by p.ProductID, p.ProductName " _
            & "order by sum(Quantity*o.UnitPrice) desc"
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>