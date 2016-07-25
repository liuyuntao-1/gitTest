<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        OledbXMLReportData.GenOneRecordset(this, "select * from Products order by ProductName");
    }
</script>