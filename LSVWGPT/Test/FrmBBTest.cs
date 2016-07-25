#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using gregn6Lib;

#endregion

namespace LSVWGPT.Test
{
    public partial class FrmBBTest : Form
    {
        public FrmBBTest()
        {
            InitializeComponent();
        }

        //定义Grid++Report报表对象
        private GridppReport grbb = new GridppReport();

        private void FrmBBTest_Load(object sender, EventArgs e)
        {
            grbb.LoadFromFile(@"App_Data\GRBB\clbb2.grf");
            grbb.DetailGrid.Recordset.ConnectionString = @"
Provider=SQLOLEDB.1;Password=dlt2016;
Persist Security Info=True;User ID=sa;Initial Catalog=yjz;Data Source=HCDLX;
Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=HCDLX;
Use Encryption for Data=False;Tag with column collation when possible=False";
            grbb.DetailGrid.Recordset.QuerySQL = @"
SELECT [id],[cdid],[cltxztbm],[clzxbm],[txsj],[clzz1],[clzz2],[clzz3],[clzz4],[clzz5]
FROM [dbo].[tcl]
WHERE cdid <= 2
ORDER BY cdid, id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grbb.PrintPreview(true);
        }
    }
}