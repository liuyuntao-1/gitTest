﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select c.CompanyName as Payto,"
QuerySQL = QuerySQL & "m.OrderDate as [Date],"
QuerySQL = QuerySQL & "Year(m.OrderDate) as [Year],"
QuerySQL = QuerySQL & "Month(m.OrderDate) as [Month],"
QuerySQL = QuerySQL & "Day(m.OrderDate) as [Day],"
QuerySQL = QuerySQL & "m.Freight+1000 as Amount,"
QuerySQL = QuerySQL & "m.ShipAddress as [Usage],"
QuerySQL = QuerySQL & "c.Address as Remark "
QuerySQL = QuerySQL & "from Orders m left join Customers c on c.CustomerID=m.CustomerID "
QuerySQL = QuerySQL & "where m.OrderID=10255"
GenParameterReportData(QuerySQL)
%>
 