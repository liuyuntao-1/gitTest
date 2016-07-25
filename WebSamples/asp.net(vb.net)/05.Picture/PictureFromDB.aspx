<%@ Page Language="VB" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>
<%@ import Namespace="System.Data.OledbClient" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        '第三个参数为false，表示不压缩数据，在实际项目中应改为true，对数据进行压缩。这里设为false主要是为了
        '测试报表数据网页运行的正确性，以便查看浏览响应的原文件时能看到xml形式的文本数据。
        Const OleDBConnStr As String = "Provider=SQLOLEDB.1;Persist Security Info=True;Data Source=;Initial Catalog=gridreport;User ID=sa;Password=;"
        Const QuerySQL As String = "select Picture From Categories where CategoryID=1"
        
        Dim myConn as new OleDbConnection(OleDBConnStr)
        Dim ocmd as new OleDbCommand(QuerySQL, myConn)
        myConn.Open()
        Dim odr as OleDbDataReader
        odr = ocmd.ExecuteReader(CommandBehavior.CloseConnection)

        odr.Read()
        Dim DataSize as Long = odr.GetBytes(0, 0, Nothing, 0, 0)
        Dim buffer(DataSize) as Byte
        odr.GetBytes(0, 0, buffer, 0, DataSize)
        Response.BinaryWrite(buffer)
        
        odr.Close()
    End Sub
</script>