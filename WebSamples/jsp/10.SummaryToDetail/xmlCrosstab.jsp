﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select d.ProductID,p.ProductName,m.OrderDate,d.UnitPrice*d.Quantity as Amount " +
    "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " +
    "left join Products p on d.ProductID=p.ProductID " +
    "where m.OrderDate between '1997-1-1' and '1997-12-31' " +
    "order by p.ProductName, m.OrderDate";
XML_GenOneRecordset(response, QuerySQL);
%> 