﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select top 10 p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty "_
& "from OrderDetails o, Products p "_
& "where o.ProductID=p.ProductID "_
& "group by p.ProductID, p.ProductName "_
& "order by sum(Quantity*o.UnitPrice) desc"
GenNodeXmlData(QuerySQL)
%>
 