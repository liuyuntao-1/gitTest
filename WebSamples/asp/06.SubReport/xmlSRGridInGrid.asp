﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select * from Orders where OrderID<=10255 order by OrderID"
GenNodeXmlData(QuerySQL)
%>
 