<? include 'data/mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����

$ParameterQuerySQL = <<<ParameterQuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,
p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount 
from (Orders m inner join 
(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) 
left join Customers c on c.CustomerID=m.CustomerID 
where m.OrderID=10252 and d.ProductID=20 
order by m.OrderDate, m.OrderID
ParameterQuerySQL;

GenParameterXmlData($ParameterQuerySQL, false);
?>
