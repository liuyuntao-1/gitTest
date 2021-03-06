﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = "select c.City,m.CustomerId,c.CompanyName,d.ProductID,p.ProductName,"
+ "d.Quantity, d.UnitPrice*d.Quantity as Amount "
+ "from (Orders m inner join "
+ "(OrderDetails as d inner join Products p "
+ "on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) "
+ "left join Customers c on c.CustomerID=m.CustomerID "
+ "where d.ProductID<8 "
+ "order by c.City,m.CustomerId, d.ProductID";
XML_GenOneRecordset(response, QuerySQL);
%> 