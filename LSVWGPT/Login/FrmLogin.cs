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
    //登录窗体
    public partial class FrmLogin : LogonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            readCookie();
        }

        //读取Cookie中保存的用户账户和口令，并在构造函数中调用
        private void readCookie()
        {
            //读取cookie中的值
            //Context.Cookies与VWGContext.Current.Cookies是同一个东西
            string cookieAccount = Context.Cookies["Account"];
            string cookiePassword = Context.Cookies["Password"];
            //判断Cookies的值是否有值
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
            #region 账户或口令为空判断
            //Trim函数可以去除字符串前后的空格。
            //string.IsNullOrEmpty函数可以判断一个字符串是否为空值。
            txtLoginName.Text = txtLoginName.Text.Trim();
            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                ClsMsgBox.Jg("账户不能为空！");
                return;
            }
            txtPassword.Text = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ClsMsgBox.Jg("口令不能为空！");
                return;
            }
            #endregion

            //获取用户信息
            //动态创建一个存取vusers视图信息的适配器。
            vusersTableAdapter uta = new vusersTableAdapter();
            //用GetDataByLoginName方法获取登录用户的信息。
            DSJckj.vusersDataTable u = uta.GetDataByLoginName(txtLoginName.Text);
            //获取用户信息行，如果用户不存在则取null。
            DSJckj.vusersRow userRow = u.Rows.Count == 0 ? null : (DSJckj.vusersRow)u.Rows[0];

            #region  账户、口令有效性判断
            //代码段判断用户是否存在。
            if (userRow == null)
            {
                ClsMsgBox.Jg("账户不存在！");
                return;
            }
            //判断口令
            //判断口令是否正确，注意口令是大小写敏感的。
            if (string.Compare(txtPassword.Text, userRow.password, false) != 0)
            {
              ClsMsgBox.Jg("口令不正确！");
                return;
            }

            //判断活动状态
            //判断用户是否是活动用户
            if (!userRow.active)
            {
                ClsMsgBox.Jg("此用户为非活动用户，不允许登录系统！");
                return;
            }
            #endregion

            #region 是否保存到cookie
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

            //将登录用户信息保存到Session
            VWGContext.Current.Session["userRow"] = userRow;
            //允许打开实际的窗体
            this.Context.Session.IsLoggedOn = true;
        }

        

        private void chkAutoSave_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}