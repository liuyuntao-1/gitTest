﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = "select * from OrderDetails where OrderID=" + Request.QueryString["OrderID"];
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 