Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
'�����ṩ������������Ҫ�� XML �� JSON ���ݣ����� OleDb ��������
Public Class OledbReportData
    '���ر���ʾ�
    '����Grid++Report Access�������ݿ�����Ӵ���Ӧ���޸�Ϊ��ʵ��һ�£������װĿ¼����C:\Grid++Report 6��Ӧ�����޸ġ�
    Public Const OleDBConnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=C:\Grid++Report 6\Samples\Data\Northwind.mdb"

    '������SQL�б�ʾ����ֵ�İ�Χ���ţ�Access�á�#��, ��MS SQl Server�á�'����Ϊ���������߶����õĲ�ѯSQL��䣬��������������������������ֻ��Ϊ����ʾ���ӷ���
    Public Const DateSqlBracketChar As Char = "#"

    '���ݲ�ѯSQL�����ṩ������������Ҫ��XML���ݣ��ֶ�ֵΪ��Ҳ��������
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

    '��ȡ Count(*) SQL ��ѯ������������
    '���� QuerySQL ָ����ȡ�������ݵĲ�ѯSQL
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
    '���ݲ�ѯSQL,�����ṩ������������Ҫ�� XML �� JSON ����
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

    '�ر���ʾ�����º���Ϊ������ǰ�汾����������������֮��������ݿ��ǿ�ɾ��֮
    '<<����ǰ��汾�ĺ�����������ǰ�汾��д����
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
    '>>����ǰ��汾�ĺ�����������ǰ�汾��д����
End Class

'class  OledbXMLReportData ����SQL����������Ҫ�� XML ����
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

'class  OledbJsonReportData ����SQL����������Ҫ�� Json ����
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
