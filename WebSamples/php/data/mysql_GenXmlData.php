<? include 'BaseReportData.php'; ?>
<?php

/////////////////////////////////////////////////////////////////////////////////////////
//��������Ķ����¼���� XML ����
function XML_GenMultiRecordset($QueryList, $DataType=const_DefaultDataType)
{
	// connect to mysql server with a user and password
	mysql_connect("localhost", "root", "") or die("couldn't connect: ".mysql_error());
    mysql_select_db("gridreport");
    mysql_query("set names 'utf8'");
    
	$XMLText="<xml>\n";
    foreach ($QueryList as $RecordsetName => $QuerySQL) 
    {
        //echo "Key: $key; Value: $value<br>\n";
	    $result = mysql_query($QuerySQL);
    	
	    $fldTypes = array();
	    $numfields = mysql_num_fields($result);
	    for($i=0;$i<$numfields;$i++)
	    {
		    $fldType = mysql_field_type($result, $i);
		    if (stripos($fldType, "date") !== false)
		        $fldTypes[$i]=1;
		    else if ($fldType == "blob" || $fldType == "image")
		        $fldTypes[$i]=2;
		    else
		        $fldTypes[$i]=0;
	    }
    	
        while ($row = mysql_fetch_array($result))
	    {
		    $XMLText.="<".$RecordsetName.">"; //$XMLText.="<row>";
		    for($i=0;$i<$numfields;$i++)
		    {
			    if ($fldTypes[$i] == 2)
				    $XMLText.=("<".mysql_field_name($result, $i).">".base64_encode($row[$i])."</".mysql_field_name($result, $i).">");
			    else
				    $XMLText.=("<".mysql_field_name($result, $i).">".htmlspecialchars($row[$i], ENT_QUOTES)."</".mysql_field_name($result, $i).">");
		    }
		    $XMLText.="</".$RecordsetName.">\n"; //$XMLText.="</row>\n";
	    }
	    
	    mysql_free_result($result);
	}
	$XMLText.="</xml>\n";
	

	ResponseReportData($XMLText, $DataType);
}

//���������һ����¼���� XML ����
function XML_GenOneRecordset($QuerySQL, $DataType=const_DefaultDataType)
{
    $QueryList = array ("row" => $QuerySQL);
    XML_GenMultiRecordset($QueryList, $DataType);
}

function BatchGetDataCount($QuerySQL)
{
    // connect to mysql server with a user and password
    mysql_connect("localhost", "root", "") or die("couldn't connect: ".mysql_error());
    mysql_select_db("gridreport");
    mysql_query("set names 'utf8'");
   	
    $result = mysql_query($QuerySQL);
    
    $Total = 0;
    if ($row = mysql_fetch_array($result))
	{
		$Total = $row[0];
	}
    
    mysql_free_result($result);
    
    return $Total;
}

//�����ֶ����ͣ����ڵ����з����Ӷε���������
function ListFieldType($QuerySQL)
{
	header("Content-Type: text/plain");

	mysql_connect("localhost", "root", "") or die("couldn't connect: ".mysql_error());
    mysql_select_db("gridreport");
    mysql_query("set names 'utf8'");
	$result = mysql_query($QuerySQL);
	
	$XMLText="<xml>\n";
	
	$numfields = mysql_num_fields($result);
	for($i=0;$i<$numfields;$i++)
	{
		$XMLText.=(mysql_field_name($result, $i)."=".mysql_field_type($result, $i)."\n");
	}
	
	mysql_free_result($result);
	
	$XMLText.="</xml>\n";
    echo $XMLText;
}






/////////////////////////////////////////////////////////////////////////////////////////
//�ر���ʾ�����º���Ϊ������ǰ�汾����������������֮��������ݿ��ǿ�ɾ��֮
//<<����ǰ��汾�ĺ�����������ǰ�汾��д����

//����������Ҫ��XML�ڵ���������
function XML_GenDetailData($QuerySQL, $DataType=const_DefaultDataType)
{
	// connect to mysql server with a user and password
	mysql_connect("localhost", "root", "") or die("couldn't connect: ".mysql_error());
    mysql_select_db("gridreport");
    mysql_query("set names 'utf8'");
    
	$result = mysql_query($QuerySQL);
	$numfields = mysql_num_fields($result);
	
	$fldTypes = array();
	for($i=0;$i<$numfields;$i++)
	{
		$fldType = mysql_field_type($result, $i);
		if (stripos($fldType, "date") !== false)
		    $fldTypes[$i]=1;
		else if ($fldType == "blob" || $fldType == "image")
		    $fldTypes[$i]=2;
		else
		    $fldTypes[$i]=0;
	}
	
	$XMLText="<xml>\n";
    while ($row = mysql_fetch_array($result))
	{
		$XMLText.="<row>";
		for($i=0;$i<$numfields;$i++)
		{
			if ($fldTypes[$i] == 2)
				$XMLText.=("<".mysql_field_name($result, $i).">".base64_encode($row[$i])."</".mysql_field_name($result, $i).">");
			else
				$XMLText.=("<".mysql_field_name($result, $i).">".htmlspecialchars($row[$i], ENT_QUOTES)."</".mysql_field_name($result, $i).">");
		}
		$XMLText.="</row>\n";
	}
	$XMLText.="</xml>\n";
	
	mysql_free_result($result);
	
	ResponseReportData($XMLText, $DataType);
}

