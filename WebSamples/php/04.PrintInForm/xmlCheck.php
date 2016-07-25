<? include '../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据

//产生形如下面的XML数据，供报表载入
/*
<report>
<_grparam>
<PayTo>广州锐浪软件</PayTo>
<Date>2008-8-8</Date>
<Year>2008</Year>
<Month>8</Month>
<Day>8</Day>
<Amount>198188</Amount>
<Usage>货款</Usage>
<Remark>购买报表软件</Remark>
</_grparam>
</report>
*/
/*
$ParameterQuerySQL = <<<ParameterQuerySQL
select c.CompanyName as Payto,
m.OrderDate as [Date],
Year(m.OrderDate) as [Year],
Month(m.OrderDate) as [Month],
Day(m.OrderDate) as [Day],
m.Freight+1000 as Amount,
m.ShipAddress as [Usage],
C.Address as Remark
from Orders m left join Customers c on c.CustomerID=m.CustomerID
where m.OrderID=10255
ParameterQuerySQL;
*/
$ParameterQuerySQL = <<<ParameterQuerySQL
select c.CompanyName as Payto,
m.Freight+1000 as Amount,
C.Address as Remark
from Orders m, Customers c
where c.CustomerID=m.CustomerID and m.OrderID=10255
ParameterQuerySQL;

GenParameterXmlData($ParameterQuerySQL, false);
?>
