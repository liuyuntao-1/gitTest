using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.XTGL
{
    partial class FrmJGGL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJGGL));
            this.grpLeft = new Gizmox.WebGUI.Forms.GroupBox();
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.mnuTrv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewBrother = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuNewChild = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.grpMain = new Gizmox.WebGUI.Forms.GroupBox();
            this.cmbBmlx = new Gizmox.WebGUI.Forms.ComboBox();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsJckj1 = new LSVWGPT.Datasets.DSJckj();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.txtProvince = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCity = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDz = new Gizmox.WebGUI.Forms.TextBox();
            this.txtYb = new Gizmox.WebGUI.Forms.TextBox();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.txtWzbz = new Gizmox.WebGUI.Forms.TextBox();
            this.txtJb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFzrId = new Gizmox.WebGUI.Forms.TextBox();
            this.txtJc = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMc = new Gizmox.WebGUI.Forms.TextBox();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.tjigouTableAdapter1 = new LSVWGPT.Datasets.DSJckjTableAdapters.tjigouTableAdapter();
            this.grpLeft.SuspendLayout();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJckj1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.trV);
            this.grpLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpLeft.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpLeft.Location = new System.Drawing.Point(10, 10);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(260, 460);
            this.grpLeft.TabIndex = 2;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "机构树";
            // 
            // trV
            // 
            this.trV.ContextMenuStrip = this.mnuTrv;
            this.trV.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.trV.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trV.ImageKey = "Folders.Folder_yellow_close_16.ico";
            this.trV.ImageList = this.imgLst;
            this.trV.Location = new System.Drawing.Point(3, 17);
            this.trV.Name = "trV";
            this.trV.SelectedImageKey = "Folders.Folder_yellow_open_16.ico";
            this.trV.Size = new System.Drawing.Size(254, 440);
            this.trV.TabIndex = 0;
            this.trV.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterSelect);
            // 
            // mnuTrv
            // 
            this.mnuTrv.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuTrv.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuTrv.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuTrv.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuTrv.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNewBrother,
            this.mnuNewChild,
            this.mnuDel});
            this.mnuTrv.Name = "mnuTrv";
            this.mnuTrv.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNewBrother
            // 
            this.mnuNewBrother.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewBrother.Image"));
            this.mnuNewBrother.Name = "mnuNewBrother";
            this.mnuNewBrother.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewBrother.Size = new System.Drawing.Size(147, 20);
            this.mnuNewBrother.Text = "新增同级机构";
            this.mnuNewBrother.Click += new System.EventHandler(this.mnuNewBrother_Click);
            // 
            // mnuNewChild
            // 
            this.mnuNewChild.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewChild.Image"));
            this.mnuNewChild.Name = "mnuNewChild";
            this.mnuNewChild.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewChild.Size = new System.Drawing.Size(147, 20);
            this.mnuNewChild.Text = "新增下级机构";
            this.mnuNewChild.Click += new System.EventHandler(this.mnuNewChild_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(147, 20);
            this.mnuDel.Text = "删除当前机构";
            this.mnuDel.Click += new System.EventHandler(this.mnuDel_Click);
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
            // grpMain
            // 
            this.grpMain.Controls.Add(this.cmbBmlx);
            this.grpMain.Controls.Add(this.label11);
            this.grpMain.Controls.Add(this.label10);
            this.grpMain.Controls.Add(this.label9);
            this.grpMain.Controls.Add(this.label8);
            this.grpMain.Controls.Add(this.label7);
            this.grpMain.Controls.Add(this.txtProvince);
            this.grpMain.Controls.Add(this.txtCity);
            this.grpMain.Controls.Add(this.txtDz);
            this.grpMain.Controls.Add(this.txtYb);
            this.grpMain.Controls.Add(this.btnCancel);
            this.grpMain.Controls.Add(this.btnSave);
            this.grpMain.Controls.Add(this.chkActive);
            this.grpMain.Controls.Add(this.txtWzbz);
            this.grpMain.Controls.Add(this.txtJb);
            this.grpMain.Controls.Add(this.txtFzrId);
            this.grpMain.Controls.Add(this.txtJc);
            this.grpMain.Controls.Add(this.txtMc);
            this.grpMain.Controls.Add(this.lblId);
            this.grpMain.Controls.Add(this.label6);
            this.grpMain.Controls.Add(this.label5);
            this.grpMain.Controls.Add(this.label4);
            this.grpMain.Controls.Add(this.label3);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpMain.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.Location = new System.Drawing.Point(270, 10);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(643, 460);
            this.grpMain.TabIndex = 3;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "机构信息";
            // 
            // cmbBmlx
            // 
            this.cmbBmlx.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("SelectedValue", this.bds, "bmlx", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.cmbBmlx.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbBmlx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBmlx.FormattingEnabled = true;
            this.cmbBmlx.Location = new System.Drawing.Point(89, 225);
            this.cmbBmlx.Name = "cmbBmlx";
            this.cmbBmlx.Size = new System.Drawing.Size(100, 20);
            this.cmbBmlx.TabIndex = 4;
            this.cmbBmlx.SelectedIndexChanged += new System.EventHandler(this.cmbBmlx_SelectedIndexChanged);
            // 
            // bds
            // 
            this.bds.DataMember = "tjigou";
            this.bds.DataSource = this.dsJckj1;
            // 
            // dsJckj1
            // 
            this.dsJckj1.DataSetName = "DSJckj";
            this.dsJckj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(242, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "省份";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(242, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "城市";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "邮箱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "位置标志";
            // 
            // txtProvince
            // 
            this.txtProvince.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "province", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtProvince.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(274, 96);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "city", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtCity.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(274, 134);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtDz
            // 
            this.txtDz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dz", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtDz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDz.Location = new System.Drawing.Point(274, 180);
            this.txtDz.Name = "txtDz";
            this.txtDz.Size = new System.Drawing.Size(197, 20);
            this.txtDz.TabIndex = 8;
            // 
            // txtYb
            // 
            this.txtYb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "yb", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtYb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYb.Location = new System.Drawing.Point(274, 225);
            this.txtYb.Name = "txtYb";
            this.txtYb.Size = new System.Drawing.Size(100, 20);
            this.txtYb.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(220, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(114, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Checked", this.bds, "active", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.chkActive.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(107, 297);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(48, 16);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "活动";
            // 
            // txtWzbz
            // 
            this.txtWzbz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "wzbz", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtWzbz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWzbz.Location = new System.Drawing.Point(274, 266);
            this.txtWzbz.Name = "txtWzbz";
            this.txtWzbz.Size = new System.Drawing.Size(100, 20);
            this.txtWzbz.TabIndex = 10;
            // 
            // txtJb
            // 
            this.txtJb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jb", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtJb.Enabled = false;
            this.txtJb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJb.Location = new System.Drawing.Point(89, 261);
            this.txtJb.Name = "txtJb";
            this.txtJb.Size = new System.Drawing.Size(100, 20);
            this.txtJb.TabIndex = 5;
            // 
            // txtFzrId
            // 
            this.txtFzrId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "fzrid", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtFzrId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFzrId.Location = new System.Drawing.Point(89, 180);
            this.txtFzrId.Name = "txtFzrId";
            this.txtFzrId.Size = new System.Drawing.Size(100, 20);
            this.txtFzrId.TabIndex = 3;
            this.txtFzrId.TextChanged += new System.EventHandler(this.txtBm_TextChanged);
            // 
            // txtJc
            // 
            this.txtJc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jc", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtJc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJc.Location = new System.Drawing.Point(89, 134);
            this.txtJc.Name = "txtJc";
            this.txtJc.Size = new System.Drawing.Size(100, 20);
            this.txtJc.TabIndex = 2;
            // 
            // txtMc
            // 
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtMc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMc.Location = new System.Drawing.Point(89, 96);
            this.txtMc.Name = "txtMc";
            this.txtMc.Size = new System.Drawing.Size(100, 20);
            this.txtMc.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.lblId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(92, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "lblId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "级别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "部门类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "负责人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "简称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "名称（*）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tjigouTableAdapter1
            // 
            this.tjigouTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmJGGL
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpLeft);
            this.DockPadding.All = 10;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(923, 480);
            this.Text = "机构管理";
            this.grpLeft.ResumeLayout(false);
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJckj1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private GroupBox grpLeft;
        private TreeView trV;
        private ImageList imgLst;
        private GroupBox grpMain;
        private Datasets.DSJckj dsJckj1;
        private Datasets.DSJckjTableAdapters.tjigouTableAdapter tjigouTableAdapter1;
        private BindingSource bds;
        private CheckBox chkActive;
        private TextBox txtWzbz;
        private TextBox txtJb;
        private TextBox txtFzrId;
        private TextBox txtJc;
        private TextBox txtMc;
        private Label lblId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private ContextMenuStrip mnuTrv;
        private ToolStripMenuItem mnuNewBrother;
        private ToolStripMenuItem mnuNewChild;
        private ToolStripMenuItem mnuDel;
        private ComboBox cmbBmlx;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtProvince;
        private TextBox txtCity;
        private TextBox txtDz;
        private TextBox txtYb;
    }
}