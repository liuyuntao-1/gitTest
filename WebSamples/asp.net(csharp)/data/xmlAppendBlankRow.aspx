﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        string QuerySQL = string.Format("select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity," +
        "d.UnitPrice*d.Quantity as Amount " +
        "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " +
        "on m.orderid=d.orderid " +
        "where (m.OrderDate between {0}1996-1-1{0} And {0}1997-9-30{0}) and d.Productid<10 " +
        "order by d.ProductID", OledbReportData.DateSqlBracketChar);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 