﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format("select * from Products " +
            "where ProductID>={0} and ProductID<={1} " +
            "order by ProductID", Request.QueryString["BeginNo"], Request.QueryString["EndNo"]);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 