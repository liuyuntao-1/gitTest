﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select EmployeeID,LastName+FirstName as Name,Title,TitleOfCourtesy,BirthDate,HireDate,"_
& "Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes from Employees"
GenNodeXmlDataForBin64(QuerySQL)
//GenNodeXmlData(QuerySQL)
%>
 