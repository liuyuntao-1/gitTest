<? include 'mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据

//php或自动在某些字符(如 ' \ )前加反斜杠(\)进行转义，应该调用 stripslashes 进行还原
//echo $_GET['QuerySQL'];
//echo stripslashes($_GET['QuerySQL']);
XML_GenOneRecordset( stripslashes($_GET['QuerySQL']) );
?>
