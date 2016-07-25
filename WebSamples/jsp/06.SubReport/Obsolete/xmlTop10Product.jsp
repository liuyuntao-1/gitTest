﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty "
+ "from OrderDetails o, Products p "
+ "where o.ProductID=p.ProductID and p.ProductID<=10 "
+ "group by p.ProductID, p.ProductName "
+ "order by sum(Quantity*o.UnitPrice) desc";
XML_GenOneRecordset(response, QuerySQL);
%>
 