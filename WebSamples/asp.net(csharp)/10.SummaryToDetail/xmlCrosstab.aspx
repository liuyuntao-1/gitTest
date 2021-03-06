﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format(
            "select d.ProductID,p.ProductName,m.OrderDate,d.UnitPrice*d.Quantity as Amount " +
            "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " +
            "left join Products p on d.ProductID=p.ProductID " +
            "where m.OrderDate between {0}1/1/1997{0} and {0}12/31/1997{0} " +
            "order by p.ProductName, m.OrderDate",OledbReportData.DateSqlBracketChar);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 