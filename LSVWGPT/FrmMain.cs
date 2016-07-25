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
    //������
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
            //ִ�е���funcsTree��Prepare������������ģ����
            funcsTree.Prepare(funcs);
        }

        //ʹ��״̬����ʾ��Ҫ�������Ϣ
        private void showStat()
        {
            //��Session�е�userRowת��Ϊǿ���͵�DSJckj.vusersRow����
            DataRow userRow = VWGContext.Current.Session["UserRow"] as DataRow;
            tssLblUser.Text = "�û���" + userRow["xm"].ToString();
            #region ��ʾ�汾�Ͱ�Ȩ��Ϣ
            //��ǰϵͳ�İ汾��
            Assembly a = Assembly.GetExecutingAssembly();//��ȡ��ǰִ�д���ĳ���
            AssemblyName an = a.GetName();//��ȡ�γ��򼯵�AssemblyName
            tssLblVer.Text = "�汾��" + an.Version.ToString();
            //VWG�İ汾��
            //VWG�汾��Gizmox.WebGUI.WGConst.Version��ȡ������10.0.5 d - 2016.01.31 04:13 PM GMT+2
            //״̬������ʾ�汾���뷢������
            String s = Gizmox.WebGUI.WGConst.Version;//��ǰ��Visual WebGui�汾
            Regex r = new Regex(" [0-9]?[0-9]+:");//ƥ��" 04:"���ָ����������ʽ��ʼ��Regex�����ʵ��
            Match m = r.Match(s);//����������ʽƥ��Ľ��
            //�Ӵ�ʵ���������ַ��������ַ�����ָ�����ַ�λ�ÿ�ʼ������ָ���ĳ���
            tssLblVWGVer.Text = "VWG:" + s.Substring(0, m.Index);
            //��Ȩ��Ϣ
            tssLblCopyRight.Text = a.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            #endregion
        }

        //��дlblTop�����¼�����ʵ��pnlTop��ʾ�����ص��л�
        private void lblTop_Click(object sender, EventArgs e)
        {
            //Visible���Ƿ�ɼ�
            pnlTop.Visible = !pnlTop.Visible;
            lblTop.Text = pnlTop.Visible ? "��" : "��";
        }

        //��дlblLeft�����¼�����ʵ��pnlLeft��splitter1����ʾ�����ص��л�
        private void lblLeft_Click(object sender, EventArgs e)
        {
            //Visible���Ƿ�ɼ�
            pnlLeft.Visible = !pnlLeft.Visible;
            splitter1.Visible = pnlLeft.Visible;
            lblLeft.Text = pnlLeft.Visible ? "<" : ">";
        }

        //�˳�
        private void tsBtnLogout_Click(object sender, EventArgs e)
        {            
            ClsMsgBox.YesNo("ȷʵҪ�˳�ϵͳ��", logout);
        }
        //�����Ի���ClsMsgBox.YesNoһ������logout���ú�����Ϊ�ص�����
        //�ص������Ĳ�����ClsMsgBox.YesNo�Ĳ���һ��
        //sender�����ĸ�����Form����˿��Խ���ǿ�Ƶ�ת��ΪForm���͡�
        private void logout(object sender, EventArgs e)
        {
            //ö��ֵ
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //ע��
                VWGContext.Current.Session.IsLoggedOn = false;
                VWGContext.Current.HttpContext.Session.Abandon();
            }
        }               
               

        //ˢ��
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