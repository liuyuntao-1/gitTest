<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight,
d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount,
d.UnitPrice*d.Quantity as Amount, d.UnitPrice*d.Quantity*d.Discount as DiscountAmt,
d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount
from (Orders m inner join
(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId)
left join Customers c on c.CustomerID=m.CustomerID
where m.OrderID<=10300
order by m.OrderDate, m.OrderID
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?>
