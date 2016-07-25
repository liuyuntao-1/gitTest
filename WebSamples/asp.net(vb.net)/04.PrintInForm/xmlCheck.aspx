<%@ Page Language="VB" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.Oledb" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        '产生形如下面的XML数据，供报表载入
<%--        "<report>\r\n"
            + "<_grparam>\r\n"
            + "<PayTo>广州锐浪软件</PayTo>\r\n"
            + "<Date>2008-8-8</Date>\r\n"
            + "<Year>2008</Year>\r\n"
            + "<Month>8</Month>\r\n"
            + "<Day>8</Day>\r\n"
            + "<Amount>198188</Amount>\r\n"
            + "<Usage>货款</Usage>\r\n"
            + "<Remark>购买报表软件</Remark>\r\n"
            + "</_grparam>\r\n"
            + "</report>";
--%>
        const ParameterQuerySQL as string = "select c.CompanyName as Payto," _
            & "m.OrderDate as [Date]," _
            & "Year(m.OrderDate) as [Year]," _
            & "Month(m.OrderDate) as [Month]," _
            & "Day(m.OrderDate) as [Day]," _
            & "m.Freight+1000 as Amount," _
            & "m.ShipAddress as [Usage]," _
            & "C.Address as Remark " _
            & "from Orders m left join Customers c on c.CustomerID=m.CustomerID " _
            & "where m.OrderID=10255"
            
        '这里查询出来的数据将传递给报表中与字段同名的参数或部件框
        OledbXMLReportData.GenOneRecordset(Me, ParameterQuerySQL)
     End Sub
</script>