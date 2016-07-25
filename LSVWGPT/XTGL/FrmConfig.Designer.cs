using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.XTGL
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.nUDMinPWLen = new Gizmox.WebGUI.Forms.NumericUpDown();
            this.txtPW = new Gizmox.WebGUI.Forms.TextBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnRefresh = new Gizmox.WebGUI.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinPWLen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "最短口令长度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "默认口令";
            // 
            // nUDMinPWLen
            // 
            this.nUDMinPWLen.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.nUDMinPWLen.BackColor = System.Drawing.Color.White;
            this.nUDMinPWLen.CurrentValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDMinPWLen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDMinPWLen.Location = new System.Drawing.Point(163, 115);
            this.nUDMinPWLen.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nUDMinPWLen.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDMinPWLen.Name = "nUDMinPWLen";
            this.nUDMinPWLen.Size = new System.Drawing.Size(120, 21);
            this.nUDMinPWLen.TabIndex = 2;
            this.nUDMinPWLen.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(163, 177);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(120, 20);
            this.txtPW.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(101, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnRefresh.Image"));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(197, 252);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmConfig
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.nUDMinPWLen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(419, 466);
            this.Text = "配置管理";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinPWLen)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nUDMinPWLen;
        private TextBox txtPW;
        private Button btnSave;
        private Button btnRefresh;
    }
}