﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select CategoryID,CategoryName,Description,Picture,PictureFile From Categories  Order by CategoryID";
XML_GenOneRecordset(response, QuerySQL);
%> 