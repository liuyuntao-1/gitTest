<%@ Page Language="VB"%>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
	<head>
		<title>Web报表(B/S报表)演示　－ 服务端生成加载报表数据脚本代码</title>
		<META HTTP-EQUIV="Content-Type" CONTENT="text/html; charset=gb2312">
		<script src="../CreateControl.js" type="text/javascript"></script>
		<script type="text/javascript">
// <!CDATA[

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

    ReportViewer.Report.PrepareRecordset();

    <%
    Dim myConn As New OleDbConnection(OledbReportData.OleDBConnStr)
	Dim ocmd As New OleDbCommand("select * from Customers order by Region,City", myConn)
	myConn.Open()
	Dim dr as OleDbDataReader = ocmd.ExecuteReader(CommandBehavior.CloseConnection)
        
	While (dr.Read())
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
		<% If  not dr.IsDBNull(10) %>
		    fldFax.AsString = "<%=dr.GetString(10)%>";
		<% End If %>
		Recordset.Post();
                
    <%
    End While 

	dr.Close()
    %>
	    
    ReportViewer.Start();
}
// ]]>
		</script>
		
	</head>
	<body style="margin:0" onload="window_onload()">
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
</html>