﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,c.ContactName+c.Phone as Remark, "
QuerySQL = QuerySQL & "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount "
QuerySQL = QuerySQL & "from (Orders m inner join (OrderDetails d inner join Products p on p.ProductID=d.ProductID) "
QuerySQL = QuerySQL & "on d.OrderID=m.OrderID) left join Customers c on c.CustomerID=m.CustomerID "
QuerySQL = QuerySQL & "where m.OrderID>=10255 and m.OrderID<10260 "
GenNodeXmlData(QuerySQL)
%> 