﻿<!--#include file="GenXmlData.asp"-->
<%
//第一个查询SQL串指定报表明细数据的查询SQL
//第二个查询SQL串指定报表参数数据的查询SQL
RecordsetQuerySQL = "select d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount "
RecordsetQuerySQL = RecordsetQuerySQL & "from OrderDetails as d inner join Products p on P.ProductID=D.ProductID "
RecordsetQuerySQL = RecordsetQuerySQL & "where d.OrderID=10255"

ParameterQuerySQL = "select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,c.ContactName+c.Phone as Remark "
ParameterQuerySQL = ParameterQuerySQL & "from Orders m left join Customers c on c.CustomerID=m.CustomerID "
ParameterQuerySQL = ParameterQuerySQL & "where m.OrderID=10255"

GenEntireReportData RecordsetQuerySQL, ParameterQuerySQL
%> 