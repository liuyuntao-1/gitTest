<? include '../../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select D.OrderID,D.ProductID,P.ProductName,D.UnitPrice,D.Quantity,
O.CustomerID,C.CompanyName,O.EmployeeID,E.LastName+E.FirstName as EmployeeName, 
D.Quantity*D.UnitPrice as Amount, 
O.OrderDate 
from OrderDetails D,Orders O,Products P,Employees E,Customers C 
where D.OrderID=O.OrderID and D.ProductID=P.ProductID and O.EmployeeID=E.EmployeeID and C.CustomerID=O.CustomerID 
and O.OrderDate between '1997-1-1' And '1997-1-31'
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?> 