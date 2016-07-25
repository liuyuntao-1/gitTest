<? include '../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select p.ProductName,Month(m.OrderDate) As MonthData,sum(d.UnitPrice*d.Quantity) as Amount 
from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) 
where m.OrderDate between '%s' And '%s' and p.ProductID < 5 
group by Month(m.OrderDate),p.ProductName 
order by Month(m.OrderDate),p.ProductName
QuerySQL;
$RealQuerySQL = sprintf($QuerySQL, $_GET['BeginDate'], $_GET['EndDate']);
XML_GenOneRecordset($RealQuerySQL);
?> 