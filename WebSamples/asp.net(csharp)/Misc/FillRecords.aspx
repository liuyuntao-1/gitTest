﻿<%@ Page Language="C#"%>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
	<title>Web报表(B/S报表)演示　－ 服务端生成加载报表数据脚本代码</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<script src="../CreateControl.js" type="text/javascript"></script>
	<script type="text/javascript">
//在网页初始加载时向报表提供数据
function window_onload() {
    ReportViewer.Stop();
    
    var Recordset = ReportViewer.Report.DetailGrid.Recordset;
    var fldCustomerID = ReportViewer.Report.FieldByName("CustomerID");
    var fldCompanyName = ReportViewer.Report.FieldByDBName("CompanyName");
    var fldContactName = ReportViewer.Report.FieldByDBName("ContactName");
    var fldContactTitle = ReportViewer.Report.FieldByDBName("ContactTitle");
    var fldAddress = ReportViewer.Report.FieldByDBName("Address");
    var fldCity = ReportViewer.Report.FieldByDBName("City");
    var fldRegion = ReportViewer.Report.FieldByDBName("Region");
    var fldPostalCode = ReportViewer.Report.FieldByDBName("PostalCode");
    var fldCountry = ReportViewer.Report.FieldByDBName("Country");
    var fldPhone = ReportViewer.Report.FieldByDBName("Phone");
    var fldFax = ReportViewer.Report.FieldByDBName("Fax");

    ReportViewer.Report.PrepareLoadData();

    <%
    //const string OleDbConnStr = "Provider=SQLOLEDB.1;Persist Security Info=True;Data Source=;Initial Catalog=gridreport;User ID=sa;Password=;";
    OleDbConnection ReportConn = new OleDbConnection(OledbReportData.OleDbConnStr);
	OleDbCommand ocmd = new OleDbCommand("select * from Customers order by Region,City", ReportConn);
	ReportConn.Open();
	OleDbDataReader dr = ocmd.ExecuteReader(CommandBehavior.CloseConnection);
        
	while (dr.Read())
	{
	%>
		Recordset.Append();
		fldCustomerID.Value = "<%=dr.GetString(0)%>";
		fldCompanyName.AsString = "<%=dr.GetString(1)%>";
		fldContactName.AsString = "<%=dr.GetString(2)%>";
		fldContactTitle.AsString = "<%=dr.GetString(3)%>";
		fldAddress.AsString = "<%=dr.GetString(4)%>";
		fldCity.AsString = "<%=dr.GetString(5)%>";
		fldRegion.AsString = "<%=dr.GetString(6)%>";
		fldPostalCode.AsString = "<%=dr.GetString(7)%>";
		fldCountry.AsString = "<%=dr.GetString(8)%>";
		fldPhone.AsString = "<%=dr.GetString(9)%>";
		<% if ( !dr.IsDBNull(10) ) {%>
		    fldFax.AsString = "<%=dr.GetString(10)%>";
		<% } %>
		Recordset.Post();
                
    <%
    } 

	dr.Close();
    %>
	    
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
<body  style="margin:0"  onload="window_onload()">
    <table height="100%" width="100%">
        <tr>
            <td style="font-size: 10pt; height: 15px; width: 100%;">
            这个例子演示在服务器端根据记录集产生填充报表数据集的脚本代码，从而将服务端的数据传递到报表中。
            </td>
        </tr>
        <tr height="100%">
            <td height="100%">
                <script type="text/javascript"> 
                    CreatePrintViewerEx("100%", "100%", "../grf/1a.grf", "", false, "<param name=BorderStyle value=1>");
                </script>
            </td>
        </tr>
    </table>
</body>
</html> 
