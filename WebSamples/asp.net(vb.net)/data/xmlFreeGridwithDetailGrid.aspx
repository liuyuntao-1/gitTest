<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        '第一个查询SQL串指定报表明细数据的查询SQL
        '第二个查询SQL串指定报表参数数据的查询SQL
        Const RecordsetQuerySQL As String = "select * from Employees where EmployeeID<8"
        Const ParameterQuerySQL As String = "select * from Employees where EmployeeID=8"
        'OledbXMLReportData.GenEntireData(Me, RecordsetQuerySQL, ParameterQuerySQL)
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem(RecordsetQuerySQL, "Detail"))
        QueryList.Add(New ReportQueryItem(ParameterQuerySQL, "Master"))
        OledbXMLReportData.GenMultiRecordset(Me, QueryList)
    End Sub
</script>