<? include 'mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select c.CompanyName,m.OrderDate,d.UnitPrice*d.Quantity as Amount 
from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) 
left join Customers c on c.CustomerID=m.CustomerID 
where m.OrderDate between '1997-7-1' and '1997-7-10' 
order by c.CompanyName, m.OrderDate
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
