﻿<%
dim PathFile
'这里需要根据实际情况进行调整
'PathFile = server.MapPath("/") & "\webreport\asp\grf\" & Request.QueryString("Report")
PathFile = "C:\Grid++Report 5.0\WebSamples\asp\grf\" & Request.QueryString("Report")

' clear the buffer
Response.Buffer = True
Response.Clear

dim str
set str=server.CreateObject("ADODB.Stream") 'str为源数据流 
'str.Mode=3 '设置打开模式，3为可读可写 
str.Type=1 '设置数据类型，1为二进制数据 
str.Open 

'Response.Write(PathFile)

str.LoadFromFile(PathFile)
if err then
  Response.Write("<h1>Error: </h1>" & err.Description & "<p>")
  Response.End
end if

' output the file to the browser
Response.BinaryWrite str.Read
Response.Flush

' tidy up
str.Close
Set str = Nothing
%> 

 