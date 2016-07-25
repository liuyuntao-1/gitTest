<!--#include file="DBConnString.asp"-->
<!--#include file="Base64Code.asp"-->
<%
//产生报表需要的XML节点类型数据，节点类型数据的数据量比属性类型数据的数据量要大
Function GenNodeXmlData(QuerySQL)
	Set oConn = Server.CreateObject("ADODB.Connection")
	oConn.Open ReportDBConnString
	Set oRs = oConn.Execute(QuerySQL) 

	Const adPersistXML = 1
	Dim objXMLDOM
	Set objXMLDOM = Server.CreateObject("MSXML2.DOMDocument.3.0")
	oRs.save objXMLDOM, adPersistXML

	Dim strCleanXML, objXMLDOM_XSLT
	Set objXMLDOM_XSLT = CreateObject("MSXML2.DOMDocument")
    //如果下面的目录与实际不符，请进行具体调整
	objXMLDOM_XSLT.load(Server.MapPath("/WebSamples/asp/data/DataCleanerNode.xsl"))
	strCleanXML = objXMLDOM.transformNode(objXMLDOM_XSLT)
	  
	Response.write strCleanXML

	Set objXMLDOM = Nothing
	Set objXMLDOM_XSLT = Nothing
End Function

//产生报表需要的XML节点类型数据，如果包含有二进制数据，将二进制数据编码为BASE64
Function GenNodeXmlDataForBin64(QuerySQL)
	Set oConn = Server.CreateObject("ADODB.Connection")
	oConn.Open ReportDBConnString
	Set oRs = oConn.Execute(QuerySQL) 

	'adBinary=128 adVarBinary=205 adLongVarBinary=204
	Dim strXML
	strXML = "<xml>"
	If Not oRs.BOF Or Not oRs.EOF Then
	    oRs.MoveFirst
	    Do While NOT oRs.EOF
		    strXML = strXML & "<row>"
		    For Each varItem In oRs.Fields
		        If IsEmpty(varItem.value)=False And IsNull(varItem.value)=False Then
			        If varItem.Type=128 or varItem.Type=204 or varItem.Type=205 Then
					    Dim Base64Text
					    Base64Text = strAnsi2Unicode(Base64encode(varItem.value)) 'Base64encode varItem.value
					    strXML = strXML & "<" & varItem.name & ">" & Base64Text & "</" & varItem.name & ">"
			        Else
				        strXML = strXML & "<" & varItem.name & ">" & Server.HTMLEncode(varItem.value) & "</" & varItem.name & ">"
		            End If  
		        End If  
		    Next
		    strXML = strXML & "</row>"
		    oRs.MoveNext
	    Loop
    End If  
	strXML = strXML & "</xml>"

	Set oRs = Nothing
	Set oConn = Nothing

	Response.Write strXML
End Function

//将根据 QuerySQL 查询出的数据打包为报表需要的参数数据包形式
Function GenParameterReportData(QuerySQL)
	Set oConn = Server.CreateObject("ADODB.Connection")
	oConn.Open ReportDBConnString
	Set oRs = oConn.Execute(QuerySQL) 

	Dim strXML
	strXML = "<xml>" & VbCrLf & "<_grparam>" & VbCrLf
	
	If Not oRs.BOF Or Not oRs.EOF Then
	    oRs.MoveFirst
	    For Each varItem In oRs.Fields
	        If IsEmpty(varItem.value)=False And IsNull(varItem.value)=False Then
		        If varItem.Type=128 or varItem.Type=204 or varItem.Type=205 Then
				    Dim Base64Text
				    Base64Text = strAnsi2Unicode(Base64encode(varItem.value)) 'Base64encode varItem.value
				    strXML = strXML & "<" & varItem.name & ">" & Base64Text & "</" & varItem.name & ">"
		        Else
		            strXML = strXML & "<" & varItem.name & ">" & Server.HTMLEncode(varItem.value) & "</" & varItem.name & ">"
	            End If  
                strXML = strXML & VbCrLf
            End If  
	    Next
    End If  
	
	strXML = strXML & "</_grparam>" & VbCrLf & "</xml>"

	Set oRs = Nothing
	Set oConn = Nothing

	Response.Write strXML
