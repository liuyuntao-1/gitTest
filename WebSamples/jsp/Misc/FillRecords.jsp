﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ page import="javax.servlet.jsp.JspWriter"%>
<%@ page import="javax.servlet.http.HttpServletResponse"%>
<%@ page import="java.util.zip.DeflaterOutputStream"%>
<%@ page import="java.lang.*, java.io.*, java.sql.*, java.util.*"%>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title>Web报表(B/S报表)演示　－ 服务端生成加载报表数据脚本代码</title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
    try
    {
        String url="jdbc:odbc:webreport";
        Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");                // Class.forName 装载驱动程序 
        Connection con=DriverManager.getConnection(url, "sa", "");    //用适当的驱动程序类与 DBMS 建立一个连接
        Statement stmt=con.createStatement();                         //用于发送简单的SQL语句
        ResultSet rs=stmt.executeQuery("select * from Customers order by Region,City");
        while( rs.next() ) 
	    {
	%>
		    Recordset.Append();
		    fldCustomerID.Value = "<%=rs.getString(1)%>";
		    fldCompanyName.AsString = "<%=rs.getString(2)%>";
		    fldContactName.AsString = "<%=rs.getString(3)%>";
		    fldContactTitle.AsString = "<%=rs.getString(4)%>";
		    fldAddress.AsString = "<%=rs.getString(5)%>";
		    fldCity.AsString = "<%=rs.getString(6)%>";
		    fldRegion.AsString = "<%=rs.getString(7)%>";
		    fldPostalCode.AsString = "<%=rs.getString(8)%>";
		    fldCountry.AsString = "<%=rs.getString(9)%>";
		    fldPhone.AsString = "<%=rs.getString(10)%>";
		    fldFax.AsString = "<%=rs.getString(11)%>";
		    Recordset.Post();
    <%
        } 
        rs.close();
        stmt.close();
        con.close();
    }
    catch(Exception e)
    {
        //out.println(e.toString());
    }
    %>
	    
    ReportViewer.Start();
}
// ]]>
		</script>
		
	</head>
	<body onload="window_onload()">
        这个例子演示在服务器端根据记录集产生填充报表数据集的脚本代码，从而将服务端的数据传递到报表中。
	    <script type="text/javascript"> 
            CreatePrintViewerEx("100%", "90%", "../grf/1a.grf", "", false, "<param name=BorderStyle value=1>");
	    </script>
	</body>
</html> 