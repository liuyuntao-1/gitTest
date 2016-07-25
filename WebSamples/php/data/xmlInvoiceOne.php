<? include 'mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$RecordsetQuerySQL = <<<QuerySQL
select d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount
from OrderDetails as d inner join Products p on P.ProductID=D.ProductID
where d.OrderID=10255
QuerySQL;

$ParameterQuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,ContactName as Remark
from Orders m left join Customers c on c.CustomerID=m.CustomerID
where m.OrderID=10255
QuerySQL;

//$ParameterPart = BuildParameterXmlText($ParameterQuerySQL);
//GenFullXmlData($RecordsetQuerySQL, $ParameterPart, false);
//XML_GenEntireData($RecordsetQuerySQL, $ParameterPart);
$QueryList = array (
    "master" => $ParameterQuerySQL,
    "detail" => $RecordsetQuerySQL
);
XML_GenMultiRecordset($QueryList);
?>
