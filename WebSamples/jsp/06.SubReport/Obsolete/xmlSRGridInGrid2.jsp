﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
//如下转换之后，中文参数才不会乱码，但 mysql 例子还是未转换成功
String City = new String(request.getParameter("City").getBytes(), "utf-8");  
String QuerySQL = "select * from Customers where City='" +  City + "'";
XML_GenOneRecordset(response, QuerySQL);
//ResponseText(response, QuerySQL, ResponseDataType.PlainText);
//ResponseText(response, City, ResponseDataType.PlainText);
%>
 