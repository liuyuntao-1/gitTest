Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
'产生提供给报表生成需要的 XML 或 JSON 数据，采用 OleDb 数据引擎
Public Class OledbReportData
    '★特别提示★：
    '连接Grid++Report Access例子数据库的连接串，应该修改为与实际一致，如果安装目录不在C:\Grid++Report 6，应进行修改。
    Public Const OleDBConnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=C:\Grid++Report 6\Samples\Data\Northwind.mdb"

    '定义在SQL中表示日期值的包围符号，Access用“#”, 而MS SQl Server用“'”，为了生成两者都可用的查询SQL语句，将其参数化定义出来。这样处理只是为了演示例子方便
    Public Const DateSqlBracketChar As Char = "#"

    '根据查询SQL产生提供给报表生成需要的XML数据，字段值为空也产生数据
    Public Shared Sub FullGenNodeXmlData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, ByVal DataType As ResponseDataType)
        Dim myConn As New OleDbConnection(OleDBConnStr)
        Dim myCommand As New OleDbCommand(QuerySQL, myConn)
        myConn.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        XMLReportData.GenNodeXmlDataFromReader(DataPage, myReader, DataType)
        myReader.Close()
        myConn.Close()
    End Sub

    '获取 Count(*) SQL 查询到的数据行数
    '参数 QuerySQL 指定获取报表数据的查询SQL
    Public Shared Function BatchGetDataCount(ByRef QuerySQL As String) As Integer
        BatchGetDataCount = 0

        Dim myConn As New OleDbConnection(OleDBConnStr)
        Dim myCommand As New OleDbCommand(QuerySQL, myConn)
        myConn.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        If myReader.Read() Then
            BatchGetDataCount = myReader.GetInt32(0)
        End If
        myReader.Close()
        myConn.Close()
    End Function

    '<<Protected function
    '根据查询SQL,产生提供给报表生成需要的 XML 或 JSON 数据
    Protected Shared Sub DoGenDetailData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, ByVal DataType As ResponseDataType, ByVal IsJSON As Boolean)
        Dim myConn As New OleDbConnection(OleDBConnStr)
        Dim myda As New OleDbDataAdapter(QuerySQL, myConn)
        Dim myds As New DataSet()
        myConn.Open()
        myda.Fill(myds)
        myConn.Close()

        If IsJSON = True Then
            JSONReportData.GenDataSet(DataPage, myds, DataType)
        Else
            XMLReportData.GenDataSet(DataPage, myds, DataType)
        End If
    End Sub

    '特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    '<<保留前面版本的函数，兼容以前版本所写程序
    Public Shared Sub GenNodeXmlData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, ByVal DataType As ResponseDataType)
        DoGenDetailData(DataPage, QuerySQL, DataType, False)
    End Sub

    Public Shared Sub GenParameterReportData(ByRef DataPage As System.Web.UI.Page, ByRef ParameterQuerySQL As String)
        DoGenDetailData(DataPage, ParameterQuerySQL, ResponseDataType.PlainText, False)
    End Sub

    Public Shared Sub GenEntireReportData(ByRef DataPage As System.Web.UI.Page, ByRef RecordsetQuerySQL As String, ByRef ParameterQuerySQL As String, ByVal DataType As ResponseDataType)
        Dim myConn As New OleDbConnection(OleDBConnStr)
        Dim myda1 As New OleDbDataAdapter(RecordsetQuerySQL, myConn)
        Dim myda2 As New OleDbDataAdapter(ParameterQuerySQL, myConn)
        Dim myds As New DataSet()
        myConn.Open()
        myda1.Fill(myds)
        myda2.Fill(myds)
        myConn.Close()

        XMLReportData.GenDataSet(DataPage, myds, ReportDataBase.DefaultDataType)
    End Sub
    '>>保留前面版本的函数，兼容以前版本所写程序
End Class

