<? include '../../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$City = urldecode($_GET['City']);
//$CustomerQuerySQL = "select * from Customers where City='" . $_GET['City'] . "'";
//$SupplierQuerySQL = "select * from Suppliers where City='" . $_GET['City'] . "'";
$CustomerQuerySQL = "select * from Customers where City='" . $City . "'";
$SupplierQuerySQL = "select * from Suppliers where City='" . $City . "'";
//$CustomerQuerySQL = "select * from Customers where City='北京'";
//$SupplierQuerySQL = "select * from Suppliers where City='北京'";

$QueryList = array (
    "Customer" => $CustomerQuerySQL,
    "Supplier" => $SupplierQuerySQL
);
//XML_GenMultiRecordset($QueryList);
//header("Content-Type: text/html; charset=gbk"); //这里应根据实际运行环境调整，如：utf-8等
//echo $City . "\n";
//echo $CustomerQuerySQL . "\r\n";
//echo $SupplierQuerySQL . "\r\n";
XML_GenMultiRecordset($QueryList);
?>
 