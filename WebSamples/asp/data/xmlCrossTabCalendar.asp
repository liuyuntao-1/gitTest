﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select m.OrderDate,sum(d.Quantity) as Qty,sum(d.UnitPrice*d.Quantity) as Amount " &_
    "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " &_
    "where m.OrderDate between '1/1/1997' and '12/31/1997' " &_
    "group by m.OrderDate " &_
    "order by m.OrderDate"
GenNodeXmlData(QuerySQL)
%> 