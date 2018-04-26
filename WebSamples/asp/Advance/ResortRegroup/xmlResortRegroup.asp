﻿<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "select D.OrderID,D.ProductID,P.ProductName,D.UnitPrice,D.Quantity," _
    & "O.CustomerID,C.CompanyName,O.EmployeeID,E.LastName+E.FirstName as EmployeeName, " _
    & "D.Quantity*D.UnitPrice as Amount, " _
    & "O.OrderDate " _
    & "from OrderDetails D,Orders O,Products P,Employees E,Customers C " _
    & "where D.OrderID=O.OrderID and D.ProductID=P.ProductID and O.EmployeeID=E.EmployeeID and C.CustomerID=O.CustomerID " _
    & "and O.OrderDate between '1/1/1997' And '1/31/1997'"
GenNodeXmlData(QuerySQL)
%> 