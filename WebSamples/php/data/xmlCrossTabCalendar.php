<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = <<<QuerySQL
select m.OrderDate,sum(d.Quantity) as Qty,sum(d.UnitPrice*d.Quantity) as Amount 
from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) 
where m.OrderDate between '1997-1-1' and '1997-12-31'
group by m.OrderDate 
order by m.OrderDate
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
