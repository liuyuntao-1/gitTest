﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format(
            "select d.Productid,sum(d.Quantity) as Quantity,sum(d.UnitPrice*d.Quantity) as Amount "
			+ "from orders m inner join OrderDetails d on m.orderid=d.orderid "
            + "where (m.OrderDate between {0}1997-1-1{0} And {0}1997-3-31{0}) "
			+ "group by d.ProductID "
			+ "order by d.ProductID ", OledbReportData.DateSqlBracketChar);
        OledbReportData.FullGenNodeXmlData(this, QuerySQL, false);
    }
</script> 