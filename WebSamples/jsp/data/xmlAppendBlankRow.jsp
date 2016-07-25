﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = "select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity,"
+ "d.UnitPrice*d.Quantity as Amount "
+ "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) "
+ "on m.orderid=d.orderid "
+ "where (m.OrderDate between '1996-1-1' And '1997-9-30') and d.Productid<10 "
+ "order by d.ProductID";
XML_GenOneRecordset(response, QuerySQL);
%> 