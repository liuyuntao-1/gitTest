﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = "select EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,"
+ "Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes from Employees";
XML_GenOneRecordset(response, QuerySQL);
%> 