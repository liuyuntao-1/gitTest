<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        OledbXMLReportData.GenOneRecordset(Me, "select * from categories", True)
        
        Const ParameterQuerySQL As String = "select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate, " _
            & "p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount " _
            & "from (Orders m inner join " _
            & "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " _
            & "left join Customers c on c.CustomerID=m.CustomerID " _
            & "where m.OrderID=10252 and d.ProductID=20 " _
            & "order by m.OrderDate, m.OrderID"

        '这里查询出来的数据将传递给报表中与字段同名的参数或部件框
        OledbXMLReportData.GenOneRecordset(Me, ParameterQuerySQL)
    End Sub
</script>