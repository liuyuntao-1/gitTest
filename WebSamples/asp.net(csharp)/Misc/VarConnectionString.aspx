﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VarConnectionString.aspx.cs" Inherits="Misc_VarConnectionString" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
	<script src="../CreateControl.js" type="text/javascript"></script>
    <script type="text/javascript">
<%
string str = "Provider=SQLOLEDB.1;Persist Security Info=True;Data Source=;Initial Catalog=gridreport;User ID=sa;Password=;";
%>
var OleDbConnStr = "<%=str%>";
	
//改变工具栏按钮
function window_onload() {
    var ReportViewer = document.getElementById("ReportViewer");
    
    ReportViewer.Report.DetailGrid.Recordset.ConnectionString = OleDbConnStr;
    
	ReportViewer.Report.DetailGrid.Recordset.QuerySQL = "select * from Customers order by Region,City";
    
    ReportViewer.Start();
}
    </script>
    <style type="text/css">
        html,body {
            margin:0;
            height:100%;
        }
    </style>
</head>
<body onload="window_onload()">
	<script type="text/javascript"> 
		CreatePrintViewerEx("100%", "100%", "../grf/1a.grf", "", false); 
	</script>
</body>
</html> 
