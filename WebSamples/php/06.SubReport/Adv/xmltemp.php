<? include '../../data/mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$City = urldecode($_GET['City']);
//$CustomerQuerySQL = "select * from Customers where City='" . $_GET['City'] . "'";
//$SupplierQuerySQL = "select * from Suppliers where City='" . $_GET['City'] . "'";
$CustomerQuerySQL = "select * from Customers where City='" . $City . "'";
$SupplierQuerySQL = "select * from Suppliers where City='" . $City . "'";
//$CustomerQuerySQL = "select * from Customers where City='����'";
//$SupplierQuerySQL = "select * from Suppliers where City='����'";

$QueryList = array (
    "Customer" => $CustomerQuerySQL,
    "Supplier" => $SupplierQuerySQL
);
//XML_GenMultiRecordset($QueryList);
//header("Content-Type: text/html; charset=gbk"); //����Ӧ����ʵ�����л����������磺utf-8��
//echo $City . "\n";
//echo $CustomerQuerySQL . "\r\n";
//echo $SupplierQuerySQL . "\r\n";
XML_GenMultiRecordset($QueryList);
?>
 