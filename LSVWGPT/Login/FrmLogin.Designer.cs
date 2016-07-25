using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.Login
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtLoginName = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.chkAutoSave = new Gizmox.WebGUI.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "口令";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.Location = new System.Drawing.Point(123, 63);
            this.txtLoginName.MaxLength = 12;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(100, 20);
            this.txtLoginName.TabIndex = 2;
            this.txtLoginName.TextChanged += new System.EventHandler(this.txtLoginName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(123, 115);
            this.txtPassword.MaxLength = 12;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(57, 201);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(170, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Location = new System.Drawing.Point(123, 166);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(74, 17);
            this.chkAutoSave.TabIndex = 6;
            this.chkAutoSave.Text = "自动保存";
            this.chkAutoSave.CheckedChanged += new System.EventHandler(this.chkAutoSave_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.chkAutoSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(419, 466);
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLoginName;
        private TextBox txtPassword;
        private Button btnOK;
        private Button btnCancel;
        private CheckBox chkAutoSave;
    }
}