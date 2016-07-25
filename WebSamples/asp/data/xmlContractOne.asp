﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL =  "select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate, " _
    & "p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount " _
    & "from (Orders m inner join " _
    & "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " _
    & "left join Customers c on c.CustomerID=m.CustomerID " _
    & "where m.OrderID=10252 and d.ProductID=20 " _
    & "order by m.OrderDate, m.OrderID"
GenParameterReportData(QuerySQL)
%> 