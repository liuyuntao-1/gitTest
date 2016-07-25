using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LSVWGPT.GRBB
{
    public partial class YgBBData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cmd = @"
SELECT [id],[jgid],[jgmc],[xh],[xm],[xb],[xbs],[gw],[gwmc]
FROM [dbo].[vyg]
";
            string sWhere = Request.QueryString["where"];
            sWhere = HttpUtility.UrlDecode(sWhere);
            cmd += sWhere;
            //从数据库中查询出相应的数据，转为XML格式，并以网页的形式返回。
            SqlXMLReportData.GenOneRecordset(this, cmd);
        }
    }
}