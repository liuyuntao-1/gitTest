﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select * from Products " +
    "where ProductID>=" + request.getParameter("BeginNo") + " and ProductID<=" + request.getParameter("EndNo") +
    " order by ProductID";
XML_GenOneRecordset(response, QuerySQL);
%> 