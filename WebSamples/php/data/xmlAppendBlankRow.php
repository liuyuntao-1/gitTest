<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = <<<QuerySQL
select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity,
d.UnitPrice*d.Quantity as Amount 
from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) 
on m.orderid=d.orderid 
where (m.OrderDate between '1996-1-1' And '1997-9-30') and d.Productid<10 
order by d.ProductID
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
