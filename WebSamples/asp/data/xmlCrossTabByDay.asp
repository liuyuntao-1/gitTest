﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select c.CompanyName,m.OrderDate,d.UnitPrice*d.Quantity as Amount "
QuerySQL = QuerySQL & "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) "
QuerySQL = QuerySQL & "left join Customers c on c.CustomerID=m.CustomerID "
QuerySQL = QuerySQL & "where m.OrderDate between '7/1/1997' and '7/10/1997' "
QuerySQL = QuerySQL & "order by c.CompanyName, m.OrderDate"
GenNodeXmlData(QuerySQL)
%> 