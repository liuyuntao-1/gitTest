﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select * from Customers order by Region,City" 
GenNodeXmlData(QuerySQL)
%>
 