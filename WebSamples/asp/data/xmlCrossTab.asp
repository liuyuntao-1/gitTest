﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select c.City,m.CustomerId,c.CompanyName,d.ProductID,p.ProductName,"
QuerySQL = QuerySQL & "d.Quantity, d.UnitPrice*d.Quantity as Amount "
QuerySQL = QuerySQL & "from (Orders m inner join "
QuerySQL = QuerySQL & "(OrderDetails as d inner join Products p "
QuerySQL = QuerySQL & "on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) "
QuerySQL = QuerySQL & "left join Customers c on c.CustomerID=m.CustomerID "
QuerySQL = QuerySQL & "where d.ProductID<8 "
QuerySQL = QuerySQL & "order by c.City,m.CustomerId, d.ProductID"
GenNodeXmlData(QuerySQL)
%> 