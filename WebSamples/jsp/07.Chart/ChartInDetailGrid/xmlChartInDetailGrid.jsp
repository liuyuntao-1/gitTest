﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select Month(m.OrderDate) As TheMonth,sum(d.UnitPrice*d.Quantity*(1-d.Discount)) as Amount " +
			"from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " +
			"on m.orderid=d.orderid " +
            "where m.OrderDate between '1/1/97' And '12/31/97' and p.CategoryID=" + request.getParameter("CategoryID") + " " +
            "group by Month(m.OrderDate) " +
			"order by Month(m.OrderDate) ";
XML_GenOneRecordset(response, QuerySQL);
%>
 