<%
'报表SQL Server演示数据库联结串，如果“Data Source”、“Initial Catalog”、“User ID”、“Password”等参数如与实际不符，请进行具体调整
sqlsvrConnString = "Provider=SQLOLEDB.1;Persist Security Info=True;Data Source=;Initial Catalog=gridreport;User ID=sa;Password=;"

'报表Access演示数据库联结串，如果“Data Source”参数与实际不符，请进行调整
mdbConnString = "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=C:\Grid++Report 5.0\Samples\Data\Northwind.mdb"

'如果要联结Access演示数据库，等号右边改为mdbConnString。如果要联结SQL Server演示数据库，等号右边改为sqlsvrConnString。
'改为mdbConnString后，有几个查询SQL中用到日期条件的报表不能正常运行，应该将日期值两端的单引号改为“#”符号
ReportDBConnString = sqlsvrConnString 'sqlsvrConnString mdbConnString

'如果例子不是复制在c:\Grid++Report 5.0\websamples\asp，“data\GenXmlData.asp”中与目录相关的一句代码要进行调整。如下：
'objXMLDOM_XSLT.load(Server.MapPath("/WebSamples/asp/data/DataCleanerNode.xsl"))
%>