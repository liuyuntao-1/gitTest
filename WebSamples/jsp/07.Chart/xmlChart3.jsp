﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = 
            "select p.ProductName,Month(m.OrderDate)-1 As MonthData,sum(d.UnitPrice*d.Quantity) as Amount " +
            "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " +
            "where m.OrderDate between '" + request.getParameter("BeginDate") + "' and '" + request.getParameter("EndDate") + "' and p.ProductID < 5 " +
            "group by p.ProductName,Month(m.OrderDate)-1 " +
            "order by p.ProductName,Month(m.OrderDate)-1";
XML_GenOneRecordset(response, QuerySQL);
%> 