﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select * from Orders where CustomerID='" + request.getParameter("CustomerID") + 
                  "' and OrderDate between '1997-1-1' and '1997-12-31' order by OrderID";
XML_GenOneRecordset(response, QuerySQL);
%>
 