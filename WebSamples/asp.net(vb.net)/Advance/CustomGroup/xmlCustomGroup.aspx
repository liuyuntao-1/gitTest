<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL As String = "select d.ProductID,p.ProductName,sum(d.UnitPrice*d.quantity) as amount " _
            & "from OrderDetails d inner join Products p on p.Productid=d.Productid " _
            & "group by d.ProductID,p.ProductName " _
            & "order by sum(d.UnitPrice*d.quantity) desc"
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>