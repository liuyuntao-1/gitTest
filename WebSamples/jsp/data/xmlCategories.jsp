﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = "select * from categories ";
XML_GenOneRecordset(response, QuerySQL);
%>
 