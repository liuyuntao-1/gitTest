﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = 
            "select m.OrderID,m.CustomerId,m.OrderDate,d.ProductID,p.ProductName,d.UnitPrice,d.Quantity, "
            + "d.UnitPrice*d.Quantity as Amount "
            + "from (Orders m inner join OrderDetails as d on m.OrderID=d.OrderID) "
            + "left outer join Products p on p.ProductID=d.ProductID "
            + "where m.OrderID<=10300 "
            + "order by m.OrderDate, m.OrderID";
XML_GenOneRecordset(response, QuerySQL);
%> 