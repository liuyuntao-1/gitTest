﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select m.OrderID,m.CustomerId,c.CompanyName,c.ContactName,c.Address,c.city,c.Region,c.Country,c.Postalcode,"
QuerySQL = QuerySQL & "m.OrderDate,M.Freight,d.ProductID,p.ProductName,"
QuerySQL = QuerySQL & "d.UnitPrice,d.Quantity,d.Discount,"
QuerySQL = QuerySQL & "d.UnitPrice*d.Quantity as Amount," 
QuerySQL = QuerySQL & "d.UnitPrice*d.Quantity*d.Discount as DiscountAmt,"
QuerySQL = QuerySQL & "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount "
QuerySQL = QuerySQL & "from (Orders m inner join "
QuerySQL = QuerySQL & "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) "
QuerySQL = QuerySQL & "left join Customers c on c.CustomerID=m.CustomerID "
QuerySQL = QuerySQL & "where m.OrderDate between '1/1/1997' And '1/15/1997' "
QuerySQL = QuerySQL & "order by m.CustomerID,m.OrderDate, m.OrderID"
GenNodeXmlData(QuerySQL)
%> 