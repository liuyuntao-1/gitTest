<?php
$filename = dirname($_SERVER['SCRIPT_FILENAME']) . "\\" . $_GET['report'];

if ( !$handle = fopen($filename, 'r') ) 
{
    print "不能打开文件 $filename，可能是文件不存在或WEB服务用户不具有相关权限";
    exit;
}

$contents = fread($handle, filesize($filename));
fclose($handle);

echo $contents;
?>
 