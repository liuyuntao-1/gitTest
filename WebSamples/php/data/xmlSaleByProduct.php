<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = <<<QuerySQL
select m.OrderID,m.OrderDate, 
d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount 
from Orders m inner join 
(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId 
where m.OrderDate between '1997-6-1' and '1997-12-31'
order by d.ProductID, m.OrderDate
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
