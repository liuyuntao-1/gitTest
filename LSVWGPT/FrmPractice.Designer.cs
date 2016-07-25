using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT
{
    partial class FrmPractice
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
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.btnClear = new Gizmox.WebGUI.Forms.Button();
            this.txtA = new Gizmox.WebGUI.Forms.TextBox();
            this.btnTest = new Gizmox.WebGUI.Forms.Button();
            this.tcA = new Gizmox.WebGUI.Forms.TabControl();
            this.tpLst = new Gizmox.WebGUI.Forms.TabPage();
            this.lst = new Gizmox.WebGUI.Forms.ListBox();
            this.tpDgv = new Gizmox.WebGUI.Forms.TabPage();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcA)).BeginInit();
            this.tcA.SuspendLayout();
            this.tpLst.SuspendLayout();
            this.tpDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Linen;
            this.pnlTop.Controls.Add(this.btnClear);
            this.pnlTop.Controls.Add(this.txtA);
            this.pnlTop.Controls.Add(this.btnTest);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(419, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(166, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Çå³ý";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("ËÎÌå", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(40, 47);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(333, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "hello";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("ËÎÌå", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(40, 9);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "²âÊÔ";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tcA
            // 
            this.tcA.Controls.Add(this.tpLst);
            this.tcA.Controls.Add(this.tpDgv);
            this.tcA.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcA.Location = new System.Drawing.Point(0, 100);
            this.tcA.Name = "tcA";
            this.tcA.SelectedIndex = 0;
            this.tcA.Size = new System.Drawing.Size(419, 366);
            this.tcA.TabIndex = 1;
            // 
            // tpLst
            // 
            this.tpLst.Controls.Add(this.lst);
            this.tpLst.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpLst.Location = new System.Drawing.Point(4, 22);
            this.tpLst.Name = "tpLst";
            this.tpLst.Size = new System.Drawing.Size(411, 340);
            this.tpLst.TabIndex = 0;
            this.tpLst.Text = "Lst";
            // 
            // lst
            // 
            this.lst.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.lst.Location = new System.Drawing.Point(3, 3);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(411, 329);
            this.lst.TabIndex = 0;
            // 
            // tpDgv
            // 
            this.tpDgv.Controls.Add(this.dgv);
            this.tpDgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpDgv.Location = new System.Drawing.Point(4, 22);
            this.tpDgv.Name = "tpDgv";
            this.tpDgv.Size = new System.Drawing.Size(411, 340);
            this.tpDgv.TabIndex = 0;
            this.tpDgv.Text = "Dgv";
            // 
            // dgv
            // 
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(405, 334);
            this.dgv.TabIndex = 0;
            // 
            // FrmPractice
            // 
            this.Controls.Add(this.tcA);
            this.Controls.Add(this.pnlTop);
            this.Size = new System.Drawing.Size(419, 466);
            this.Text = "FrmPractice";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcA)).EndInit();
            this.tcA.ResumeLayout(false);
            this.tpLst.ResumeLayout(false);
            this.tpDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel pnlTop;
        private TextBox txtA;
        private Button btnTest;
        private TabControl tcA;
        private TabPage tpLst;
        private ListBox lst;
        private TabPage tpDgv;
        private DataGridView dgv;
        private Button btnClear;
    }
}