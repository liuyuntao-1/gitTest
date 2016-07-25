<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = String.Format("select D.OrderID,D.ProductID,P.ProductName,D.UnitPrice,D.Quantity," _
            & "O.CustomerID,C.CompanyName,O.EmployeeID,E.LastName+E.FirstName as EmployeeName, " _
            & "D.Quantity*D.UnitPrice as Amount, " _
            & "O.OrderDate " _
            & "from OrderDetails D,Orders O,Products P,Employees E,Customers C " _
            & "where D.OrderID=O.OrderID and D.ProductID=P.ProductID and O.EmployeeID=E.EmployeeID and C.CustomerID=O.CustomerID " _
            & "and O.OrderDate between {0}1/1/1997{0} And {0}1/31/1997{0} ", OledbReportData.DateSqlBracketChar)
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>