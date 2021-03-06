﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = "select m.OrderID,m.OrderDate, " +
    "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount  " +
    "from Orders m inner join  " +
    "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId " +
    "where m.OrderDate between '1997-6-1' and '1997-12-31' " +
    "order by d.ProductID, m.OrderDate";
XML_GenOneRecordset(response, QuerySQL);
%> 