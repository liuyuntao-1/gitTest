<? include 'mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,c.ContactName,c.Address,c.city,c.Region,c.Country,c.Postalcode,
m.OrderDate,M.Freight,d.ProductID,p.ProductName,
d.UnitPrice,d.Quantity,d.Discount,
d.UnitPrice*d.Quantity as Amount,
d.UnitPrice*d.Quantity*d.Discount as DiscountAmt,
d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount 
from (Orders m inner join 
(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) 
left join Customers c on c.CustomerID=m.CustomerID 
where m.OrderDate between '1997-1-1' And '1997-1-15' 
order by m.CustomerID,m.OrderDate, m.OrderID
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
