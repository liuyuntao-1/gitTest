<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YgBBa.aspx.cs" Inherits="LSVWGPT.GRBB.YgBBb" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="js/CreateControl.js" type="text/javascript"></script>
    <script src="js/GRInstall.js" type="text/javascript"></script>
    <script type="text/javascript">
        Install_InsertReport();
    </script>
    <script src="js/GRBB.js" type="text/javascript"></script>
    <script type="text/javascript">
        function window_onload() {
            var report = ReportViewer.Report;
            ReportViewer.Stop();
            var xms = getQVarObj().xms;
            var xma = xms.split(',');
            var i = 0;
            for (var i=0; i<xma.length; i++) {
                if (i >= 4)
                    break;
                var xmi = "xm" + (i+1);
                report.ParameterByName(xmi).AsString = xma[i];
            }
            ReportViewer.Start();
        }
    </script>
    <style type="text/css">
        html,body {
          margin:0;
          height:100%;
        }
    </style>
</head>
<body onload ="window_onload()">
    <form id="form1" runat="server">
    <div>
    </div>
    </form>
    <script type="text/javascript">
        function showBB() {
            var Installed = Install_Detect();
            if (Installed) {
                var where = getQVarObj().where;
                var dataPage = "YgBBData.aspx?where=" + encodeURIComponent(where);
                CreatePrintViewerEx("100%", "100%", "/GRBB/grf/ygbb2.grf",
                    dataPage, true, "");
            }
        }
        showBB();
    </script>
</body>
</html>