//����������Ҫ��XML�ڵ���������
//����RecordsetQuerySQL�����ṩ������������Ҫ��XML���ݣ���ͬʱ��ParameterQuerySQL��ȡ�ı����������һ����������ToCompressָ���Ƿ�ѹ������
function XML_GenEntireData($RecordsetQuerySQL, $ParameterPart, $DataType=const_DefaultDataType)
{
	// connect to mysql server with a user and password
	mysql_connect("localhost", "root", "") or die("couldn't connect: ".mysql_error());
    mysql_select_db("gridreport");
    mysql_query("set names 'utf8'");
	
	//<<RecordsetQuerySQL
	$result = mysql_query($RecordsetQuerySQL);
	$numfields = mysql_num_fields($result);
	
	$fldTypes = array();
	for($i=0;$i<$numfields;$i++)
	{
		$fldType = mysql_field_type($result, $i);
		if (stripos($fldType, "date") !== false)
		    $fldTypes[$i]=1;
		else if ($fldType == "blob" || $fldType == "image")
		    $fldTypes[$i]=2;
		else
		    $fldTypes[$i]=0;
	}
	
	$XMLText="<xml>\n";
    while ($row = mysql_fetch_array($result))
	{
		$XMLText.="<row>";
		for($i=0;$i<$numfields;$i++)
		{
			if ($fldTypes[$i] == 2)
				$XMLText.=("<".mysql_field_name($result, $i).">".base64_encode($row[$i])."</".mysql_field_name($result, $i).">");
			else
				$XMLText.=("<".mysql_field_name($result, $i).">".htmlspecialchars($row[$i], ENT_QUOTES)."</".mysql_field_name($result, $i).">");
		}
		$XMLText.="</row>\n";
	}
	$XMLText.="</xml>\n";
	
	mysql_free_result($result);
	//>>RecordsetQuerySQL
	
    $XMLText = "<report>\n" . $XMLText . $ParameterPart . "</report>"; 
	
	ResponseReportData($XMLText, $DataType);
}

//�������������Ҫ��XML�ڵ��������ݣ���������ϸ��¼���ݣ���ο������С�������(WEB����)->�������ݡ��е�˵��
function XML_GenParameterData($QuerySQL, $DataType=const_DefaultDataType)
{
	$XMLText="<xml>\n";
	$XMLText.=BuildParameterXmlText($QuerySQL);
	$XMLText.="</xml>\n";
	
	ResponseReportData($XMLText, $DataType);
}

//����ParameterQuerySQL��ȡ�ı����������һ����ΪXML����
function BuildParameterXmlText($ParameterQuerySQL)
{
    // connect to mysql server with a user and password
    mysql_connect("localhost", "root", "") or die("couldn't connect: ".mysql_error());
    mysql_select_db("gridreport");
    mysql_query("set names 'utf8'");
    	
    $result = mysql_query($ParameterQuerySQL);
    $numfields = mysql_num_fields($result);

	$fldTypes = array();
	for($i=0;$i<$numfields;$i++)
	{
		$fldType = mysql_field_type($result, $i);
		if (stripos($fldType, "date") !== false) //if ($fldType == "datetime")
		    $fldTypes[$i]=1;
		else if ($fldType == "blob" || $fldType == "image")
		    $fldTypes[$i]=2;
		else
		    $fldTypes[$i]=0;
	}
	
    $row = mysql_fetch_array($result);
    $ParameterPart = "<_grparam>\r\n";
    for($i=0;$i<$numfields;$i++)
    {
		if ($fldTypes[$i] == 2)
			$ParameterPart.=("<".mysql_field_name($result, $i).">".base64_encode($row[$i])."</".mysql_field_name($result, $i).">");
		else
			$ParameterPart.=("<".mysql_field_name($result, $i).">".htmlspecialchars($row[$i], ENT_QUOTES)."</".mysql_field_name($result, $i).">");
    }
    $ParameterPart .= "</_grparam>\r\n";

    mysql_free_result($result);
    
    return $ParameterPart;
}

function GenNodeXmlData($QuerySQL, $ToCompress)
{
    if ($ToCompress)
        $DataType = const_ZipBinary;
    else
        $DataType = const_PlainText;
    XML_GenDetailData($QuerySQL, $DataType);
}
function GenFullXmlData($RecordsetQuerySQL, $ParameterPart, $ToCompress)
{
    if ($ToCompress)
        $DataType = const_ZipBinary;
    else
        $DataType = const_PlainText;
    XML_GenEntireData($RecordsetQuerySQL, $ParameterPart, $DataType);
}
function GenParameterXmlData($QuerySQL, $ToCompress)
{
    if ($ToCompress)
        $DataType = const_ZipBinary;
    else
        $DataType = const_PlainText;
    XML_GenParameterData($QuerySQL, $DataType);
}
function GenNodeXmlDataForBin64($QuerySQL, $ToCompress)
{
    if ($ToCompress)
        $DataType = const_ZipBinary;
    else
        $DataType = const_PlainText;
    XML_GenDetailData(QuerySQL, $DataType);
}
//>>����ǰ��汾�ĺ�����������ǰ�汾��д����

?>