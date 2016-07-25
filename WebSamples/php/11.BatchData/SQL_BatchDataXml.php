<? include '../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$WantRows = $_GET['WantRecords'];
$StartNo = $_GET['StartNo'];
$OrderID = $_GET['OrderID'];
if ($OrderID==0)
	$OrderID = 10247;

//说明：设置Http头"gr_batch_total"并不是必须的
//如果是第一次取数，在Http头中指定记录数，以便客户端在开始时就产生准确的分页信息
//if ($StartNo==0)
//{
//		$CountQuerySQL = <<<CountQuerySQL
//			string CountQuerySQL = "select count(*)
//			from (Orders m inner join (OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId)
//			left join Customers c on c.CustomerID=m.CustomerID
//		CountQuerySQL;    
//    $Total = BatchGetDataCount($CountQuerySQL);
//    header("gr_batch_total: ".strval($Total));
//	//echo $Total;
//}

//mysql 不支持top关键字，所以这里避免用
$QuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight,
d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount,
d.UnitPrice*d.Quantity as Amount,d.UnitPrice*d.Quantity*d.Discount as DiscountAmt,
d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount
from (Orders m inner join 
(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId)
left join Customers c on c.CustomerID=m.CustomerID
where m.OrderID>%s and m.OrderID<=%s
order by m.OrderID
QuerySQL;

$RealQuerySQL = sprintf($QuerySQL, $OrderID, $OrderID+$WantRows);
XML_GenOneRecordset($RealQuerySQL);
?>