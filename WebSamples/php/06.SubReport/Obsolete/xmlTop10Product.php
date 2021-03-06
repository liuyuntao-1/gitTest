<? include '../../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据

//由于MySQL不支持 TOP N SQL短语，所以这里用 and p.ProductID<=10 筛选出10笔数据，这样做的目的仅为了演示
$QuerySQL = <<<QuerySQL
select p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty 
from OrderDetails o, Products p 
where o.ProductID=p.ProductID and p.ProductID<=10
group by p.ProductID, p.ProductName 
order by sum(Quantity*o.UnitPrice) desc
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
 