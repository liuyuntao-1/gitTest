using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace JXC.JH
{
    partial class FrmJhdXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJhdXX));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.txtJhdh = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLxr = new Gizmox.WebGUI.Forms.TextBox();
            this.txtGhsh = new Gizmox.WebGUI.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new Gizmox.WebGUI.Forms.Label();
            this.txtLxdh = new Gizmox.WebGUI.Forms.TextBox();
            this.pnlBottom = new Gizmox.WebGUI.Forms.Panel();
            this.grpMaster = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblHj = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.colId = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colXh = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colPm = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colBm = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colDw = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colSl = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colDj = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colJe = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.mnuDgv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEdit = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetail = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.grpDetail = new Gizmox.WebGUI.Forms.GroupBox();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.tableAdapterManager1 = new JXC.Datasets.DSJxcTableAdapters.TableAdapterManager();
            this.tjhmxTableAdapter1 = new JXC.Datasets.DSJxcTableAdapters.tjhmxTableAdapter();
            this.bdsMx = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.pnlBottom.SuspendLayout();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMx)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(392, 48);
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
            this.btnSave.Location = new System.Drawing.Point(268, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "供货商(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "单号(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "联系人";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(89, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // txtJhdh
            // 
            this.txtJhdh.Location = new System.Drawing.Point(95, 44);
            this.txtJhdh.Name = "txtJhdh";
            this.txtJhdh.Size = new System.Drawing.Size(121, 20);
            this.txtJhdh.TabIndex = 1;
            // 
            // txtLxr
            // 
            this.txtLxr.Location = new System.Drawing.Point(293, 44);
            this.txtLxr.Name = "txtLxr";
            this.txtLxr.Size = new System.Drawing.Size(121, 20);
            this.txtLxr.TabIndex = 3;
            // 
            // txtGhsh
            // 
            this.txtGhsh.Location = new System.Drawing.Point(95, 82);
            this.txtGhsh.Name = "txtGhsh";
            this.txtGhsh.Size = new System.Drawing.Size(121, 21);
            this.txtGhsh.TabIndex = 16;
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
            this.label21.Location = new System.Drawing.Point(235, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "联系电话";
            // 
            // txtLxdh
            // 
            this.txtLxdh.Location = new System.Drawing.Point(293, 82);
            this.txtLxdh.Name = "txtLxdh";
            this.txtLxdh.Size = new System.Drawing.Size(121, 20);
            this.txtLxdh.TabIndex = 4;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 424);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(595, 100);
            this.pnlBottom.TabIndex = 3;
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.lblHj);
            this.grpMaster.Controls.Add(this.label5);
            this.grpMaster.Controls.Add(this.label1);
            this.grpMaster.Controls.Add(this.label2);
            this.grpMaster.Controls.Add(this.txtLxdh);
            this.grpMaster.Controls.Add(this.label3);
            this.grpMaster.Controls.Add(this.label21);
            this.grpMaster.Controls.Add(this.label4);
            this.grpMaster.Controls.Add(this.txtGhsh);
            this.grpMaster.Controls.Add(this.lblId);
            this.grpMaster.Controls.Add(this.txtLxr);
            this.grpMaster.Controls.Add(this.txtJhdh);
            this.grpMaster.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.grpMaster.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMaster.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaster.Location = new System.Drawing.Point(0, 0);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(595, 129);
            this.grpMaster.TabIndex = 1;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "进货单";
            // 
            // lblHj
            // 
            this.lblHj.AutoSize = true;
            this.lblHj.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHj.Location = new System.Drawing.Point(504, 65);
            this.lblHj.Name = "lblHj";
            this.lblHj.Size = new System.Drawing.Size(17, 13);
            this.lblHj.TabIndex = 6;
            this.lblHj.Text = "hj";
            this.lblHj.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "合计";
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
            this.colId,
            this.colXh,
            this.colPm,
            this.colBm,
            this.colDw,
            this.colSl,
            this.colDj,
            this.colJe});
            this.dgv.ContextMenuStrip = this.mnuDgv;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.IsSelectionChangeCritical = true;
            this.dgv.Location = new System.Drawing.Point(3, 92);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(589, 200);
            this.dgv.TabIndex = 2;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            this.dgv.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // colId
            // 
            this.colId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colXh
            // 
            this.colXh.DefaultCellStyle = dataGridViewCellStyle3;
            this.colXh.HeaderText = "序号";
            this.colXh.Name = "colXh";
            this.colXh.ReadOnly = true;
            this.colXh.Width = 40;
            // 
            // colPm
            // 
            this.colPm.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPm.HeaderText = "品名";
            this.colPm.Name = "colPm";
            this.colPm.ReadOnly = true;
            // 
            // colBm
            // 
            this.colBm.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBm.HeaderText = "编码";
            this.colBm.Name = "colBm";
            this.colBm.ReadOnly = true;
            this.colBm.Width = 80;
            // 
            // colDw
            // 
            this.colDw.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDw.HeaderText = "单位";
            this.colDw.Name = "colDw";
            this.colDw.ReadOnly = true;
            this.colDw.Width = 40;
            // 
            // colSl
            // 
            this.colSl.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSl.HeaderText = "数量";
            this.colSl.Name = "colSl";
            this.colSl.ReadOnly = true;
            this.colSl.Width = 40;
            // 
            // colDj
            // 
            this.colDj.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDj.HeaderText = "单价";
            this.colDj.Name = "colDj";
            this.colDj.ReadOnly = true;
            this.colDj.Width = 70;
            // 
            // colJe
            // 
            this.colJe.DefaultCellStyle = dataGridViewCellStyle9;
            this.colJe.HeaderText = "金额";
            this.colJe.Name = "colJe";
            this.colJe.ReadOnly = true;
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
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.dgv);
            this.grpDetail.Controls.Add(this.pnlTop);
            this.grpDetail.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpDetail.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetail.Location = new System.Drawing.Point(0, 129);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(595, 295);
            this.grpDetail.TabIndex = 2;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "进货明细";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Controls.Add(this.btnDel);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnDetail);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 17);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(589, 75);
            this.pnlTop.TabIndex = 1;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tjhdTableAdapter = null;
            this.tableAdapterManager1.tjhmxTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = JXC.Datasets.DSJxcTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tjhmxTableAdapter1
            // 
            this.tjhmxTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmJhdXX
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(595, 524);
            this.Text = "进货单详细信息";
            this.Load += new System.EventHandler(this.FrmYuanGongXX_Load);
            this.pnlBottom.ResumeLayout(false);
            this.grpMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMx)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private Button btnClose;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblId;
        private TextBox txtJhdh;
        private TextBox txtLxr;
        private TextBox txtGhsh;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private Label label21;
        private TextBox txtLxdh;
        private Panel pnlBottom;
        private GroupBox grpMaster;
        private DataGridView dgv;
        private GroupBox grpDetail;
        private Panel pnlTop;
        private Button btnNew;
        private Button btnDel;
        private Button btnEdit;
        private Button btnDetail;
        private ContextMenuStrip mnuDgv;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDetail;
        private ToolStripMenuItem mnuDel;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colXh;
        private DataGridViewTextBoxColumn colPm;
        private DataGridViewTextBoxColumn colBm;
        private DataGridViewTextBoxColumn colDw;
        private DataGridViewTextBoxColumn colSl;
        private DataGridViewTextBoxColumn colDj;
        private Datasets.DSJxcTableAdapters.TableAdapterManager tableAdapterManager1;
        private Datasets.DSJxcTableAdapters.tjhmxTableAdapter tjhmxTableAdapter1;
        private BindingSource bdsMx;
        private Label lblHj;
        private Label label5;
        private DataGridViewTextBoxColumn colJe;
    }
}