'class  OledbXMLReportData 根据SQL产生报表需要的 XML 数据
Public Class OledbXMLReportData
    Inherits OledbReportData

    Public Shared Sub GenOneRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        OledbReportData.DoGenDetailData(DataPage, QuerySQL, DataType, False)
    End Sub

    Public Shared Sub GenMultiRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QueryList As ArrayList)
        Dim ReportConn As New OleDbConnection(OleDBConnStr)
        Dim ReportDataSet As New DataSet()

        ReportConn.Open()
        For Each item As ReportQueryItem In QueryList
            Dim DataAdapter As New OleDbDataAdapter(item.QuerySQL, ReportConn)
            DataAdapter.Fill(ReportDataSet, item.RecordsetName)
        Next
        ReportConn.Close()

        XMLReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType)
    End Sub


    '特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    '<<保留前面版本的函数，兼容以前版本所写程序
    '产生报表明细记录数据，数据将被加载到明细网格的记录集中
    Public Shared Sub GenDetailData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        GenOneRecordset(DataPage, QuerySQL)
    End Sub

    '这里只产生报表参数数据，数据加载到报表参数、非明细网格中的部件框中
    '当报表没有明细时，调用本方法生成数据，查询SQL应该只能查询出一条记录
    Public Shared Sub GenParameterData(ByRef DataPage As System.Web.UI.Page, ByRef ParameterQuerySQL As String)
        GenOneRecordset(DataPage, ParameterQuerySQL)
    End Sub

    '根据RecordsetQuerySQL获取报表明细数据，对应数据加载到报表的明细网格的记录集中
    '根据ParameterQuerySQL获取报表参数数据，对应数据加载到报表参数、非明细网格中的部件框中
    Public Shared Sub GenEntireData(ByRef DataPage As System.Web.UI.Page, ByRef RecordsetQuerySQL As String, ByRef ParameterQuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem(RecordsetQuerySQL, "Detail"))
        QueryList.Add(New ReportQueryItem(ParameterQuerySQL, "Master"))
        GenMultiRecordset(DataPage, QueryList)
    End Sub
    '>>保留前面版本的函数，兼容以前版本所写程序
End Class

'class  OledbJsonReportData 根据SQL产生报表需要的 Json 数据
Public Class OledbJsonReportData
    Inherits OledbReportData

    Public Shared Sub GenOneRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        OledbReportData.DoGenDetailData(DataPage, QuerySQL, DataType, True)
    End Sub

    Public Shared Sub GenMultiRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QueryList As ArrayList)
        Dim ReportConn As New OleDbConnection(OleDBConnStr)
        Dim ReportDataSet As New DataSet()

        ReportConn.Open()
        For Each item As ReportQueryItem In QueryList
            Dim DataAdapter As New OleDbDataAdapter(item.QuerySQL, ReportConn)
            DataAdapter.Fill(ReportDataSet, item.RecordsetName)
        Next
        ReportConn.Close()

        JSONReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType)
    End Sub

    '特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    '<<保留前面版本的函数，兼容以前版本所写程序
    '产生报表明细记录数据，数据将被加载到明细网格的记录集中
    Public Shared Sub GenDetailData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String)
        GenOneRecordset(DataPage, QuerySQL)
    End Sub

    '这里只产生报表参数数据，数据加载到报表参数、非明细网格中的部件框中
    '当报表没有明细时，调用本方法生成数据，查询SQL应该只能查询出一条记录
    Public Shared Sub GenParameterData(ByRef DataPage As System.Web.UI.Page, ByRef ParameterQuerySQL As String)
        GenOneRecordset(DataPage, ParameterQuerySQL)
    End Sub

    '根据RecordsetQuerySQL获取报表明细数据，对应数据加载到报表的明细网格的记录集中
    '根据ParameterQuerySQL获取报表参数数据，对应数据加载到报表参数、非明细网格中的部件框中
    Public Shared Sub GenEntireData(ByRef DataPage As System.Web.UI.Page, ByRef RecordsetQuerySQL As String, ByRef ParameterQuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem(RecordsetQuerySQL, "Detail"))
        QueryList.Add(New ReportQueryItem(ParameterQuerySQL, "Master"))
        GenMultiRecordset(DataPage, QueryList)
    End Sub
    '>>保留前面版本的函数，兼容以前版本所写程序
End Class
