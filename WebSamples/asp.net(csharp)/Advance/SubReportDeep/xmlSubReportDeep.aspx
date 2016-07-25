<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string CustomerQuerySQL = "select * from Customers where CustomerID>='B' and CustomerID<'C' order by CustomerID";
        string OrderQuerySQL = "select * from Orders where CustomerID>='B' and CustomerID<'C' and OrderID<10600 order by OrderID";
        string OrderDetailQuerySQL = "select d.* from Orders m, OrderDetails d " +
            "where m.OrderID=d.OrderID and m.CustomerID>='B' and m.CustomerID<'C'and m.OrderID<10600 " +
            "order by d.OrderID";
        
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem(CustomerQuerySQL, "Customer"));
        QueryList.Add(new ReportQueryItem(OrderQuerySQL, "Order"));
        QueryList.Add(new ReportQueryItem(OrderDetailQuerySQL, "OrderDetail"));
        //OledbXMLReportData.GenMultiRecordset(this, QueryList);
        OledbJsonReportData.GenMultiRecordset(this, QueryList);
    }
</script> 