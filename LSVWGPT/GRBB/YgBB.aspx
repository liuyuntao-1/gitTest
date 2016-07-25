<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YgBB.aspx.cs" Inherits="LSVWGPT.GRBB.YgBB" %>

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
    <style type="text/css">
        html,body {
          margin:0;
          height:100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    <script type="text/javascript">
        var Installed = Install_Detect();
        if (Installed) {
            var urlSearch = window.location.search;
            console.log("urlSearch", urlSearch);
            var dataPage = "YgBBData.aspx"+urlSearch;
            CreatePrintViewerEx("100%", "100%", "/GRBB/grf/ygbb2.grf",
                dataPage, true, "");
        }
    </script>
</body>
</html>
