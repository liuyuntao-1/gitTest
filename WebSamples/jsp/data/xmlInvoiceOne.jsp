<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String RecordsetQuerySQL = "select d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount "
    + "from OrderDetails as d inner join Products p on P.ProductID=D.ProductID "
    + "where d.OrderID=10255";
    
String ParameterQuerySQL = "select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,c.ContactName+c.Phone as Remark "
    + "from Orders m left join Customers c on c.CustomerID=m.CustomerID "
    + "where m.OrderID=10255";

ArrayList<ReportQueryItem> QueryItems = new ArrayList<ReportQueryItem>();
QueryItems.add( new ReportQueryItem(ParameterQuerySQL, "Master") );
QueryItems.add( new ReportQueryItem(RecordsetQuerySQL, "Detail") );
XML_GenMultiRecordset(response, QueryItems);
%>