<? include '../data/mysql_GenXmlData.php'; ?>
<?php
//������ӳ�����Էֱ�����ʾMYSQL��MSSQL��ODBC�⼸�����ݷ��ʷ�ʽ��
//�������include�����ļ���Ϊmysql_GenXmlData�����ǲ���MYSQL����
//�������include�����ļ���Ϊmssql_GenXmlData�����ǲ���MSSQL����
//�������include�����ļ���Ϊodbc_GenXmlData�����ǲ���ODBC����

//�������������XML���ݣ�����������
/*
<report>
<_grparam>
<PayTo>�����������</PayTo>
<Date>2008-8-8</Date>
<Year>2008</Year>
<Month>8</Month>
<Day>8</Day>
<Amount>198188</Amount>
<Usage>����</Usage>
<Remark>���򱨱����</Remark>
</_grparam>
</report>
*/
/*
$ParameterQuerySQL = <<<ParameterQuerySQL
select c.CompanyName as Payto,
m.OrderDate as [Date],
Year(m.OrderDate) as [Year],
Month(m.OrderDate) as [Month],
Day(m.OrderDate) as [Day],
m.Freight+1000 as Amount,
m.ShipAddress as [Usage],
C.Address as Remark
from Orders m left join Customers c on c.CustomerID=m.CustomerID
where m.OrderID=10255
ParameterQuerySQL;
*/
$ParameterQuerySQL = <<<ParameterQuerySQL
select c.CompanyName as Payto,
m.Freight+1000 as Amount,
C.Address as Remark
from Orders m, Customers c
where c.CustomerID=m.CustomerID and m.OrderID=10255
ParameterQuerySQL;

GenParameterXmlData($ParameterQuerySQL, false);
?>
