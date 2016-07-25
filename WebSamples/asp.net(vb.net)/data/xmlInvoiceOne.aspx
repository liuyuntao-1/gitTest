<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        '第一个查询SQL串指定报表明细数据的查询SQL
        '第二个查询SQL串指定报表参数数据的查询SQL
        Const RecordsetQuerySQL As String = "select d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount " _
            & "from OrderDetails as d inner join Products p on P.ProductID=D.ProductID " _
            & "where d.OrderID=10255"
        Const ParameterQuerySQL As String = "select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,c.ContactName+c.Phone as Remark " _
            & "from Orders m left join Customers c on c.CustomerID=m.CustomerID " _
            & "where m.OrderID=10255"
        'OledbXMLReportData.GenEntireData(Me, RecordsetQuerySQL, ParameterQuerySQL)
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem(RecordsetQuerySQL, "Detail"))
        QueryList.Add(New ReportQueryItem(ParameterQuerySQL, "Master"))
        OledbXMLReportData.GenMultiRecordset(Me, QueryList)
        'OledbJsonReportData.GenMultiRecordset(Me, QueryList)
    End Sub
</script>