<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����
$QuerySQL = "select * from Customers order by Region,City";
XML_GenOneRecordset($QuerySQL);
?>
