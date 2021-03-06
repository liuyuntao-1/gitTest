﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select p.ProductName,Month(m.OrderDate) As MonthData,sum(d.UnitPrice*d.Quantity) as Amount " _
            & "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " _
            & "where m.OrderDate between '" & Request.QueryString("BeginDate") &  "' and '" & Request.QueryString("EndDate") &  "' and p.ProductID < 5 " _
            & "group by p.ProductName,Month(m.OrderDate) " _
            & "order by p.ProductName,Month(m.OrderDate)"
GenNodeXmlData(QuerySQL)
%> 