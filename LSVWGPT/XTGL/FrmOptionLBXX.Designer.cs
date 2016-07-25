using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.XTGL
{
    partial class FrmOptionLBXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptionLBXX));
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtDm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMc = new Gizmox.WebGUI.Forms.TextBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "代码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "名称";
            // 
            // txtDm
            // 
            this.txtDm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDm.Location = new System.Drawing.Point(102, 55);
            this.txtDm.Name = "txtDm";
            this.txtDm.Size = new System.Drawing.Size(178, 20);
            this.txtDm.TabIndex = 2;
            // 
            // txtMc
            // 
            this.txtMc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMc.Location = new System.Drawing.Point(102, 116);
            this.txtMc.Name = "txtMc";
            this.txtMc.Size = new System.Drawing.Size(178, 20);
            this.txtMc.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(102, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(202, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmOptionLBXX
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMc);
            this.Controls.Add(this.txtDm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(419, 466);
            this.Text = "选项类别详细信息";
            this.ResumeLayout(false);

        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDm;
        private TextBox txtMc;
        private Button btnSave;
        private Button btnClose;
    }
}