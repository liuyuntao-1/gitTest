<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
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
