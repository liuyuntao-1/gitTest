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
using LSVWGPT.Classes;
using System.Reflection;
using System.Text.RegularExpressions;
using LSLib.Classes;

#endregion

namespace LSVWGPT
{
    //主窗体
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            showStat();
            ClsFuncsA funcs = new ClsFuncsA(tpMain);
            //执行调用funcsTree的Prepare函数创建功能模块树
            funcsTree.Prepare(funcs);
        }

        //使用状态栏显示必要的软件信息
        private void showStat()
        {
            //将Session中的userRow转换为强类型的DSJckj.vusersRow对象。
            DataRow userRow = VWGContext.Current.Session["UserRow"] as DataRow;
            tssLblUser.Text = "用户：" + userRow["xm"].ToString();
            #region 显示版本和版权信息
            //当前系统的版本号
            Assembly a = Assembly.GetExecutingAssembly();//获取当前执行代码的程序集
            AssemblyName an = a.GetName();//获取次程序集的AssemblyName
            tssLblVer.Text = "版本：" + an.Version.ToString();
            //VWG的版本号
            //VWG版本用Gizmox.WebGUI.WGConst.Version获取，形如10.0.5 d - 2016.01.31 04:13 PM GMT+2
            //状态栏仅显示版本号与发行日期
            String s = Gizmox.WebGUI.WGConst.Version;//当前的Visual WebGui版本
            Regex r = new Regex(" [0-9]?[0-9]+:");//匹配" 04:"针对指定的正则表达式初始化Regex类的新实例
            Match m = r.Match(s);//单个正则表达式匹配的结果
            //从此实例检索子字符串，子字符串从指定的字符位置开始并具有指定的长度
            tssLblVWGVer.Text = "VWG:" + s.Substring(0, m.Index);
            //版权信息
            tssLblCopyRight.Text = a.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            #endregion
        }

        //编写lblTop单击事件程序，实现pnlTop显示和隐藏的切换
        private void lblTop_Click(object sender, EventArgs e)
        {
            //Visible：是否可见
            pnlTop.Visible = !pnlTop.Visible;
            lblTop.Text = pnlTop.Visible ? "∧" : "∨";
        }

        //编写lblLeft单击事件程序，实现pnlLeft及splitter1的显示和隐藏的切换
        private void lblLeft_Click(object sender, EventArgs e)
        {
            //Visible：是否可见
            pnlLeft.Visible = !pnlLeft.Visible;
            splitter1.Visible = pnlLeft.Visible;
            lblLeft.Text = pnlLeft.Visible ? "<" : ">";
        }

        //退出
        private void tsBtnLogout_Click(object sender, EventArgs e)
        {            
            ClsMsgBox.YesNo("确实要退出系统吗？", logout);
        }
        //传给对话框ClsMsgBox.YesNo一个函数logout，该函数称为回调函数
        //回调函数的参数与ClsMsgBox.YesNo的参数一致
        //sender参数的父类是Form，因此可以将它强制地转换为Form类型。
        private void logout(object sender, EventArgs e)
        {
            //枚举值
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //注销
                VWGContext.Current.Session.IsLoggedOn = false;
                VWGContext.Current.HttpContext.Session.Abandon();
            }
        }               
               

        //刷新
        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {
            string ids = funcsTree.trV.SelectedNode.Name;
            funcsTree.trV.Nodes.Clear();
            ClsFuncsA funcs = new ClsFuncsA(tpMain);
            funcsTree.Prepare(funcs);
            funcsTree.trV.ExpandAll();
            TreeNode[] tns = funcsTree.trV.Nodes.Find(ids, true);
            if (tns.Length > 0)
            {
                funcsTree.trV.SelectedNode = tns[0];
            }
            else
                funcsTree.trV.SelectedNode = funcsTree.trV.Nodes[0];
        }
    }
}