﻿<%
Dim FormData, FormSize
FormSize = Request.TotalBytes 
FormData = Request.BinaryRead(FormSize) 

dim PathFile
PathFile = server.MapPath("/") & "\WebSamples\asp\grf\" & Request.QueryString("Report")

'打开STREAM对象，写入上传数据，最后保存到文件
dim str
set str=server.CreateObject("ADODB.Stream") 'str为源数据流 
str.Mode=3 '设置打开模式，3为可读可写 
str.Type=1 '设置数据类型，1为二进制数据 
str.Open 
str.Write FormData
str.SaveToFile PathFile, 2 'adSaveCreateNotExist-1 adSaveCreateOverWrite-2  
str.Close
Set str=nothing
%>
 