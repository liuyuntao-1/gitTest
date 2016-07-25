<?php

//���³���ָ���������ݵĸ�ʽ����
define("const_PlainText", 1); //��������ΪXML��JSON�ı����ڵ���ʱ���Բ鿴�������ݡ�����δ��ѹ������������������ô��ַ�ʽ������
define("const_ZipBinary", 2); //��������ΪXML��JSON�ı�����ѹ���õ��Ķ��������ݡ����ַ�ʽ��������С(ԼΪԭʼ���ݵ�1/10)������Ajax��ʽ���ر�������ʱ����Ϊ���ַ�ʽ
define("const_ZipBase64", 3); //��������Ϊ�� ZipBinary ��ʽ�õ��������ٽ��� BASE64 ��������ݡ����ַ�ʽ�ʺ���Ajax��ʽ���ر�������

//ָ�������Ĭ���������ͣ�����ͳһ������������ϵͳ����������
//�ڱ��������Խ׶Σ�ͨ��ָ��Ϊ ResponseDataType.PlainText, �Ա���������в鿴��Ӧ��Դ�ļ�ʱ�ܿ����ɶ����ı�����
//����Ŀ����ʱ��ͨ��ָ��Ϊ ResponseDataType.ZipBinary �� ResponseDataType.ZipBase64���������Լ���������������ṩ������Ӧ�ٶ�
define("const_DefaultDataType", const_PlainText);

//���ı���ʽ(XML��JSON)�ı���������Ӧ����ҳ�����ݲ���ȷ���Ƿ�ѹ������
function ResponseReportData($XMLText, $DataType)
{
	if ($DataType == const_PlainText)
	{
        header("Content-Type: text/html; charset=utf-8"); //����Ӧ����ʵ�����л����������磺utf-8��gbk��
	    echo $XMLText;
	}
	else
	{
	    //д�����е�ѹ��ͷ����Ϣ���Ա㱨��ͻ��˲����ʶ������
        header("gr_zip_type: deflate");                                      //ָ��ѹ������
        header("gr_zip_size: ".strval(strlen($XMLText)));                    //ָ�����ݵ�ԭʼ����
        header("gr_zip_encode: ".iconv_get_encoding('internal_encoding'));   //ָ�����ݵı��뷽ʽ utf-8 utf-16 ...
    	
	    //ѹ�����ݲ����
        $compressed = gzdeflate($XMLText); 
	    if ($DataType == const_ZipBinary)
	        echo $compressed;
	    else
	        echo base64_encode($compressed);
	}
}

?>