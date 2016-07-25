﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select d.Productid,sum(d.Quantity) as Quantity,sum(d.UnitPrice*d.Quantity) as Amount "
			+ "from orders m inner join OrderDetails d on m.orderid=d.orderid "
			+ "where (m.OrderDate between '1997-1-1' And '1997-3-31') "
			+ "group by d.ProductID "
			+ "order by d.ProductID ";
XML_GenOneRecordset(response, QuerySQL);
%> 