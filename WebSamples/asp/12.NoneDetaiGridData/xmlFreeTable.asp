﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select * from Employees where EmployeeID=5"
            
GenParameterReportData(QuerySQL)
%> 