<%@ Page Language="VB"%>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.SqlClient" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
	<head>
		<title>Web����(B/S����)��ʾ���� ��Ʊ������������ڷ������˵����ݿ���</title>
		<META HTTP-EQUIV="Content-Type" CONTENT="text/html; charset=gb2312">
		<script src="../../CreateControl.js" type="text/javascript"></script>
		<script src="../../GRUtility.js" type="text/javascript"></script>

		<script type="text/javascript">
// <!CDATA[
var FilterURL;

function window_onload() 
{
    var oOption;
    
    //�����ݿ���еĸ����������Ƽ��뵽����ѡ�����
    <%
    Dim myConn As New SqlConnection(SqlReportData.SqlConnStr)
	Dim ocmd As New SqlCommand("select ReportName from Report order by ReportName", myConn)
	myConn.Open()
	Dim dr as SqlDataReader = ocmd.ExecuteReader(CommandBehavior.CloseConnection)
        
	While (dr.Read())
	%>
        oOption = document.createElement("OPTION");
        oOption.text="<%=dr.GetString(0)%>";
        selOpenName.add(oOption);	
    <%
    End While 

	dr.Close()
    %>
    
    selOpenName_onchange()
}

//����ѡ��ı�����Ŀ�ӷ����������뱨��ģ��
function selOpenName_onchange() {
    var ReportName = selOpenName.all(selOpenName.selectedIndex).text;
    
    var LoadURL = "ReportLoadFromDB.aspx?Report=" + ReportName;
    var success = ReportDesigner.Report.LoadFromURL(LoadURL);
    
    if (success == true)
    {
        ReportDesigner.Reload();
        
        txtSaveName.value = ReportName;
    }
    else
    {
        alert("���뱨��ʧ��!");
    }
}

//����ǰ��Ƶı���ģ�屣�浽��������
function btnSave_onclick() {
    var ReportName = txtSaveName.value;
    if (ReportName == "")
    {
        alert("û��ָ����������ƣ����ܽ��б��棡");
        return;
    }

    ReportDesigner.Post();
    var SaveURL = "ReportSaveToDB.aspx?Report=" + ReportName;
    var success = ReportDesigner.Report.SaveToURL(SaveURL);
    
    if (success == true)
        alert("���汨��ɹ�!");
    else
        alert("���汨��ʧ��!");
}

//��ʾ���ļ��Ի���ѡ��һ���ļ����ӿͻ��˱����ļ������뱨��ģ��
function btnLoadLocalFile_onclick() {
     var fd = new ActiveXObject("MSComDlg.CommonDialog");
    fd.Filter = "Grid++Report(*.grf)|*.grf";
    //fd.Filter = "*.*";
    fd.FilterIndex = 2;
    // must setting
    fd.MaxFileSize = 128;
    fd.ShowOpen(); //fd.ShowSave();
    var FileName = fd.FileName;
    if (FileName != "")
    {
        var fso = new ActiveXObject("Scripting.FileSystemObject");
        FileName = fso.GetFileName(FileName);
        
        txtSaveName.value = FileName.substr(0, FileName.length-4);
      
        ReportDesigner.Report.LoadFromFile(FileName);
        ReportDesigner.Reload();
    }
}

// ]]>
        </script>

</head>
	<body style="margin:0" onload="return window_onload()">
        <table height="100%" width="100%" border="1">
            <tr>
                <td atomicselection="true" style="font-size: 11pt; height: 29px">
                    �������ϵı���:<select id="selOpenName" name="selOpenName" style="width: 118px" type="text/javascript" onchange="return selOpenName_onchange()">
                    </select>
                    �������ƣ�<input id="txtSaveName" style="width: 129px" type="text" />
                    <input id="btnSave" name="btnSave" type="button" value="���浽������" type="text/javascript" onclick="return btnSave_onclick()" />&nbsp;
                    <input id="btnLoadLocalFile" name="btnLoadLocalFile" onclick="return btnLoadLocalFile_onclick()" style="width: 135px"
                        type="button" value="���뱾���ļ�..." /><br />
                    <a href="ViewReport.htm" target="_blank">�ڲ������ʾ����</a>&nbsp; <a href="PrintDirect.htm" target="_blank">ֱ�Ӵ�ӡ����</a>
                </td>
            </tr>
            <tr height="100%">
                <td atomicselection="true">
                    <script type="text/javascript"> 
                        CreateDesigner("", "", "");
                    </script>
                </td>
            </tr>
        </table>
	</body>
</html>