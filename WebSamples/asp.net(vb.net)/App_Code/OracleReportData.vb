Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OracleClient
Imports System.Configuration
Imports System.IO
Imports System.IO.Compression

'产生提供给报表生成需要的 XML 或 JSON 数据，采用 Oracle 数据引擎
Public Class OracleReportData
    '特别提示：数据库连接串，一定要改为实际的参数值
    Public Const OracleConnStr As String = "Data Source=dbserver1;Persist Security Info=True;User ID=hr;Password=hr;Unicode=True;"

    '根据查询SQL产生提供给报表生成需要的XML数据，字段值为空也产生数据
    Public Shared Sub FullGenNodeXmlData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, ByVal DataType As ResponseDataType)
        Dim myConn As New OracleConnection(OracleConnStr)
        Dim myCommand As New OracleCommand(QuerySQL, myConn)
        myConn.Open()
        Dim myReader As OracleDataReader
        myReader = myCommand.ExecuteReader()
        XMLReportData.GenNodeXmlDataFromReader(DataPage, myReader, DataType)
        myReader.Close()
        myConn.Close()
    End Sub

    '获取 Count(*) SQL 查询到的数据行数
    '参数 QuerySQL 指定获取报表数据的查询SQL
    Public Shared Function BatchGetDataCount(ByRef QuerySQL As String) As Integer
        BatchGetDataCount = 0

        Dim myConn As New OracleConnection(OracleConnStr)
        Dim myCommand As New OracleCommand(QuerySQL, myConn)
        myConn.Open()
        Dim myReader As OracleDataReader
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
        Dim myConn As New OracleConnection(OracleConnStr)
        Dim myda As New OracleDataAdapter(QuerySQL, myConn)
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
        Dim myConn As New OracleConnection(OracleConnStr)
        Dim myda1 As New OracleDataAdapter(RecordsetQuerySQL, myConn)
        Dim myda2 As New OracleDataAdapter(ParameterQuerySQL, myConn)
        Dim myds As New DataSet()
        myConn.Open()
        myda1.Fill(myds)
        myda2.Fill(myds)
        myConn.Close()

        XMLReportData.GenDataSet(DataPage, myds, ReportDataBase.DefaultDataType)
    End Sub
    '>>保留前面版本的函数，兼容以前版本所写程序
End Class

'class  OracleXMLReportData 根据SQL产生报表需要的 XML 数据
Public Class OracleXMLReportData
    Inherits OracleReportData

    Public Shared Sub GenOneRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        OracleReportData.DoGenDetailData(DataPage, QuerySQL, DataType, False)
    End Sub

    Public Shared Sub GenMultiRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QueryList As ArrayList)
        Dim ReportConn As New OracleConnection(OracleConnStr)
        Dim ReportDataSet As New DataSet()

        ReportConn.Open()
        For Each item As ReportQueryItem In QueryList
            Dim DataAdapter As New OracleDataAdapter(item.QuerySQL, ReportConn)
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

'class  OracleJsonReportData 根据SQL产生报表需要的 Json 数据
Public Class OracleJsonReportData
    Inherits OracleReportData

    Public Shared Sub GenOneRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        OracleReportData.DoGenDetailData(DataPage, QuerySQL, DataType, True)
    End Sub

    Public Shared Sub GenMultiRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QueryList As ArrayList)
        Dim ReportConn As New OracleConnection(OracleConnStr)
        Dim ReportDataSet As New DataSet()

        ReportConn.Open()
        For Each item As ReportQueryItem In QueryList
            Dim DataAdapter As New OracleDataAdapter(item.QuerySQL, ReportConn)
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
