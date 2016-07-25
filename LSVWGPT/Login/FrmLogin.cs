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
using Gizmox.WebGUI.Forms.Authentication;
using LSLib.Classes;
using LSVWGPT.Datasets.DSJckjTableAdapters;
using LSVWGPT.Datasets;

#endregion

namespace LSVWGPT.Login
{
    //��¼����
    public partial class FrmLogin : LogonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            readCookie();
        }

        //��ȡCookie�б�����û��˻��Ϳ�����ڹ��캯���е���
        private void readCookie()
        {
            //��ȡcookie�е�ֵ
            //Context.Cookies��VWGContext.Current.Cookies��ͬһ������
            string cookieAccount = Context.Cookies["Account"];
            string cookiePassword = Context.Cookies["Password"];
            //�ж�Cookies��ֵ�Ƿ���ֵ
            if (cookieAccount != "" && cookiePassword != "")
            {
                txtLoginName.Text = cookieAccount;
                txtPassword.Text = cookiePassword;
                chkAutoSave.Checked = true;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }      
                

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            #region �˻������Ϊ���ж�
            //Trim��������ȥ���ַ���ǰ��Ŀո�
            //string.IsNullOrEmpty���������ж�һ���ַ����Ƿ�Ϊ��ֵ��
            txtLoginName.Text = txtLoginName.Text.Trim();
            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                ClsMsgBox.Jg("�˻�����Ϊ�գ�");
                return;
            }
            txtPassword.Text = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ClsMsgBox.Jg("�����Ϊ�գ�");
                return;
            }
            #endregion

            //��ȡ�û���Ϣ
            //��̬����һ����ȡvusers��ͼ��Ϣ����������
            vusersTableAdapter uta = new vusersTableAdapter();
            //��GetDataByLoginName������ȡ��¼�û�����Ϣ��
            DSJckj.vusersDataTable u = uta.GetDataByLoginName(txtLoginName.Text);
            //��ȡ�û���Ϣ�У�����û���������ȡnull��
            DSJckj.vusersRow userRow = u.Rows.Count == 0 ? null : (DSJckj.vusersRow)u.Rows[0];

            #region  �˻���������Ч���ж�
            //������ж��û��Ƿ���ڡ�
            if (userRow == null)
            {
                ClsMsgBox.Jg("�˻������ڣ�");
                return;
            }
            //�жϿ���
            //�жϿ����Ƿ���ȷ��ע������Ǵ�Сд���еġ�
            if (string.Compare(txtPassword.Text, userRow.password, false) != 0)
            {
              ClsMsgBox.Jg("�����ȷ��");
                return;
            }

            //�жϻ״̬
            //�ж��û��Ƿ��ǻ�û�
            if (!userRow.active)
            {
                ClsMsgBox.Jg("���û�Ϊ�ǻ�û����������¼ϵͳ��");
                return;
            }
            #endregion

            #region �Ƿ񱣴浽cookie
            if (chkAutoSave.Checked)
            {
                Context.Cookies["Account"] = txtLoginName.Text;
                Context.Cookies["Password"] = txtPassword.Text;
            }
            else
            {
                Context.Cookies["Account"] = "";
                Context.Cookies["Password"] = "";
            }
            #endregion

            //����¼�û���Ϣ���浽Session
            VWGContext.Current.Session["userRow"] = userRow;
            //�����ʵ�ʵĴ���
            this.Context.Session.IsLoggedOn = true;
        }

        

        private void chkAutoSave_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}