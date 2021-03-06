﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String Top10CustomerQuerySQL = 
    "select top 10 c.CustomerID, c.CompanyName, sum(o.Quantity*o.UnitPrice) As SumAmt " +
    "from OrderDetails o, Orders m, customers c " +
    "where o.OrderID=m.OrderID and m.CustomerID=c.CustomerID " +
    "group by c.CustomerID, c.CompanyName " +
    "order by sum(o.Quantity*o.UnitPrice) desc";
String Top10ProductQuerySQL = 
    "select top 10 p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty " +
    "from OrderDetails o, Products p " +
    "where o.ProductID=p.ProductID " +
    "group by p.ProductID, p.ProductName " +
    "order by sum(Quantity*o.UnitPrice) desc";

ArrayList<ReportQueryItem> QueryItems = new ArrayList<ReportQueryItem>();
QueryItems.add(new ReportQueryItem("select * from Customers order by CustomerID", "Customer"));
QueryItems.add(new ReportQueryItem("select * from Products order by ProductName", "Product"));
QueryItems.add(new ReportQueryItem(Top10CustomerQuerySQL, "Top10Customer"));
QueryItems.add(new ReportQueryItem(Top10ProductQuerySQL, "Top10Product"));
XML_GenMultiRecordset(response, QueryItems);
%>
 