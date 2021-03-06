﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select Month(m.OrderDate)-1 as GroupIndex, " +
            "sum(d.Quantity) as Qty, " +
            "sum(d.UnitPrice*d.Quantity) as Amt," +
            "sum(d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount) as NetAmt " +
            "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " +
            "where m.OrderDate between '" + request.getParameter("BeginDate") + "' and '" + request.getParameter("EndDate") + "' and p.ProductID < 5 " +
            "group by Month(m.OrderDate)-1";
XML_GenOneRecordset(response, QuerySQL);
%> 