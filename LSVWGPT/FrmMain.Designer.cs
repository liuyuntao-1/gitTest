using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.stat = new Gizmox.WebGUI.Forms.StatusStrip();
            this.tssLblUser = new Gizmox.WebGUI.Forms.ToolStripStatusLabel();
            this.tssLblVer = new Gizmox.WebGUI.Forms.ToolStripStatusLabel();
            this.tssLblVWGVer = new Gizmox.WebGUI.Forms.ToolStripStatusLabel();
            this.tssLblCopyRight = new Gizmox.WebGUI.Forms.ToolStripStatusLabel();
            this.lblTop = new Gizmox.WebGUI.Forms.Label();
            this.pnlLeft = new Gizmox.WebGUI.Forms.Panel();
            this.funcsTree = new LSVWGPT.Controls.UCFuncsTree();
            this.pnlLTitle = new Gizmox.WebGUI.Forms.Panel();
            this.tsMTools = new Gizmox.WebGUI.Forms.ToolStrip();
            this.tsBtnLogout = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.tsBtnRefresh = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.splitter1 = new Gizmox.WebGUI.Forms.Splitter();
            this.lblLeft = new Gizmox.WebGUI.Forms.Label();
            this.pnlMain = new Gizmox.WebGUI.Forms.Panel();
            this.tcMain = new Gizmox.WebGUI.Forms.TabControl();
            this.tpMain = new Gizmox.WebGUI.Forms.TabPage();
            this.tpHTML = new Gizmox.WebGUI.Forms.TabPage();
            this.pnlMTitle = new Gizmox.WebGUI.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.pnlLTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Linen;
            this.pnlTop.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pnlTop.BackgroundImage"));
            this.pnlTop.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(600, 80);
            this.pnlTop.TabIndex = 0;
            // 
            // stat
            // 
            this.stat.BackColor = System.Drawing.Color.Linen;
            this.stat.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.stat.DockPadding.Left = 1;
            this.stat.DockPadding.Right = 14;
            this.stat.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.tssLblUser,
            this.tssLblVer,
            this.tssLblVWGVer,
            this.tssLblCopyRight});
            this.stat.Location = new System.Drawing.Point(0, 444);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(600, 22);
            this.stat.TabIndex = 1;
            this.stat.Text = "statusStrip1";
            // 
            // tssLblUser
            // 
            this.tssLblUser.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLblUser.Margin = new Gizmox.WebGUI.Forms.Padding(0, 1, 0, 2);
            this.tssLblUser.Name = "tssLblUser";
            this.tssLblUser.Size = new System.Drawing.Size(65, 11);
            this.tssLblUser.Text = "tssLblUser";
            // 
            // tssLblVer
            // 
            this.tssLblVer.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblVer.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLblVer.Margin = new Gizmox.WebGUI.Forms.Padding(0, 1, 0, 2);
            this.tssLblVer.Name = "tssLblVer";
            this.tssLblVer.Size = new System.Drawing.Size(59, 11);
            this.tssLblVer.Text = "tssLblVer";
            // 
            // tssLblVWGVer
            // 
            this.tssLblVWGVer.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblVWGVer.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLblVWGVer.Margin = new Gizmox.WebGUI.Forms.Padding(0, 1, 0, 2);
            this.tssLblVWGVer.Name = "tssLblVWGVer";
            this.tssLblVWGVer.Size = new System.Drawing.Size(77, 11);
            this.tssLblVWGVer.Text = "tssLblVWGVer";
            // 
            // tssLblCopyRight
            // 
            this.tssLblCopyRight.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblCopyRight.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLblCopyRight.Margin = new Gizmox.WebGUI.Forms.Padding(0, 1, 0, 2);
            this.tssLblCopyRight.Name = "tssLblCopyRight";
            this.tssLblCopyRight.Size = new System.Drawing.Size(95, 11);
            this.tssLblCopyRight.Text = "tssLblCopyRight";
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.Wheat;
            this.lblTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.lblTop.Font = new System.Drawing.Font("宋体", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.Blue;
            this.lblTop.Location = new System.Drawing.Point(0, 80);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(600, 6);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "∧";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlLeft.Controls.Add(this.funcsTree);
            this.pnlLeft.Controls.Add(this.pnlLTitle);
            this.pnlLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 86);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 358);
            this.pnlLeft.TabIndex = 3;
            // 
            // funcsTree
            // 
            this.funcsTree.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.funcsTree.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.funcsTree.Location = new System.Drawing.Point(0, 22);
            this.funcsTree.Name = "funcsTree";
            this.funcsTree.Size = new System.Drawing.Size(200, 336);
            this.funcsTree.TabIndex = 1;
            this.funcsTree.Text = "UCFuncsTree";
            // 
            // pnlLTitle
            // 
            this.pnlLTitle.BackColor = System.Drawing.Color.Linen;
            this.pnlLTitle.Controls.Add(this.tsMTools);
            this.pnlLTitle.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlLTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlLTitle.Name = "pnlLTitle";
            this.pnlLTitle.Size = new System.Drawing.Size(200, 22);
            this.pnlLTitle.TabIndex = 0;
            // 
            // tsMTools
            // 
            this.tsMTools.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.tsBtnLogout,
            this.tsBtnRefresh});
            this.tsMTools.Location = new System.Drawing.Point(0, 0);
            this.tsMTools.Name = "tsMTools";
            this.tsMTools.Size = new System.Drawing.Size(200, 25);
            this.tsMTools.TabIndex = 0;
            this.tsMTools.Text = "toolStrip1";
            // 
            // tsBtnLogout
            // 
            this.tsBtnLogout.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLogout.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("tsBtnLogout.Image"));
            this.tsBtnLogout.Name = "tsBtnLogout";
            this.tsBtnLogout.Size = new System.Drawing.Size(23, 20);
            this.tsBtnLogout.Text = "注销";
            this.tsBtnLogout.ToolTipText = "注销";
            this.tsBtnLogout.Click += new System.EventHandler(this.tsBtnLogout_Click);
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRefresh.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("tsBtnRefresh.Image"));
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(23, 20);
            this.tsBtnRefresh.Text = "toolStripButton1";
            this.tsBtnRefresh.ToolTipText = "刷新";
            this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Wheat;
            this.splitter1.Location = new System.Drawing.Point(200, 86);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 358);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.Beige;
            this.lblLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.lblLeft.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.ForeColor = System.Drawing.Color.Blue;
            this.lblLeft.Location = new System.Drawing.Point(203, 86);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(6, 358);
            this.lblLeft.TabIndex = 5;
            this.lblLeft.Text = "<";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeft.Click += new System.EventHandler(this.lblLeft_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlMain.Controls.Add(this.tcMain);
            this.pnlMain.Controls.Add(this.pnlMTitle);
            this.pnlMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(209, 86);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(391, 358);
            this.pnlMain.TabIndex = 6;
            // 
            // tcMain
            // 
            this.tcMain.Appearance = Gizmox.WebGUI.Forms.TabAppearance.Logical;
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tpHTML);
            this.tcMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 22);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(391, 336);
            this.tcMain.TabIndex = 1;
            // 
            // tpMain
            // 
            this.tpMain.AutoScroll = true;
            this.tpMain.BackColor = System.Drawing.Color.PapayaWhip;
            this.tpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(383, 310);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "tpMain";
            // 
            // tpHTML
            // 
            this.tpHTML.AutoScroll = true;
            this.tpHTML.BackColor = System.Drawing.Color.PapayaWhip;
            this.tpHTML.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpHTML.Location = new System.Drawing.Point(4, 22);
            this.tpHTML.Name = "tpHTML";
            this.tpHTML.Size = new System.Drawing.Size(383, 310);
            this.tpHTML.TabIndex = 0;
            this.tpHTML.Text = "tpHTML";
            // 
            // pnlMTitle
            // 
            this.pnlMTitle.BackColor = System.Drawing.Color.Linen;
            this.pnlMTitle.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlMTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMTitle.Name = "pnlMTitle";
            this.pnlMTitle.Size = new System.Drawing.Size(391, 22);
            this.pnlMTitle.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Size = new System.Drawing.Size(600, 466);
            this.Text = "乐速VWG平台";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLTitle.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Panel pnlTop;
        private StatusStrip stat;
        private Label lblTop;
        private Panel pnlLeft;
        private Panel pnlLTitle;
        private Splitter splitter1;
        private Label lblLeft;
        private Panel pnlMain;
        private Panel pnlMTitle;
        private TabControl tcMain;
        private TabPage tpMain;
        private TabPage tpHTML;
        private ToolStrip tsMTools;
        private ToolStripButton tsBtnLogout;
        private ToolStripButton tsBtnRefresh;
        private Controls.UCFuncsTree funcsTree;
        private ToolStripStatusLabel tssLblUser;
        private ToolStripStatusLabel tssLblVer;
        private ToolStripStatusLabel tssLblVWGVer;
        private ToolStripStatusLabel tssLblCopyRight;
    }
}