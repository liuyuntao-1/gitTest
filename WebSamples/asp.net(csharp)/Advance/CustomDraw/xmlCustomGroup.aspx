<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string QuerySQL = "select d.ProductID,p.ProductName,sum(d.UnitPrice*d.quantity) as amount "
            + "from OrderDetails d inner join Products p on p.Productid=d.Productid "
            + "group by d.ProductID,p.ProductName "
            + "order by sum(d.UnitPrice*d.quantity) desc";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script>