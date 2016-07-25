<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        'OledbXMLReportData.GenOneRecordset(Me, "select * from Orders where OrderID<=10255 order by OrderID")
        Const RelateCustomerQuerySQL As String = _
            "select o.OrderID, o.ShipCity, c.* from Customers c, Orders o " _
            & "where OrderID<=10260 and c.City=o.ShipCity " _
            & "order by o.OrderID"
        
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem("select * from Orders where OrderID<=10260 order by OrderID", "Master"))
        QueryList.Add(New ReportQueryItem("select * from OrderDetails where OrderID<=10260", "Detail1"))
        QueryList.Add(New ReportQueryItem(RelateCustomerQuerySQL, "Detail2"))
        OledbXMLReportData.GenMultiRecordset(Me, QueryList)
        'OledbJsonReportData.GenMultiRecordset(Me, QueryList)
    End Sub
</script>