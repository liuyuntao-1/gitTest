<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = <<<QuerySQL
select d.Productid,p.ProductName,sum(d.Quantity) as Quantity, 
sum(d.UnitPrice*d.Quantity*(1-d.Discount)) as Amount 
from orders m inner join (OrderDetails d inner join Products p 
on d.ProductID=p.ProductID) 
on m.orderid=d.orderid 
where m.OrderDate between '1997-1-1' and '1997-12-31'
group by d.Productid,p.ProductName 
order by d.Productid
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
