﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = "select * from Suppliers where City='" + Request.QueryString["City"] + "'";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 