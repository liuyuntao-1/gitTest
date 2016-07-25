<%@ Page Language="C#" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string ParameterQuerySQL = "select c.CompanyName as Payto,"
            + "m.OrderDate as [Date],"
            + "Year(m.OrderDate) as [Year],"
            + "Month(m.OrderDate) as [Month],"
            + "Day(m.OrderDate) as [Day],"
            + "m.Freight+1000 as Amount,"
            + "m.ShipAddress as [Usage],"
            + "c.Address as Remark "
            + "from Orders m left join Customers c on c.CustomerID=m.CustomerID "
            + "where m.OrderID=10255";

        //这里查询出来的数据将传递给报表中与字段同名的参数或部件框
        OledbXMLReportData.GenOneRecordset(this, ParameterQuerySQL);
    }
</script>