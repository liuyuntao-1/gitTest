<? include 'mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����

//php���Զ���ĳЩ�ַ�(�� ' \ )ǰ�ӷ�б��(\)����ת�壬Ӧ�õ��� stripslashes ���л�ԭ
//echo $_GET['QuerySQL'];
//echo stripslashes($_GET['QuerySQL']);
XML_GenOneRecordset( stripslashes($_GET['QuerySQL']) );
?>
