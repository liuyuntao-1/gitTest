Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class SqlReportData
    '���ر���ʾ�
    '����SQL Server���ݿ�����Ӵ���Ӧ���޸�Ϊ��ʵ��һ�¡����������Grid++Report��������ӣ�Ӧ�����ȸ����������ݿ⵽SQL Server2000/2005���ݿ��ϡ�
    Public Const SqlConnStr As String = "Data Source=(local);Initial Catalog=gridreport;Persist Security Info=True;User ID=sa;Password=;"

    '������SQL�б�ʾ����ֵ�İ�Χ���ţ�Access�á�#��, ��MS SQl Server�á�'����Ϊ���������߶����õĲ�ѯSQL��䣬��������������������������ֻ��Ϊ����ʾ���ӷ���
    Public Const DateSqlBracketChar As Char = "'"

    '���ݲ�ѯSQL�����ṩ������������Ҫ��XML���ݣ��ֶ�ֵΪ��Ҳ��������
    Public Shared Sub FullGenNodeXmlData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, ByVal DataType As ResponseDataType)
        Dim myConn As New SqlConnection(SqlConnStr)
        Dim myCommand As New SqlCommand(QuerySQL, myConn)
        myConn.Open()
        Dim myReader As SqlDataReader
        myReader = myCommand.ExecuteReader()
        XMLReportData.GenNodeXmlDataFromReader(DataPage, myReader, DataType)
        myReader.Close()
        myConn.Close()
    End Sub

    '��ȡ Count(*) SQL ��ѯ������������
    '���� QuerySQL ָ����ȡ�������ݵĲ�ѯSQL
    Public Shared Function BatchGetDataCount(ByRef QuerySQL As String) As Integer
        BatchGetDataCount = 0

        Dim myConn As New SqlConnection(SqlConnStr)
        Dim myCommand As New SqlCommand(QuerySQL, myConn)
        myConn.Open()
        Dim myReader As SqlDataReader
        myReader = myCommand.ExecuteReader()
        If myReader.Read() Then
            BatchGetDataCount = myReader.GetInt32(0)
        End If
        myReader.Close()
        myConn.Close()
    End Function

    '<<Protected function
    '���ݲ�ѯSQL,�����ṩ������������Ҫ�� XML �� JSON ����
    Protected Shared Sub DoGenDetailData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, ByVal DataType As ResponseDataType, ByVal IsJSON As Boolean)
        Dim myConn As New SqlConnection(SqlConnStr)
        Dim myda As New SqlDataAdapter(QuerySQL, myConn)
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

    '�ر���ʾ�����º���Ϊ������ǰ�汾����������������֮��������ݿ��ǿ�ɾ��֮
    '<<����ǰ��汾�ĺ�����������ǰ�汾��д����
    Public Shared Sub GenNodeXmlData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, ByVal DataType As ResponseDataType)
        DoGenDetailData(DataPage, QuerySQL, DataType, False)
    End Sub

    Public Shared Sub GenParameterReportData(ByRef DataPage As System.Web.UI.Page, ByRef ParameterQuerySQL As String)
        DoGenDetailData(DataPage, ParameterQuerySQL, ResponseDataType.PlainText, False)
    End Sub

    Public Shared Sub GenEntireReportData(ByRef DataPage As System.Web.UI.Page, ByRef RecordsetQuerySQL As String, ByRef ParameterQuerySQL As String, ByVal DataType As ResponseDataType)
        Dim myConn As New SqlConnection(SqlConnStr)
        Dim myda1 As New SqlDataAdapter(RecordsetQuerySQL, myConn)
        Dim myda2 As New SqlDataAdapter(ParameterQuerySQL, myConn)
        Dim myds As New DataSet()
        myConn.Open()
        myda1.Fill(myds)
        myda2.Fill(myds)
        myConn.Close()

        XMLReportData.GenDataSet(DataPage, myds, ReportDataBase.DefaultDataType)
    End Sub
    '>>����ǰ��汾�ĺ�����������ǰ�汾��д����
End Class

