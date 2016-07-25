using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.XTGL
{
    partial class FrmMKGL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMKGL));
            this.grpLeft = new Gizmox.WebGUI.Forms.GroupBox();
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.mnuTrv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewBrother = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuNewChild = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.grpMain = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsJckj1 = new LSVWGPT.Datasets.DSJckj();
            this.txtBz = new Gizmox.WebGUI.Forms.TextBox();
            this.txtJb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtBm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMc = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.tfuncsTableAdapter1 = new LSVWGPT.Datasets.DSJckjTableAdapters.tfuncsTableAdapter();
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
            this.grpLeft.Text = "模块树";
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
            this.mnuNewBrother.Text = "新增同级模块";
            this.mnuNewBrother.Click += new System.EventHandler(this.mnuNewBrother_Click);
            // 
            // mnuNewChild
            // 
            this.mnuNewChild.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewChild.Image"));
            this.mnuNewChild.Name = "mnuNewChild";
            this.mnuNewChild.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewChild.Size = new System.Drawing.Size(147, 20);
            this.mnuNewChild.Text = "新增下级模块";
            this.mnuNewChild.Click += new System.EventHandler(this.mnuNewChild_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(147, 20);
            this.mnuDel.Text = "删除当前模块";
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
            this.grpMain.Controls.Add(this.btnCancel);
            this.grpMain.Controls.Add(this.btnSave);
            this.grpMain.Controls.Add(this.chkActive);
            this.grpMain.Controls.Add(this.txtBz);
            this.grpMain.Controls.Add(this.txtJb);
            this.grpMain.Controls.Add(this.txtBm);
            this.grpMain.Controls.Add(this.txtMc);
            this.grpMain.Controls.Add(this.txtXh);
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
            this.grpMain.Size = new System.Drawing.Size(320, 460);
            this.grpMain.TabIndex = 3;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "模块信息";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(119, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(35, 335);
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
            this.chkActive.Location = new System.Drawing.Point(95, 297);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(48, 16);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "活动";
            // 
            // bds
            // 
            this.bds.DataMember = "tfuncs";
            this.bds.DataSource = this.dsJckj1;
            // 
            // dsJckj1
            // 
            this.dsJckj1.DataSetName = "DSJckj";
            this.dsJckj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBz
            // 
            this.txtBz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bz", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtBz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBz.Location = new System.Drawing.Point(95, 261);
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(100, 20);
            this.txtBz.TabIndex = 5;
            // 
            // txtJb
            // 
            this.txtJb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jb", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtJb.Enabled = false;
            this.txtJb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJb.Location = new System.Drawing.Point(95, 225);
            this.txtJb.Name = "txtJb";
            this.txtJb.Size = new System.Drawing.Size(100, 20);
            this.txtJb.TabIndex = 4;
            // 
            // txtBm
            // 
            this.txtBm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bm", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtBm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBm.Location = new System.Drawing.Point(95, 180);
            this.txtBm.Name = "txtBm";
            this.txtBm.Size = new System.Drawing.Size(100, 20);
            this.txtBm.TabIndex = 3;
            this.txtBm.TextChanged += new System.EventHandler(this.txtBm_TextChanged);
            // 
            // txtMc
            // 
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtMc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMc.Location = new System.Drawing.Point(95, 134);
            this.txtMc.Name = "txtMc";
            this.txtMc.Size = new System.Drawing.Size(100, 20);
            this.txtMc.TabIndex = 2;
            // 
            // txtXh
            // 
            this.txtXh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xh", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtXh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXh.Location = new System.Drawing.Point(95, 96);
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(100, 20);
            this.txtXh.TabIndex = 1;
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
            this.label6.Location = new System.Drawing.Point(33, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "级别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "编码（*）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "名称（*）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "序号（*）";
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
            // tfuncsTableAdapter1
            // 
            this.tfuncsTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmMKGL
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpLeft);
            this.DockPadding.All = 10;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 480);
            this.Text = "模块管理";
            this.Load += new System.EventHandler(this.FrmMKGL_Load);
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
        private Datasets.DSJckjTableAdapters.tfuncsTableAdapter tfuncsTableAdapter1;
        private BindingSource bds;
        private CheckBox chkActive;
        private TextBox txtBz;
        private TextBox txtJb;
        private TextBox txtBm;
        private TextBox txtMc;
        private TextBox txtXh;
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
    }
}