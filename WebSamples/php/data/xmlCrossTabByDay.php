<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = <<<QuerySQL
select c.CompanyName,m.OrderDate,d.UnitPrice*d.Quantity as Amount 
from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) 
left join Customers c on c.CustomerID=m.CustomerID 
where m.OrderDate between '1997-7-1' and '1997-7-10' 
order by c.CompanyName, m.OrderDate
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
