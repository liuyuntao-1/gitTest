<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string QuerySQL =
            "select m.OrderID,m.CustomerId,m.OrderDate,d.ProductID,p.ProductName,d.UnitPrice,d.Quantity, "
            + "d.UnitPrice*d.Quantity as Amount "
            + "from (Orders m inner join OrderDetails as d on m.OrderID=d.OrderID) "
            + "left outer join Products p on p.ProductID=d.ProductID "
            + "where m.OrderID<=10300 "
            + "order by m.OrderDate, m.OrderID";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script>