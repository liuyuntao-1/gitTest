<%@ Page Language="C#" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string ParameterQuerySQL = "select * from Employees where EmployeeID=5";
        
        //这里查询出来的数据将传递给报表中与字段同名的参数或部件框
        OledbXMLReportData.GenOneRecordset(this, ParameterQuerySQL);
    }
</script>