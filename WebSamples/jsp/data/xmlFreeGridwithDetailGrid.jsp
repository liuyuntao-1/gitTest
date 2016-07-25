<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String RecordsetQuerySQL = "select * from Employees where EmployeeID<8";
String ParameterQuerySQL = "select * from Employees where EmployeeID=8";

ArrayList<ReportQueryItem> QueryItems = new ArrayList<ReportQueryItem>();
QueryItems.add( new ReportQueryItem(ParameterQuerySQL, "Master") );
QueryItems.add( new ReportQueryItem(RecordsetQuerySQL, "Detail") );

XML_GenMultiRecordset(response, QueryItems);
%>