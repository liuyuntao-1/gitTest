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
using LSLib.Classes;
using System.Web;

#endregion

namespace LSVWGPT
{
    //综合实验窗体
    public partial class FrmPractice : Form
    {
        public FrmPractice()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //testQ();
            //testDBCon();
            //testMsgBox();
            //testGetDataTable();
            //testGetDataTableException();
            testExits1();
            //testExits2();
            //testYgBB1();
            //testYgBB1a();
            //testYgBB1b();
            //testYgBB1c();
            //testYgBB1d();
            //testYgBBcs();
            //testYgBBcsa();
        }
        public void testQ()
        {
            //ListBox中的内容为包含在Items集合中的，使用集合的Add方法可以添加一行。 
            lst.Items.Add(ClsQ.Q1(txtA.Text));
            lst.Items.Add(ClsQ.Q2(txtA.Text));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '('));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '['));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '‘'));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '"'));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
        }
        private void testDBCon()
        {
            lst.Items.Add(ClsCBCon.ConStrKj);
        }
        private void testMsgBox()
        {
            ClsMsgBox.Ts(txtA.Text);
            ClsMsgBox.Jg(txtA.Text);
            ClsMsgBox.Cw(txtA.Text);
        }
        private void testGetDataTable()
        {
            string cmd = " select loginname,password,ygid from tlogin ";
            DataTable dt = ClsMSSQL.GetDataTable(cmd,ClsCBCon.ConStrKj);
            //实现在dgv中显示GetDataTable返回的数据表。
            dgv.DataSource = dt;
            //将TabControl的活动页置为tpDgv
            tcA.SelectedTab = tpDgv;
        }
        private void testGetDataTableException()
        {
            string cmd = "SELECT * FROM tlogina";
            try
            {
                DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
                dgv.DataSource = dt;
                tcA.SelectedTab = tpDgv;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw(ex.Message);
            }
        }
        private void testExits1()
        {
            bool b;
            string cmd = string.Format("SELECT * FROM tlogin WHERE loginname LIKE '%{0}%'", txtA.Text);
            b = ClsMSSQL.Exists(cmd, ClsCBCon.ConStrKj);
            lst.Items.Add(b);
        }

        private void testExits2()
        {
            bool b;
            b = ClsMSSQL.Exists("tlogin", "loginname", txtA.Text, ClsCBCon.ConStrKj);
            lst.Items.Add(b);
        }
        //在btnTest_Click中实现该函数的调用。
        private void testYgBB1()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            Link.Open("/GRBB/YgBBData.aspx", paras);
        }
        private void testYgBB1a()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            Link.Open("/GRBB/YgBB.aspx");
        }
        private void testYgBB1b()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xb = 1 ORDER BY xm";
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere;
            Link.Open(bbURL);
        }
        private void testYgBB1c()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xbs = '男' ORDER BY xm";
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere;
            Link.Open(bbURL);
        }
        private void testYgBB1d()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xbs = '男' ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere;
            Link.Open(bbURL);
        }
        private void testYgBBcs()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xbs = '男' ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string xms = getXMs();//该行获取toptionxm表中lbdm为xl的选项的mc
            xms = HttpUtility.UrlEncode(xms);//该行将xms转换为可作为网址的串
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere + "&xms=" + xms;
            Link.Open(bbURL, paras);
        }
        //函数getXMs()实现获取toptionxm表中lbdm为xl的选项的mc
        private string getXMs()
        {
            string cmd = @"
SELECT mc FROM toptionxm
WHERE lbdm='xl'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            //dt.AsEnumerable()将dt转换为LINQ所需的可枚举类型
            var a = from r in dt.AsEnumerable()
                    select r.Field<string>("mc");
            string[] xma = a.ToArray();//将a转换为串数组
            string xms = string.Join(",", xma);//将串数组中的各字符串用逗号连成一个字符串
            return xms;
        }
        private void testYgBBcsa()
        {
            LinkParameters paras = new LinkParameters();
            //在新窗口打开网页
            paras.Target = "_blank";
            //全屏模式
            paras.FullScreen = false;
            //可调整大小的
            paras.Resizable = true;
            //滚动条
            paras.ScrollBars = true;
            //显示或隐藏内置工具栏或自定义工具栏
            paras.ShowToolBar = true;
            //是否显示菜单条
            paras.ShowMenuBar = true;
            //是否显示标题栏
            paras.ShowTitleBar = true;
            //是否显示状态栏
            paras.ShowStatusBar = true;
            //链接窗体类型是正常的
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xbs = '男' ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string xms = getXMs();
            xms = HttpUtility.UrlEncode(xms);
            string bbURL = "/GRBB/YgBBa.aspx?where ="+sWhere + "&xms =" +xms;
            Link.Open(bbURL, paras);
        }
    }
}