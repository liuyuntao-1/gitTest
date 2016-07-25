<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select m.OrderID,m.OrderDate, " _
            & "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount  " _
            & "from Orders m inner join  " _
            & "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId " _
            & "where m.OrderDate between {0}1997-6-1{0} and {0}1997-12-31{0} " _
            & "order by d.ProductID, m.OrderDate", OledbReportData.DateSqlBracketChar)
        
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>