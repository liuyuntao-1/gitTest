<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = <<<QuerySQL
select c.City,m.CustomerId,c.CompanyName,d.ProductID,p.ProductName,
d.Quantity, d.UnitPrice*d.Quantity as Amount 
from (Orders m inner join 
(OrderDetails as d inner join Products p 
on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) 
left join Customers c on c.CustomerID=m.CustomerID 
where d.ProductID<8 
order by c.City,m.CustomerId, d.ProductID
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
