<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim StartNo As Integer = Convert.ToInt32(Request.QueryString("StartNo"))
        Dim WantRows As Integer = Convert.ToInt32(Request.QueryString("WantRecords"))
        Dim OrderID As Integer = Convert.ToInt32(Request.QueryString("OrderID"))
        
        '说明：设置Http头"gr_batch_total"并不是必须的
        '如果是第一次取数，在Http头中指定记录数，以便客户端在开始时就产生准确的分页信息
        If StartNo = 0 Then
            
            Dim CountQuerySQL As String = "select count(*) " & _
                "from (Orders m inner join (OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " & _
                "left join Customers c on c.CustomerID=m.CustomerID "
            Dim Total As Integer = OledbReportData.BatchGetDataCount(CountQuerySQL)
            Response.AppendHeader("gr_batch_total", Total.ToString())
            'int Total = OledbReportData.BatchGetDataCount(CountQuerySQL);
        End If
    
        Dim QuerySQL As String = String.Format("select top {0} m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight," & _
            "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount, " & _
            "d.UnitPrice*d.Quantity as Amount,d.UnitPrice*d.Quantity*d.Discount as DiscountAmt, " & _
            "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount " & _
            "from (Orders m inner join " & _
            "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " & _
            "left join Customers c on c.CustomerID=m.CustomerID " & _
            "where m.OrderID>{1} " & _
            "order by m.OrderDate, m.OrderID", WantRows, OrderID)
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>