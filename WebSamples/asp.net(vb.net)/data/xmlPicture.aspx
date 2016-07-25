<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Const QuerySQL As String = "select EmployeeID,LastName+FirstName as Name,Title,TitleOfCourtesy,BirthDate,HireDate," _
            & "Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes from Employees"
        
        '包含图像数据的报表一般不要采用压缩方式，图像数据本身已压缩，再压缩反而有可能增大数据量
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>