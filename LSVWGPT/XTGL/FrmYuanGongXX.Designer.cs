using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.XTGL
{
    partial class FrmYuanGongXX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYuanGongXX));
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.label13 = new Gizmox.WebGUI.Forms.Label();
            this.label14 = new Gizmox.WebGUI.Forms.Label();
            this.label15 = new Gizmox.WebGUI.Forms.Label();
            this.label16 = new Gizmox.WebGUI.Forms.Label();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtOTel = new Gizmox.WebGUI.Forms.TextBox();
            this.txtWx = new Gizmox.WebGUI.Forms.TextBox();
            this.txtQQ = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMTel = new Gizmox.WebGUI.Forms.TextBox();
            this.txtEmail = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFax = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbXb = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbGw = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbRole = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbXl = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbZt = new Gizmox.WebGUI.Forms.ComboBox();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.dtpRzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.dtpLzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new Gizmox.WebGUI.Forms.Label();
            this.btnPassword = new Gizmox.WebGUI.Forms.Button();
            this.txtLoginName = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbJgTree = new LSLib.Controls.TreeViewComboBox.TreeViewComboBox();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(359, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(235, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "机构";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "序号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "姓名(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "角色";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "岗位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "学历";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "市话";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "手机";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Fax";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "QQ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(325, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "微信";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(301, 322);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "入职日期";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(301, 360);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "离职日期";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(118, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // txtXh
            // 
            this.txtXh.Enabled = false;
            this.txtXh.Location = new System.Drawing.Point(107, 53);
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(121, 20);
            this.txtXh.TabIndex = 1;
            // 
            // txtXm
            // 
            this.txtXm.Location = new System.Drawing.Point(107, 129);
            this.txtXm.Name = "txtXm";
            this.txtXm.Size = new System.Drawing.Size(121, 20);
            this.txtXm.TabIndex = 3;
            // 
            // txtOTel
            // 
            this.txtOTel.Location = new System.Drawing.Point(359, 91);
            this.txtOTel.Name = "txtOTel";
            this.txtOTel.Size = new System.Drawing.Size(121, 21);
            this.txtOTel.TabIndex = 11;
            // 
            // txtWx
            // 
            this.txtWx.Location = new System.Drawing.Point(359, 281);
            this.txtWx.Name = "txtWx";
            this.txtWx.Size = new System.Drawing.Size(121, 21);
            this.txtWx.TabIndex = 16;
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(359, 243);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(121, 21);
            this.txtQQ.TabIndex = 15;
            // 
            // txtMTel
            // 
            this.txtMTel.Location = new System.Drawing.Point(359, 129);
            this.txtMTel.Name = "txtMTel";
            this.txtMTel.Size = new System.Drawing.Size(121, 21);
            this.txtMTel.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(359, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 21);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(359, 167);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(121, 21);
            this.txtFax.TabIndex = 13;
            // 
            // cmbXb
            // 
            this.cmbXb.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbXb.FormattingEnabled = true;
            this.cmbXb.Location = new System.Drawing.Point(107, 243);
            this.cmbXb.Name = "cmbXb";
            this.cmbXb.Size = new System.Drawing.Size(121, 21);
            this.cmbXb.TabIndex = 6;
            // 
            // cmbGw
            // 
            this.cmbGw.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbGw.FormattingEnabled = true;
            this.cmbGw.Location = new System.Drawing.Point(107, 321);
            this.cmbGw.Name = "cmbGw";
            this.cmbGw.Size = new System.Drawing.Size(121, 21);
            this.cmbGw.TabIndex = 8;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(107, 281);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 21);
            this.cmbRole.TabIndex = 7;
            // 
            // cmbXl
            // 
            this.cmbXl.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbXl.FormattingEnabled = true;
            this.cmbXl.Location = new System.Drawing.Point(107, 359);
            this.cmbXl.Name = "cmbXl";
            this.cmbXl.Size = new System.Drawing.Size(121, 21);
            this.cmbXl.TabIndex = 9;
            // 
            // cmbZt
            // 
            this.cmbZt.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbZt.FormattingEnabled = true;
            this.cmbZt.Location = new System.Drawing.Point(359, 53);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.Size = new System.Drawing.Size(121, 21);
            this.cmbZt.TabIndex = 10;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(107, 385);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(50, 17);
            this.chkActive.TabIndex = 19;
            this.chkActive.Text = "活动";
            // 
            // dtpRzrq
            // 
            this.dtpRzrq.CustomFormat = "";
            this.dtpRzrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRzrq.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpRzrq.Location = new System.Drawing.Point(359, 319);
            this.dtpRzrq.Name = "dtpRzrq";
            this.dtpRzrq.Size = new System.Drawing.Size(121, 21);
            this.dtpRzrq.TabIndex = 17;
            // 
            // dtpLzrq
            // 
            this.dtpLzrq.CustomFormat = "";
            this.dtpLzrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLzrq.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpLzrq.Location = new System.Drawing.Point(359, 357);
            this.dtpLzrq.Name = "dtpLzrq";
            this.dtpLzrq.Size = new System.Drawing.Size(121, 21);
            this.dtpLzrq.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(48, 26);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(15, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "id";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(32, 52);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "机构";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(32, 88);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "序号";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(32, 169);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "性别";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(104, 242);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "角色";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(62, 170);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "账户(*)";
            // 
            // btnPassword
            // 
            this.btnPassword.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnPassword.Image"));
            this.btnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.Location = new System.Drawing.Point(32, 203);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(75, 23);
            this.btnPassword.TabIndex = 18;
            this.btnPassword.Text = "口令";
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(107, 168);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(121, 20);
            this.txtLoginName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(118, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cmbJgTree
            // 
            this.cmbJgTree.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbJgTree.FormattingEnabled = true;
            this.cmbJgTree.ImageList = this.imgLst;
            this.cmbJgTree.IsNonLeafNodeSelectable = true;
            this.cmbJgTree.Location = new System.Drawing.Point(107, 91);
            this.cmbJgTree.Name = "cmbJgTree";
            this.cmbJgTree.Size = new System.Drawing.Size(121, 21);
            this.cmbJgTree.TabIndex = 20;
            this.cmbJgTree.TreeHeight = 200;
            this.cmbJgTree.TreeWidth = 120;
            this.cmbJgTree.SelectedIndexChanged += new System.EventHandler(this.cmbJgTree_SelectedIndexChanged);
            // 
            // imgLst
            // 
            this.imgLst.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images1"))});
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.Images.SetKeyName(0, "Folders.Folder_yellow_close_16.ico");
            this.imgLst.Images.SetKeyName(1, "Folders.Folder_yellow_open_16.ico");
            // 
            // FrmYuanGongXX
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.cmbJgTree);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dtpLzrq);
            this.Controls.Add(this.dtpRzrq);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cmbZt);
            this.Controls.Add(this.cmbXl);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbGw);
            this.Controls.Add(this.cmbXb);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMTel);
            this.Controls.Add(this.txtQQ);
            this.Controls.Add(this.txtWx);
            this.Controls.Add(this.txtOTel);
            this.Controls.Add(this.txtXm);
            this.Controls.Add(this.txtXh);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(734, 487);
            this.Text = "员工详细信息";
            this.Load += new System.EventHandler(this.FrmYuanGongXX_Load);
            this.ResumeLayout(false);

        }


        #endregion
        private Button btnClose;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label lblId;
        private TextBox txtXh;
        private TextBox txtXm;
        private TextBox txtOTel;
        private TextBox txtWx;
        private TextBox txtQQ;
        private TextBox txtMTel;
        private TextBox txtEmail;
        private TextBox txtFax;
        private ComboBox cmbXb;
        private ComboBox cmbGw;
        private ComboBox cmbRole;
        private ComboBox cmbXl;
        private ComboBox cmbZt;
        private CheckBox chkActive;
        private DateTimePicker dtpRzrq;
        private DateTimePicker dtpLzrq;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private Label label21;
        private Button btnPassword;
        private TextBox txtLoginName;
        private TextBox txtPassword;
        private LSLib.Controls.TreeViewComboBox.TreeViewComboBox cmbJgTree;
        private ImageList imgLst;
    }
}