<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string RelateCustomerQuerySQL =
            "select o.OrderID, o.ShipCity, c.* from Customers c, Orders o " +
            "where OrderID<=10260 and c.City=o.ShipCity " +
            "order by o.OrderID";
        
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem("select * from Orders where OrderID<=10260 order by OrderID", "Master"));
        QueryList.Add(new ReportQueryItem("select * from OrderDetails where OrderID<=10260", "Detail1"));
        QueryList.Add(new ReportQueryItem(RelateCustomerQuerySQL, "Detail2"));
        OledbXMLReportData.GenMultiRecordset(this, QueryList);
        //OledbJsonReportData.GenMultiRecordset(this, QueryList);
    }
</script>