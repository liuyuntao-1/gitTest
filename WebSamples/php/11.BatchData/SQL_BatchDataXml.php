<? include '../data/mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$WantRows = $_GET['WantRecords'];
$StartNo = $_GET['StartNo'];
$OrderID = $_GET['OrderID'];
if ($OrderID==0)
	$OrderID = 10247;

//˵��������Httpͷ"gr_batch_total"�����Ǳ����
//����ǵ�һ��ȡ������Httpͷ��ָ����¼�����Ա�ͻ����ڿ�ʼʱ�Ͳ���׼ȷ�ķ�ҳ��Ϣ
//if ($StartNo==0)
//{
//		$CountQuerySQL = <<<CountQuerySQL
//			string CountQuerySQL = "select count(*)
//			from (Orders m inner join (OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId)
//			left join Customers c on c.CustomerID=m.CustomerID
//		CountQuerySQL;    
//    $Total = BatchGetDataCount($CountQuerySQL);
//    header("gr_batch_total: ".strval($Total));
//	//echo $Total;
//}

//mysql ��֧��top�ؼ��֣��������������
$QuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight,
d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount,
d.UnitPrice*d.Quantity as Amount,d.UnitPrice*d.Quantity*d.Discount as DiscountAmt,
d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount
from (Orders m inner join 
(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId)
left join Customers c on c.CustomerID=m.CustomerID
where m.OrderID>%s and m.OrderID<=%s
order by m.OrderID
QuerySQL;

$RealQuerySQL = sprintf($QuerySQL, $OrderID, $OrderID+$WantRows);
XML_GenOneRecordset($RealQuerySQL);
?>