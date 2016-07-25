using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace JXC.JH
{
    partial class FrmJhdLB
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJhdLB));
            this.grpMain = new Gizmox.WebGUI.Forms.GroupBox();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.mnuDgv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEdit = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetail = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsJxc1 = new JXC.Datasets.DSJxc();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.tjhdTableAdapter1 = new JXC.Datasets.DSJxcTableAdapters.tjhdTableAdapter();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJxc1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.dgv);
            this.grpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpMain.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.Location = new System.Drawing.Point(20, 95);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(550, 351);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "进货单列表";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn1});
            this.dgv.ContextMenuStrip = this.mnuDgv;
            this.dgv.DataSource = this.bds;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.IsSelectionChangeCritical = true;
            this.dgv.Location = new System.Drawing.Point(3, 17);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(544, 331);
            this.dgv.TabIndex = 0;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            this.dgv.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "jhdh";
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn17.HeaderText = "单号";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 90;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ghsh";
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn18.HeaderText = "供货商";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 120;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "lxr";
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn19.HeaderText = "联系人";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 60;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "lxdh";
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn20.HeaderText = "联系电话";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "hja";
            dataGridViewCellStyle7.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "合计";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // mnuDgv
            // 
            this.mnuDgv.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuDgv.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuDgv.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuDgv.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuDgv.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuEdit,
            this.mnuDetail,
            this.mnuDel});
            this.mnuDgv.Name = "mnuDgv";
            this.mnuDgv.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNew
            // 
            this.mnuNew.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNew.Image"));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNew.Size = new System.Drawing.Size(97, 20);
            this.mnuNew.Text = "新增";
            this.mnuNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuEdit.Image"));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuEdit.Size = new System.Drawing.Size(97, 20);
            this.mnuEdit.Text = "编辑";
            this.mnuEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // mnuDetail
            // 
            this.mnuDetail.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDetail.Image"));
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDetail.Size = new System.Drawing.Size(97, 20);
            this.mnuDetail.Text = "详细";
            this.mnuDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(97, 20);
            this.mnuDel.Text = "删除";
            this.mnuDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // bds
            // 
            this.bds.DataMember = "tjhd";
            this.bds.DataSource = this.dsJxc1;
            // 
            // dsJxc1
            // 
            this.dsJxc1.DataSetName = "DSJxc";
            this.dsJxc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.Location = new System.Drawing.Point(3, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "新增";
            this.btnNew.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEdit.Image"));
            this.btnEdit.Location = new System.Drawing.Point(90, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑";
            this.btnEdit.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetail.Image"));
            this.btnDetail.Location = new System.Drawing.Point(177, 27);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "详细";
            this.btnDetail.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.Location = new System.Drawing.Point(264, 27);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Controls.Add(this.btnDel);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnDetail);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(20, 20);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(550, 75);
            this.pnlTop.TabIndex = 5;
            this.pnlTop.Click += new System.EventHandler(this.pnlTop_Click);
            // 
            // tjhdTableAdapter1
            // 
            this.tjhdTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmJhdLB
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.pnlTop);
            this.DockPadding.All = 20;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(20);
            this.Size = new System.Drawing.Size(590, 466);
            this.Text = "进货单列表";
            this.Load += new System.EventHandler(this.FrmOptionLBLB_Load);
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJxc1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox grpMain;
        private DataGridView dgv;
        private Datasets.DSJxc dsJxc1;
        private BindingSource bds;
        
        private ContextMenuStrip mnuDgv;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDetail;
        private ToolStripMenuItem mnuDel;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDetail;
        private Button btnDel;
        private Panel pnlTop;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Datasets.DSJxcTableAdapters.tjhdTableAdapter tjhdTableAdapter1;
    }
}