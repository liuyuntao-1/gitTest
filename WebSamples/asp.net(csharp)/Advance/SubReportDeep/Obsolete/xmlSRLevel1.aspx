﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = "select * from Orders where CustomerID='" + Request.QueryString["CustomerID"] + 
        "' and OrderDate between '1997-1-1' and '1997-12-31' order by OrderID";
        SqlReportData.GenNodeXmlData(this, QuerySQL, true);
    }
</script> 