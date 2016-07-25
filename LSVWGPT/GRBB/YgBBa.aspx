<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YgBBa.aspx.cs" Inherits="LSVWGPT.GRBB.YgBBa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="js/CreateControl.js" type="text/javascript"></script>
    <script src="js/GRInstall.js" type="text/javascript"></script>
    <script src="js/GRBB.js" type="text/javascript"></script>
    <script src="js/test.js" type="text/javascript"></script>
    <script type="text/javascript">
        Install_InsertReport();
    </script>
    <script type="text/javascript">
        function testLiteralObject() {
            person = { xing: "张", ming: "三" };
            person.dz = "济南";
            person["zy"] = "程序员";

            console.log("zy", person.zy, "xing", person.xing, "ming", person["ming"], "dz", person["dz"]);
            for (var prop in person) {
                console.log(prop, person[prop]);
            }
        }
    </script>
    <script type="text/javascript">
        function testSplit() {
            //window.location.search获取当前网址网页名后从“?”号开始的部分
            //substr(1)截取从第1个字符开始向后的子串，本例目的是去除“?”号
            //split(‘&’)将字符串以“&”符号为边界分解到数组中            
            var qvars = window.location.search.substr(1).split('&');
            //qvars.length获取数组的长度
            for (var i = 0; i < qvars.length; i++) {
                console.log(qvars[i]);
            }
        }
    </script>
    <script type="text/javascript">
        function getQVarObj() {
            var p, qVarObj = {};
            var qvars = window.location.search.substr(1).split('&');
            for (var i = 0; i < qvars.length; i++) {
                //将形如“name=value”形式的查询串“=”号前后的部分分解到两个元素的数组p中
                p = qvars[i].split('=');
                qVarObj[p[0]] = decodeURIComponent(p[1].replace(/\+/g, " "));
            }
            return qVarObj;
        }
    </script>
    <script type="text/javascript">
        function GetRequest() {

            var url = location.search; //获取url中"?"符后的字串
            var theRequest = new Object();
            if (url.indexOf("?") != -1) {
                var str = url.substr(1);
                strs = str.split("&");
                for (var i = 0; i < strs.length; i++) {
                    theRequest[strs[i].split("=")[0]] = decodeURIComponent(strs[i].split("=")[1]);
                }
            }
            return theRequest;
        }
    </script>
    <script type="text/javascript">
        function window_onload() {
            var report = ReportViewer.Report;

            ReportViewer.Stop();
            //获取getQVarObj()函数返回对象的xms成员的值。
            var xms = GetRequest().xms;
            //alert(xms);
            //var xma = new Array();
            var xma = xms.split(',');
            var i = 0;
            for (var i = 0; i < xma.length; i++) {
                //if (i >= 4) 语句保证只向报表中定义的参数变量传递数据
                if (i >= 4)
                    break;
                var xmi = "xm" + (i + 1);//构造名字参数变量名xm1~xm4
                console.log(xmi, xma[i]);
                //实现了向报表中的参数变量xmi传递数值xma[i]。
                report.ParameterByName(xmi).AsString = xma[i];
            }
            ReportViewer.Start();
        }
    </script>
    <style type="text/css">
        html, body {
            margin: 0;
            height: 100%;
        }
    </style>
</head>
<body onload="window_onload()">
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <script type="text/javascript">
        function showBB() {
            var Installed = Install_Detect();
            if (Installed) {
                var where = getQVarObj().where;//获取getQVarObj()函数返回对象的where成员的值。
                console.log("where", where);
                //实现了向CLBBData.aspx仅传递需要的where参数，且参数的值用用JavaScript函数encodeURIComponent转码为网址可以接受的串。
                var dataPage = "YgBBData.aspx?where=" + encodeURIComponent(where);
                CreatePrintViewerEx("100%", "100%", "/GRBB/grf/ygbb2.grf",
                    dataPage, true, "");
            }
        }
        showBB();
        testLiteralObject();
        testSplit();
        qVarObj = getQVarObj();
        for (var prop in qVarObj) {
            console.log(prop, qVarObj[prop]);
        }
    </script>

</body>
</html>
