﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
ArrayList<ReportQueryItem> QueryItems = new ArrayList<ReportQueryItem>();
QueryItems.add(new ReportQueryItem("select * from Customers order by CustomerID", "Customer"));
QueryItems.add(new ReportQueryItem("select * from Products order by ProductName", "Product"));
QueryItems.add(new ReportQueryItem("select * from Customers order by CustomerID", "Customer2"));
XML_GenMultiRecordset(response, QueryItems);
%> 