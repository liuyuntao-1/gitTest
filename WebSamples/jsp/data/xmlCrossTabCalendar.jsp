﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = "select m.OrderDate,sum(d.Quantity) as Qty,sum(d.UnitPrice*d.Quantity) as Amount " +
    "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " +
    "where m.OrderDate between '1997-1-1' and '1997-12-31' " +
    "group by m.OrderDate " +
    "order by m.OrderDate";
XML_GenOneRecordset(response, QuerySQL);
%> 