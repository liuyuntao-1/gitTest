<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,c.ContactName+c.Phone as Remark,
d.OrderID,d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount 
from (Orders m inner join (OrderDetails d inner join Products p on p.ProductID=d.ProductID) 
on d.OrderID=m.OrderID) left join Customers c on c.CustomerID=m.CustomerID 
where m.OrderID>=10255 and m.OrderID<10260
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
