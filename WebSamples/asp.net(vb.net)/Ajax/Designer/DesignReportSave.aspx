<%@ Page Language="VB" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.IO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim FormData As Byte() = Request.BinaryRead(Request.TotalBytes)

        '写入上传数据，最后保存到文件
        Dim strPathFile As String = Server.MapPath("") & "\" & Request.QueryString("Report")
        Dim bw As New BinaryWriter(File.Create(strPathFile))
        bw.Write(FormData)
        bw.Close()

    End Sub
</script>