'class  SqlXMLReportData ����SQL����������Ҫ�� XML ����
Public Class SqlXMLReportData
    Inherits SqlReportData

    Public Shared Sub GenOneRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        SqlReportData.DoGenDetailData(DataPage, QuerySQL, DataType, False)
    End Sub

    Public Shared Sub GenMultiRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QueryList As ArrayList)
        Dim ReportConn As New SqlConnection(SqlConnStr)
        Dim ReportDataSet As New DataSet()

        ReportConn.Open()
        For Each item As ReportQueryItem In QueryList
            Dim DataAdapter As New SqlDataAdapter(item.QuerySQL, ReportConn)
            DataAdapter.Fill(ReportDataSet, item.RecordsetName)
        Next
        ReportConn.Close()

        XMLReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType)
    End Sub


    '�ر���ʾ�����º���Ϊ������ǰ�汾����������������֮��������ݿ��ǿ�ɾ��֮
    '<<����ǰ��汾�ĺ�����������ǰ�汾��д����
    '����������ϸ��¼���ݣ����ݽ������ص���ϸ����ļ�¼����
    Public Shared Sub GenDetailData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        GenOneRecordset(DataPage, QuerySQL)
    End Sub

    '����ֻ��������������ݣ����ݼ��ص��������������ϸ�����еĲ�������
    '������û����ϸʱ�����ñ������������ݣ���ѯSQLӦ��ֻ�ܲ�ѯ��һ����¼
    Public Shared Sub GenParameterData(ByRef DataPage As System.Web.UI.Page, ByRef ParameterQuerySQL As String)
        GenOneRecordset(DataPage, ParameterQuerySQL)
    End Sub

    '����RecordsetQuerySQL��ȡ������ϸ���ݣ���Ӧ���ݼ��ص��������ϸ����ļ�¼����
    '����ParameterQuerySQL��ȡ����������ݣ���Ӧ���ݼ��ص��������������ϸ�����еĲ�������
    Public Shared Sub GenEntireData(ByRef DataPage As System.Web.UI.Page, ByRef RecordsetQuerySQL As String, ByRef ParameterQuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem(RecordsetQuerySQL, "Detail"))
        QueryList.Add(New ReportQueryItem(ParameterQuerySQL, "Master"))
        GenMultiRecordset(DataPage, QueryList)
    End Sub
    '>>����ǰ��汾�ĺ�����������ǰ�汾��д����
End Class

'class  SqlJsonReportData ����SQL����������Ҫ�� Json ����
Public Class SqlJsonReportData
    Inherits SqlReportData

    Public Shared Sub GenOneRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        SqlReportData.DoGenDetailData(DataPage, QuerySQL, DataType, True)
    End Sub

    Public Shared Sub GenMultiRecordset(ByRef DataPage As System.Web.UI.Page, ByRef QueryList As ArrayList)
        Dim ReportConn As New SqlConnection(SqlConnStr)
        Dim ReportDataSet As New DataSet()

        ReportConn.Open()
        For Each item As ReportQueryItem In QueryList
            Dim DataAdapter As New SqlDataAdapter(item.QuerySQL, ReportConn)
            DataAdapter.Fill(ReportDataSet, item.RecordsetName)
        Next
        ReportConn.Close()

        JSONReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType)
    End Sub

    '�ر���ʾ�����º���Ϊ������ǰ�汾����������������֮��������ݿ��ǿ�ɾ��֮
    '<<����ǰ��汾�ĺ�����������ǰ�汾��д����
    '����������ϸ��¼���ݣ����ݽ������ص���ϸ����ļ�¼����
    Public Shared Sub GenDetailData(ByRef DataPage As System.Web.UI.Page, ByRef QuerySQL As String)
        GenOneRecordset(DataPage, QuerySQL)
    End Sub

    '����ֻ��������������ݣ����ݼ��ص��������������ϸ�����еĲ�������
    '������û����ϸʱ�����ñ������������ݣ���ѯSQLӦ��ֻ�ܲ�ѯ��һ����¼
    Public Shared Sub GenParameterData(ByRef DataPage As System.Web.UI.Page, ByRef ParameterQuerySQL As String)
        GenOneRecordset(DataPage, ParameterQuerySQL)
    End Sub

    '����RecordsetQuerySQL��ȡ������ϸ���ݣ���Ӧ���ݼ��ص��������ϸ����ļ�¼����
    '����ParameterQuerySQL��ȡ����������ݣ���Ӧ���ݼ��ص��������������ϸ�����еĲ�������
    Public Shared Sub GenEntireData(ByRef DataPage As System.Web.UI.Page, ByRef RecordsetQuerySQL As String, ByRef ParameterQuerySQL As String, Optional ByVal DataType As ResponseDataType = ReportDataBase.DefaultDataType)
        Dim QueryList As ArrayList = New ArrayList()
        QueryList.Add(New ReportQueryItem(RecordsetQuerySQL, "Detail"))
        QueryList.Add(New ReportQueryItem(ParameterQuerySQL, "Master"))
        GenMultiRecordset(DataPage, QueryList)
    End Sub
    '>>����ǰ��汾�ĺ�����������ǰ�汾��д����
End Class
