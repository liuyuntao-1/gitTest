using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.XTGL
{
    partial class FrmYgXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYgXX));
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.cmbJgid = new Gizmox.WebGUI.Forms.ComboBox();
            this.comboBox2 = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbXb = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbGw = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbXl = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbRoleid = new Gizmox.WebGUI.Forms.ComboBox();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.dtpRzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.dtpLzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.txtXm = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbZt = new Gizmox.WebGUI.Forms.ComboBox();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.comboBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "机构id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(174, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(323, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(102, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(178, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "岗位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "角色id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "学历";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "入职日期";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "离职日期";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbJgid
            // 
            this.cmbJgid.FormattingEnabled = true;
            this.cmbJgid.Location = new System.Drawing.Point(128, 78);
            this.cmbJgid.Name = "cmbJgid";
            this.cmbJgid.Size = new System.Drawing.Size(121, 21);
            this.cmbJgid.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Controls.Add(this.cmbXb);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(128, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // cmbXb
            // 
            this.cmbXb.FormattingEnabled = true;
            this.cmbXb.Location = new System.Drawing.Point(0, 0);
            this.cmbXb.Name = "cmbXb";
            this.cmbXb.Size = new System.Drawing.Size(121, 21);
            this.cmbXb.TabIndex = 3;
            // 
            // cmbGw
            // 
            this.cmbGw.FormattingEnabled = true;
            this.cmbGw.Location = new System.Drawing.Point(323, 43);
            this.cmbGw.Name = "cmbGw";
            this.cmbGw.Size = new System.Drawing.Size(121, 21);
            this.cmbGw.TabIndex = 6;
            // 
            // cmbXl
            // 
            this.cmbXl.FormattingEnabled = true;
            this.cmbXl.Location = new System.Drawing.Point(323, 78);
            this.cmbXl.Name = "cmbXl";
            this.cmbXl.Size = new System.Drawing.Size(121, 21);
            this.cmbXl.TabIndex = 7;
            // 
            // cmbRoleid
            // 
            this.cmbRoleid.FormattingEnabled = true;
            this.cmbRoleid.Location = new System.Drawing.Point(323, 112);
            this.cmbRoleid.Name = "cmbRoleid";
            this.cmbRoleid.Size = new System.Drawing.Size(121, 21);
            this.cmbRoleid.TabIndex = 8;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(128, 191);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(50, 17);
            this.chkActive.TabIndex = 5;
            this.chkActive.Text = "活动";
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // dtpRzrq
            // 
            this.dtpRzrq.CustomFormat = "";
            this.dtpRzrq.Location = new System.Drawing.Point(323, 148);
            this.dtpRzrq.Name = "dtpRzrq";
            this.dtpRzrq.Size = new System.Drawing.Size(121, 21);
            this.dtpRzrq.TabIndex = 9;
            this.dtpRzrq.Click += new System.EventHandler(this.dtpRzrq_Click);
            // 
            // dtpLzrq
            // 
            this.dtpLzrq.CustomFormat = "";
            this.dtpLzrq.Location = new System.Drawing.Point(323, 186);
            this.dtpLzrq.Name = "dtpLzrq";
            this.dtpLzrq.Size = new System.Drawing.Size(121, 21);
            this.dtpLzrq.TabIndex = 10;
            this.dtpLzrq.Click += new System.EventHandler(this.dtpLzrq_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "姓名";
            // 
            // txtXm
            // 
            this.txtXm.Location = new System.Drawing.Point(128, 43);
            this.txtXm.Name = "txtXm";
            this.txtXm.Size = new System.Drawing.Size(121, 20);
            this.txtXm.TabIndex = 1;
            // 
            // cmbZt
            // 
            this.cmbZt.FormattingEnabled = true;
            this.cmbZt.Location = new System.Drawing.Point(128, 148);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.Size = new System.Drawing.Size(121, 21);
            this.cmbZt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "人员状态";
            // 
            // FrmYgXX
            // 
            this.AcceptButton = this.btnSave;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbZt);
            this.Controls.Add(this.txtXm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpLzrq);
            this.Controls.Add(this.dtpRzrq);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cmbXl);
            this.Controls.Add(this.cmbRoleid);
            this.Controls.Add(this.cmbGw);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbJgid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(580, 317);
            this.Text = "员工详细信息";
            this.Load += new System.EventHandler(this.FrmRolesXX_Load);
            this.comboBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Label label1;
        private Label label2;
        private Button btnSave;
        private Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private ComboBox cmbJgid;
        private ComboBox comboBox2;
        private ComboBox cmbXb;
        private ComboBox cmbGw;
        private ComboBox cmbXl;
        private ComboBox cmbRoleid;
        private CheckBox chkActive;
        private DateTimePicker dtpRzrq;
        private DateTimePicker dtpLzrq;
        private Label label10;
        private TextBox txtXm;
        private ComboBox cmbZt;
        private Label label4;
    }
}