﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        OracleXMLReportData.GenOneRecordset(this, "select * from EMPLOYEES");
    }
</script> 