<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$RecordsetQuerySQL = <<<QuerySQL
select * from Employees where EmployeeID<8
QuerySQL;

$ParameterQuerySQL = <<<QuerySQL
select * from Employees where EmployeeID=8
QuerySQL;

//$ParameterPart = BuildParameterXmlText($ParameterQuerySQL);
//XML_GenEntireData($RecordsetQuerySQL, $ParameterPart);
$QueryList = array (
    "master" => $ParameterQuerySQL,
    "detail" => $RecordsetQuerySQL
);
XML_GenMultiRecordset($QueryList);
?>
