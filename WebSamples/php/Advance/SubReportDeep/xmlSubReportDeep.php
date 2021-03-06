<? include '../../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据

$CustomerQuerySQL = "select * from Customers where CustomerID>='B' and CustomerID<'C' order by CustomerID";
$OrderQuerySQL = "select * from Orders where CustomerID>='B' and CustomerID<'C' and OrderID<10600 order by OrderID";
$OrderDetailQuerySQL = "select d.* from Orders m, OrderDetails d where m.OrderID=d.OrderID and m.CustomerID>='B' and m.CustomerID<'C'and m.OrderID<10600 order by d.OrderID";

$QueryList = array (
    "Customer" => $CustomerQuerySQL,
    "Order" => $OrderQuerySQL,
    "OrderDetail" => $OrderDetailQuerySQL,
);
XML_GenMultiRecordset($QueryList);
?>
 