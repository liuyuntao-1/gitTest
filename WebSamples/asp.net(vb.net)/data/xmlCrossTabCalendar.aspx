<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select m.OrderDate,sum(d.Quantity) as Qty,sum(d.UnitPrice*d.Quantity) as Amount " _
            & "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " _
            & "where m.OrderDate between {0}1997-1-1{0} and {0}1997-12-31{0} " _
            & "group by m.OrderDate " _
            & "order by m.OrderDate", OledbReportData.DateSqlBracketChar)
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>