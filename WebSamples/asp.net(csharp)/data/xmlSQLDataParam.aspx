﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        //从客户端发送的数据包中获取报表查询参数，URL有长度限制，当要传递的参数数据量比较大时，应该采用这样的方式
        //这里演示了用这样的方式传递一个超长查询SQL语句。
        byte[] FormData = Request.BinaryRead(Request.TotalBytes);
        UTF8Encoding Unicode = new UTF8Encoding();
        int charCount = Unicode.GetCharCount(FormData, 0, Request.TotalBytes);
        char[] chars = new Char[charCount];
        int charsDecodedCount = Unicode.GetChars(FormData, 0, Request.TotalBytes, chars, 0);
        String QuerySQL = new String(chars);

        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 