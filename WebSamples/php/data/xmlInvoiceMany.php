<? include 'mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,c.ContactName+c.Phone as Remark,
d.OrderID,d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount 
from (Orders m inner join (OrderDetails d inner join Products p on p.ProductID=d.ProductID) 
on d.OrderID=m.OrderID) left join Customers c on c.CustomerID=m.CustomerID 
where m.OrderID>=10255 and m.OrderID<10260
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