End Function

//根据查询SQL,产生提供给报表生成需要的XML数据，根据RecordsetQuerySQL获取报表明细数据，根据ParameterQuerySQL获取报表参数数据
Function GenEntireReportData(RecordsetQuerySQL, ParameterQuerySQL)
	Set oConn = Server.CreateObject("ADODB.Connection")
	oConn.Open ReportDBConnString

    //RecordsetQuerySQL
	Set oRs = oConn.Execute(RecordsetQuerySQL) 
	'adBinary=128 adVarBinary=205 adLongVarBinary=204
	Dim strXMLRecordset
	strXMLRecordset = "<xml>" & VbCrLf
	If Not oRs.BOF Or Not oRs.EOF Then
	    oRs.MoveFirst
	    Do While NOT oRs.EOF
		    strXMLRecordset = strXMLRecordset & "<row>"
		    For Each varItem In oRs.Fields
	            If IsEmpty(varItem.value)=False And IsNull(varItem.value)=False Then
			        If varItem.Type=128 or varItem.Type=204 or varItem.Type=205 Then
					    Dim Base64Text
					    Base64Text = strAnsi2Unicode(Base64encode(varItem.value)) 'Base64encode varItem.value
					    strXMLRecordset = strXMLRecordset & "<" & varItem.name & ">" & Base64Text & "</" & varItem.name & ">"
			        Else
				        strXMLRecordset = strXMLRecordset & "<" & varItem.name & ">" & Server.HTMLEncode(varItem.value) & "</" & varItem.name & ">"
		            End If  
		        End If
		    Next
		    strXMLRecordset = strXMLRecordset & "</row>" & VbCrLf
		    oRs.MoveNext
	    Loop
    End If
	strXMLRecordset = strXMLRecordset & "</xml>"
	Set oRs = Nothing

    //ParameterQuerySQL	
	Set oRsParam = oConn.Execute(ParameterQuerySQL) 
	Dim strXMLParam
	strXMLParam = "<_grparam>" & VbCrLf
	If Not oRsParam.BOF Or Not oRsParam.EOF Then
	    oRsParam.MoveFirst
	    For Each varItem In oRsParam.Fields
            If IsEmpty(varItem.value)=False And IsNull(varItem.value)=False Then
		        If varItem.Type=128 or varItem.Type=204 or varItem.Type=205 Then
				    Base64Text = strAnsi2Unicode(Base64encode(varItem.value)) 'Base64encode varItem.value
				    strXMLParam = strXMLParam & "<" & varItem.name & ">" & Base64Text & "</" & varItem.name & ">"
		        Else
			        strXMLParam = strXMLParam & "<" & varItem.name & ">" & Server.HTMLEncode(varItem.value) & "</" & varItem.name & ">"
	            End If  
	            strXMLParam = strXMLParam & VbCrLf
            End If  
	    Next
    End If  
	strXMLParam = strXMLParam & "</_grparam>"
	Set oRsParam = Nothing
	
	Set oConn = Nothing

	Dim strXML
	strXML = "<report>" & VbCrLf & strXMLRecordset & VbCrLf & strXMLParam & VbCrLf & "</report>"
	Response.Write strXML
End Function

Function BatchGetDataCount(QuerySQL)
    BatchGetDataCount = 0
    
	Set oConn = Server.CreateObject("ADODB.Connection")
	oConn.Open ReportDBConnString
	Set oRs = oConn.Execute(QuerySQL) 

	oRs.MoveFirst
	If NOT oRs.EOF Then
	    BatchGetDataCount = oRs.Fields(0).value
    End If  

	Set oRs = Nothing
	Set oConn = Nothing
End Function
%>