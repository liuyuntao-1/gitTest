﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format("select Month(m.OrderDate) As TheMonth,sum(d.UnitPrice*d.Quantity*(1-d.Discount)) as Amount " +
			"from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " +
			"on m.orderid=d.orderid " +
            "where m.OrderDate between {1}1/1/97{1} And {1}12/31/97{1} and p.CategoryID={0} " +
            "group by Month(m.OrderDate) " +
			"order by Month(m.OrderDate) ",
            Request.QueryString["CategoryID"], OledbReportData.DateSqlBracketChar);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 