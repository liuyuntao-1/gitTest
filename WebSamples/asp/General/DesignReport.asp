﻿<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Web报表(B/S报表)演示，在网页中应用报表设计器设计报表 - <%=Request.QueryString("Report")%></title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<script src="../CreateControl.js" type="text/javascript"></script>
	<script type="text/javascript">
function OnSaveReport()
{
    //注释掉以下两行代码即可将设计结果保存到服务器对应目录下的文件中
	alert("为了保护报表的正常演示，这里放弃了对报表设计的保存！");
	ReportDesigner.DefaultAction = false;
}
	</script>
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
	        
	    CreateDesignerEx("100%", "100%", Report, "DesignReportSave.asp?Report=<%=Request.QueryString("Report")%>", Data, 
	        "<param name='OnSaveReport' value='OnSaveReport'>");
	</script>
</body>
</html>
 