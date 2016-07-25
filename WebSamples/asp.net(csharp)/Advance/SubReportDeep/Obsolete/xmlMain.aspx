<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlReportData.GenNodeXmlData(this, "select * from Customers where CustomerID>='B' and CustomerID<'C' order by CustomerID", true);
    }
</script> 