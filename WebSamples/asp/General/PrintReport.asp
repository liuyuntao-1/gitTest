﻿<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
        <title>Web报表(B/S报表)演示, 用报表打印显示器插件(打印预览插件)展现报表 - <%=Request.QueryString("Report")%></title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
		<script src="../CreateControl.js" type="text/javascript"></script>
        <style type="text/css">
            html,body {
                margin:0;
                height:100%;
            }
        </style>
	</head>
	<body style="margin:0">
	<script type="text/javascript"> 
	    var Report = "<%=Request.QueryString("Report")%>";
	    if (Report != "")
	        Report = "../grf/" + Report;
	        
	    var Data = "<%=Request.QueryString("Data")%>";
	    if (Data != "")
	        Data = "../" + Data;
	        
	    CreatePrintViewerEx("100%", "100%", Report, Data, true, "");
	</script>
	</body>
</html>
 