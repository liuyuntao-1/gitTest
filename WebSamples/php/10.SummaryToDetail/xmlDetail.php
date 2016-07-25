<? include '../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity,
d.UnitPrice*d.Quantity as Amount
from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID)
on m.orderid=d.orderid 
where (m.OrderDate between '%s' And '%s') and d.Productid=%s
order by m.OrderDate
QuerySQL;
$RealQuerySQL = sprintf($QuerySQL, $_GET['BeginDate'], $_GET['EndDate'], $_GET['ProductID']);
XML_GenOneRecordset($RealQuerySQL);
?> 