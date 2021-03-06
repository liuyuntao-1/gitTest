﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string QuerySQL = "select top 10 c.CustomerID, c.CompanyName, sum(o.Quantity*o.UnitPrice) As SumAmt " +
            "from OrderDetails o, Orders m, customers c " +
            "where o.OrderID=m.OrderID and m.CustomerID=c.CustomerID " +
            "group by c.CustomerID, c.CompanyName " +
            "order by sum(o.Quantity*o.UnitPrice) desc";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
        //OledbXMLReportData.GenOneRecordset(this, QuerySQL, ResponseDataType.PlainText);
    }
</script> 