﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format("select d.Productid,p.ProductName,m.OrderId, m.OrderDate,d.Quantity, "
			+ "d.UnitPrice*d.Quantity as Amount "
			+ "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) "
			+ "on m.orderid=d.orderid "
            + "where (m.OrderDate between {0}1997-4-1{0} And {0}1997-6-30{0}) "
            + "order by d.ProductID,m.OrderDate", OledbReportData.DateSqlBracketChar);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 