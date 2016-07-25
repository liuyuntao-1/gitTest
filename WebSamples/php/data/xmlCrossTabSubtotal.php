<? include 'mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select t.CategoryName, p.ProductName,c.City,c.CompanyName,d.Quantity
from (Orders m inner join
(OrderDetails as d inner join (Products p inner join Categories t on p.CategoryID=t.CategoryID)
on P.ProductID=D.ProductID) on m.OrderId=d.OrderId)
left join Customers c on c.CustomerID=m.CustomerID
where m.OrderDate between '1997-1-1' and '1997-3-31'
order by t.CategoryName,p.ProductName,c.City,c.CompanyName
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
