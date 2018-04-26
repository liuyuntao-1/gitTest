﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem("select * from Customers order by CustomerID", "Customer"));
        QueryList.Add(new ReportQueryItem("select * from Products order by ProductName", "Product"));
        QueryList.Add(new ReportQueryItem("select * from Customers order by CustomerID", "Customer2"));
        OledbXMLReportData.GenMultiRecordset(this, QueryList);
    }
</script> 