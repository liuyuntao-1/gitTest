<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "select * from Products " _
    & "where ProductID>=" & Request.QueryString("BeginNo") & "and ProductID<=" & Request.QueryString("EndNo") _
    & " order by ProductID"
GenNodeXmlData(QuerySQL)
%>