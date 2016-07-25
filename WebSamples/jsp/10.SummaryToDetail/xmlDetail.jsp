﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity, " +
            "d.UnitPrice*d.Quantity as Amount " +
            "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " +
            "on m.orderid=d.orderid " +
            "where (m.OrderDate between '" + request.getParameter("BeginDate") + "' And '" + request.getParameter("EndDate") + "') " +
            "and d.Productid=" + request.getParameter("ProductID") + " " +
            "order by m.OrderDate ";
XML_GenOneRecordset(response, QuerySQL);
%>
 