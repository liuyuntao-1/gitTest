<? include '../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据

$Top10CustomerQuerySQL = <<<QuerySQL
select c.CustomerID, c.CompanyName, sum(o.Quantity*o.UnitPrice) As SumAmt 
from OrderDetails o, Orders m, customers c 
where o.OrderID=m.OrderID and m.CustomerID=c.CustomerID and c.CustomerID<'BS'
group by c.CustomerID, c.CompanyName 
order by sum(o.Quantity*o.UnitPrice) desc
QuerySQL;

$Top10ProductQuerySQL = <<<QuerySQL
select p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty 
from OrderDetails o, Products p 
where o.ProductID=p.ProductID and p.ProductID<=10
group by p.ProductID, p.ProductName 
order by sum(Quantity*o.UnitPrice) desc
QuerySQL;
        
$QueryList = array (
    "Customer" => "select * from Customers order by CustomerID",
    "Product" => "select * from Products order by ProductName",
    "Top10Customer" => $Top10CustomerQuerySQL,
    "Top10Product" => $Top10ProductQuerySQL
);
XML_GenMultiRecordset($QueryList);
?>
 