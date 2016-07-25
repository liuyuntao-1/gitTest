<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        '将报表模板文件数据发送给请求者。供报表插件读取模板数据
        Dim strPathFile As String = Server.MapPath("") & "\..\grf\" & Request.QueryString("Report")
        Response.WriteFile(strPathFile)
    End Sub
</script>
