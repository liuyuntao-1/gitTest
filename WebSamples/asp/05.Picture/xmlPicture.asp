<!--#include file="../data/GenXmlData.asp"-->
<%

QuerySQL = "select CategoryID,CategoryName,Description,Picture,PictureFile From Categories Order by CategoryID"
GenNodeXmlDataForBin64(QuerySQL)
%>