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
    //�ۺ�ʵ�鴰��
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
            //ListBox�е�����Ϊ������Items�����еģ�ʹ�ü��ϵ�Add�����������һ�С� 
            lst.Items.Add(ClsQ.Q1(txtA.Text));
            lst.Items.Add(ClsQ.Q2(txtA.Text));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '('));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '['));
            lst.Items.Add(ClsQ.Q0(txtA.Text, '��'));
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
            //ʵ����dgv����ʾGetDataTable���ص����ݱ�
            dgv.DataSource = dt;
            //��TabControl�Ļҳ��ΪtpDgv
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
        //��btnTest_Click��ʵ�ָú����ĵ��á�
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
            string sWhere = "WHERE xbs = '��' ORDER BY xm";
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
            string sWhere = "WHERE xbs = '��' ORDER BY xm";
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
            string sWhere = "WHERE xbs = '��' ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string xms = getXMs();//���л�ȡtoptionxm����lbdmΪxl��ѡ���mc
            xms = HttpUtility.UrlEncode(xms);//���н�xmsת��Ϊ����Ϊ��ַ�Ĵ�
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere + "&xms=" + xms;
            Link.Open(bbURL, paras);
        }
        //����getXMs()ʵ�ֻ�ȡtoptionxm����lbdmΪxl��ѡ���mc
        private string getXMs()
        {
            string cmd = @"
SELECT mc FROM toptionxm
WHERE lbdm='xl'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            //dt.AsEnumerable()��dtת��ΪLINQ����Ŀ�ö������
            var a = from r in dt.AsEnumerable()
                    select r.Field<string>("mc");
            string[] xma = a.ToArray();//��aת��Ϊ������
            string xms = string.Join(",", xma);//���������еĸ��ַ����ö�������һ���ַ���
            return xms;
        }
        private void testYgBBcsa()
        {
            LinkParameters paras = new LinkParameters();
            //���´��ڴ���ҳ
            paras.Target = "_blank";
            //ȫ��ģʽ
            paras.FullScreen = false;
            //�ɵ�����С��
            paras.Resizable = true;
            //������
            paras.ScrollBars = true;
            //��ʾ���������ù��������Զ��幤����
            paras.ShowToolBar = true;
            //�Ƿ���ʾ�˵���
            paras.ShowMenuBar = true;
            //�Ƿ���ʾ������
            paras.ShowTitleBar = true;
            //�Ƿ���ʾ״̬��
            paras.ShowStatusBar = true;
            //���Ӵ���������������
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xbs = '��' ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string xms = getXMs();
            xms = HttpUtility.UrlEncode(xms);
            string bbURL = "/GRBB/YgBBa.aspx?where ="+sWhere + "&xms =" +xms;
            Link.Open(bbURL, paras);
        }
    }
}