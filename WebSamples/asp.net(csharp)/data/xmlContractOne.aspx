﻿<%@ Page Language="C#" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //string Xml = "<report>\r\n"
        //    + "<_grparam>\r\n"
        //    + "<PayTo>广州锐浪软件</PayTo>\r\n"
        //    + "<Date>2008-8-8</Date>\r\n"
        //    + "<Year>2008</Year>\r\n"
        //    + "<Month>8</Month>\r\n"
        //    + "<Day>8</Day>\r\n"
        //    + "<Amount>198188</Amount>\r\n"
        //    + "<Usage>货款</Usage>\r\n"
        //    + "<Remark>购买报表软件</Remark>\r\n"
        //    + "</_grparam>\r\n"
        //    + "</report>";
        //Response.Write(Xml);

        const string ParameterQuerySQL = 
            "select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate, "
            + "p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount "
            + "from (Orders m inner join "
            + "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) "
            + "left join Customers c on c.CustomerID=m.CustomerID "
            + "where m.OrderID=10252 and d.ProductID=20 "
            + "order by m.OrderDate, m.OrderID";

        //这里查询出来的数据将传递给报表中与字段同名的参数或部件框
        //OledbXMLReportData.GenOneRecordset(this, ParameterQuerySQL);
        OledbJsonReportData.GenOneRecordset(this, ParameterQuerySQL);
    }
</script> 