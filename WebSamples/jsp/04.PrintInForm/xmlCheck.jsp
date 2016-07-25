﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = 
"select c.CompanyName as Payto,"
+ "m.OrderDate as Date,"
+ "Year(m.OrderDate) as Year,"
+ "Month(m.OrderDate) as Month,"
+ "Day(m.OrderDate) as Day,"
+ "m.Freight+1000 as Amount,"
+ "m.ShipAddress as Usage1,"
+ "c.Address as Remark "
+ "from Orders m left join Customers c on c.CustomerID=m.CustomerID "
+ "where m.OrderID=10255";
XML_GenOneRecordset(response, QuerySQL);
%> 