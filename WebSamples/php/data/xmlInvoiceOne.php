<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$RecordsetQuerySQL = <<<QuerySQL
select d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount
from OrderDetails as d inner join Products p on P.ProductID=D.ProductID
where d.OrderID=10255
QuerySQL;

$ParameterQuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,ContactName as Remark
from Orders m left join Customers c on c.CustomerID=m.CustomerID
where m.OrderID=10255
QuerySQL;

//$ParameterPart = BuildParameterXmlText($ParameterQuerySQL);
//GenFullXmlData($RecordsetQuerySQL, $ParameterPart, false);
//XML_GenEntireData($RecordsetQuerySQL, $ParameterPart);
$QueryList = array (
    "master" => $ParameterQuerySQL,
    "detail" => $RecordsetQuerySQL
);
XML_GenMultiRecordset($QueryList);
?>
