using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.XTGL
{
    partial class FrmOptionLBLB
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptionLBLB));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.grpMain = new Gizmox.WebGUI.Forms.GroupBox();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.mnuDgv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEdit = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetail = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsJckj1 = new LSVWGPT.Datasets.DSJckj();
            this.toptionlbTableAdapter1 = new LSVWGPT.Datasets.DSJckjTableAdapters.toptionlbTableAdapter();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.pnlLB = new Gizmox.WebGUI.Forms.Panel();
            this.grpXM = new Gizmox.WebGUI.Forms.GroupBox();
            this.dgvXM = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.mnuXM = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEditXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetailXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDelXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.bdsXM = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.toptionxmTableAdapter1 = new LSVWGPT.Datasets.DSJckjTableAdapters.toptionxmTableAdapter();
            this.pnlXM = new Gizmox.WebGUI.Forms.Panel();
            this.btnDetailXM = new Gizmox.WebGUI.Forms.Button();
            this.btnEditXM = new Gizmox.WebGUI.Forms.Button();
            this.btnDelXM = new Gizmox.WebGUI.Forms.Button();
            this.btnNewXM = new Gizmox.WebGUI.Forms.Button();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJckj1)).BeginInit();
            this.pnlLB.SuspendLayout();
            this.grpXM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXM)).BeginInit();
            this.pnlXM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.dgv);
            this.grpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpMain.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.Location = new System.Drawing.Point(20, 20);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(217, 426);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "选项类别列表";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv.ContextMenuStrip = this.mnuDgv;
            this.dgv.DataSource = this.bds;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.IsSelectionChangeCritical = true;
            this.dgv.Location = new System.Drawing.Point(3, 17);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(211, 406);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            this.dgv.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dm";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            this.bds.DataMember = "toptionlb";
            this.bds.DataSource = this.dsJckj1;
            // 
            // dsJckj1
            // 
            this.dsJckj1.DataSetName = "DSJckj";
            this.dsJckj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toptionlbTableAdapter1
            // 
            this.toptionlbTableAdapter1.ClearBeforeFill = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.Location = new System.Drawing.Point(19, 104);
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
            this.btnEdit.Location = new System.Drawing.Point(19, 141);
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
            this.btnDetail.Location = new System.Drawing.Point(19, 178);
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
            this.btnDel.Location = new System.Drawing.Point(19, 216);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pnlLB
            // 
            this.pnlLB.Controls.Add(this.btnNew);
            this.pnlLB.Controls.Add(this.btnDel);
            this.pnlLB.Controls.Add(this.btnEdit);
            this.pnlLB.Controls.Add(this.btnDetail);
            this.pnlLB.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlLB.Location = new System.Drawing.Point(237, 20);
            this.pnlLB.Name = "pnlLB";
            this.pnlLB.Size = new System.Drawing.Size(109, 426);
            this.pnlLB.TabIndex = 5;
            // 
            // grpXM
            // 
            this.grpXM.Controls.Add(this.dgvXM);
            this.grpXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpXM.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpXM.Location = new System.Drawing.Point(346, 20);
            this.grpXM.Name = "grpXM";
            this.grpXM.Size = new System.Drawing.Size(215, 426);
            this.grpXM.TabIndex = 6;
            this.grpXM.TabStop = false;
            this.grpXM.Text = "选项项目列表";
            // 
            // dgvXM
            // 
            this.dgvXM.AllowUserToAddRows = false;
            this.dgvXM.AllowUserToDeleteRows = false;
            this.dgvXM.AllowUserToResizeColumns = false;
            this.dgvXM.AllowUserToResizeRows = false;
            this.dgvXM.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgvXM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvXM.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvXM.ContextMenuStrip = this.mnuXM;
            this.dgvXM.DataSource = this.bdsXM;
            this.dgvXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvXM.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvXM.IsSelectionChangeCritical = true;
            this.dgvXM.Location = new System.Drawing.Point(3, 17);
            this.dgvXM.Name = "dgvXM";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dgvXM.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvXM.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXM.Size = new System.Drawing.Size(209, 406);
            this.dgvXM.TabIndex = 0;
            this.dgvXM.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dm";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "代码";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // mnuXM
            // 
            this.mnuXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuXM.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuXM.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuXM.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuXM.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNewXM,
            this.mnuEditXM,
            this.mnuDetailXM,
            this.mnuDelXM});
            this.mnuXM.Name = "mnuXM";
            this.mnuXM.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNewXM
            // 
            this.mnuNewXM.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNewXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewXM.Image"));
            this.mnuNewXM.Name = "mnuNewXM";
            this.mnuNewXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewXM.Size = new System.Drawing.Size(97, 20);
            this.mnuNewXM.Text = "新增";
            this.mnuNewXM.Click += new System.EventHandler(this.btnNewXM_Click);
            // 
            // mnuEditXM
            // 
            this.mnuEditXM.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEditXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuEditXM.Image"));
            this.mnuEditXM.Name = "mnuEditXM";
            this.mnuEditXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuEditXM.Size = new System.Drawing.Size(97, 20);
            this.mnuEditXM.Text = "编辑";
            this.mnuEditXM.Click += new System.EventHandler(this.btnEditXM_Click);
            // 
            // mnuDetailXM
            // 
            this.mnuDetailXM.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDetailXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDetailXM.Image"));
            this.mnuDetailXM.Name = "mnuDetailXM";
            this.mnuDetailXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDetailXM.Size = new System.Drawing.Size(97, 20);
            this.mnuDetailXM.Text = "详细";
            this.mnuDetailXM.Click += new System.EventHandler(this.btnDetailXM_Click);
            // 
            // mnuDelXM
            // 
            this.mnuDelXM.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDelXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDelXM.Image"));
            this.mnuDelXM.Name = "mnuDelXM";
            this.mnuDelXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDelXM.Size = new System.Drawing.Size(97, 20);
            this.mnuDelXM.Text = "删除";
            this.mnuDelXM.Click += new System.EventHandler(this.btnDelXM_Click);
            // 
            // bdsXM
            // 
            this.bdsXM.DataMember = "toptionxm";
            this.bdsXM.DataSource = this.dsJckj1;
            // 
            // toptionxmTableAdapter1
            // 
            this.toptionxmTableAdapter1.ClearBeforeFill = true;
            // 
            // pnlXM
            // 
            this.pnlXM.Controls.Add(this.btnDetailXM);
            this.pnlXM.Controls.Add(this.btnEditXM);
            this.pnlXM.Controls.Add(this.btnDelXM);
            this.pnlXM.Controls.Add(this.btnNewXM);
            this.pnlXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlXM.Location = new System.Drawing.Point(561, 20);
            this.pnlXM.Name = "pnlXM";
            this.pnlXM.Size = new System.Drawing.Size(109, 426);
            this.pnlXM.TabIndex = 7;
            // 
            // btnDetailXM
            // 
            this.btnDetailXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetailXM.Image"));
            this.btnDetailXM.Location = new System.Drawing.Point(17, 178);
            this.btnDetailXM.Name = "btnDetailXM";
            this.btnDetailXM.Size = new System.Drawing.Size(75, 23);
            this.btnDetailXM.TabIndex = 3;
            this.btnDetailXM.Text = "详细";
            this.btnDetailXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailXM.Click += new System.EventHandler(this.btnDetailXM_Click);
            // 
            // btnEditXM
            // 
            this.btnEditXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEditXM.Image"));
            this.btnEditXM.Location = new System.Drawing.Point(17, 141);
            this.btnEditXM.Name = "btnEditXM";
            this.btnEditXM.Size = new System.Drawing.Size(75, 23);
            this.btnEditXM.TabIndex = 2;
            this.btnEditXM.Text = "编辑";
            this.btnEditXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditXM.Click += new System.EventHandler(this.btnEditXM_Click);
            // 
            // btnDelXM
            // 
            this.btnDelXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDelXM.Image"));
            this.btnDelXM.Location = new System.Drawing.Point(17, 216);
            this.btnDelXM.Name = "btnDelXM";
            this.btnDelXM.Size = new System.Drawing.Size(75, 23);
            this.btnDelXM.TabIndex = 4;
            this.btnDelXM.Text = "删除";
            this.btnDelXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelXM.Click += new System.EventHandler(this.btnDelXM_Click);
            // 
            // btnNewXM
            // 
            this.btnNewXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNewXM.Image"));
            this.btnNewXM.Location = new System.Drawing.Point(17, 104);
            this.btnNewXM.Name = "btnNewXM";
            this.btnNewXM.Size = new System.Drawing.Size(75, 23);
            this.btnNewXM.TabIndex = 1;
            this.btnNewXM.Text = "新增";
            this.btnNewXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewXM.Click += new System.EventHandler(this.btnNewXM_Click);
            // 
            // FrmOptionLBLB
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.pnlXM);
            this.Controls.Add(this.grpXM);
            this.Controls.Add(this.pnlLB);
            this.Controls.Add(this.grpMain);
            this.DockPadding.All = 20;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(20);
            this.Size = new System.Drawing.Size(775, 466);
            this.Text = "选项类别列表";
            this.Load += new System.EventHandler(this.FrmOptionLBLB_Load);
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJckj1)).EndInit();
            this.pnlLB.ResumeLayout(false);
            this.grpXM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXM)).EndInit();
            this.pnlXM.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox grpMain;
        private DataGridView dgv;
        private Datasets.DSJckj dsJckj1;
        private BindingSource bds;
        private Datasets.DSJckjTableAdapters.toptionlbTableAdapter toptionlbTableAdapter1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ContextMenuStrip mnuDgv;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDetail;
        private ToolStripMenuItem mnuDel;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDetail;
        private Button btnDel;
        private Panel pnlLB;
        private GroupBox grpXM;
        private DataGridView dgvXM;
        private BindingSource bdsXM;
        private Datasets.DSJckjTableAdapters.toptionxmTableAdapter toptionxmTableAdapter1;
        private ContextMenuStrip mnuXM;
        private ToolStripMenuItem mnuNewXM;
        private ToolStripMenuItem mnuEditXM;
        private ToolStripMenuItem mnuDetailXM;
        private ToolStripMenuItem mnuDelXM;
        private Panel pnlXM;
        private Button btnDetailXM;
        private Button btnEditXM;
        private Button btnDelXM;
        private Button btnNewXM;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}