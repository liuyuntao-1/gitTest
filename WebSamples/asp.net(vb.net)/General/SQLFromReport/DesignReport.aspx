<%@ Page Language="VB" %>

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Web报表(B/S报表)演示, 在网页中应用报表设计器设计报表 - <%=Request.QueryString("Report")%></title>
	<script src="../../CreateControl.js" type="text/javascript"></script>
	<script type="text/javascript">
function OnSaveReport()
{
	//alert("为了保护报表的正常演示，这里放弃了对报表设计的保存！");
	//ReportDesigner.DefaultAction = false;
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
	        Report = "../../grf/" + Report;
	        
	    CreateDesignerEx("100%", "100%", Report, "DesignReportSave.aspx?Report=<%=Request.QueryString("Report")%>", "", "<param name=OnSaveReport value=OnSaveReport>");
	    
	    CreateReport("ReportObject");
	    ReportObject.LoadFromURL(Report);
		var QuerySQL = ReportObject.DetailGrid.Recordset.QuerySQL;
		ReportDesigner.DataURL = encodeURI("../../data/xmlSQLParam.aspx?QuerySQL=" + QuerySQL);
	</script>
</body>
</html>