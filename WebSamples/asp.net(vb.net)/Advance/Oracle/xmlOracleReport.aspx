<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        '第三个参数为false，表示不压缩数据，在实际项目中应改为true，对数据进行压缩。这里设为false主要是为了
        '测试报表数据网页运行的正确性，以便查看浏览响应的原文件时能看到xml形式的文本数据。
        OracleReportData.FullGenNodeXmlData(Me, "select * from EMPLOYEES", false)
    End Sub
</script>