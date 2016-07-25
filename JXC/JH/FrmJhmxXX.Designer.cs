using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace JXC.JH
{
    partial class FrmJhmxXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJhmxXX));
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDw = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDj = new Gizmox.WebGUI.Forms.TextBox();
            this.txtSl = new Gizmox.WebGUI.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new Gizmox.WebGUI.Forms.Label();
            this.txtBm = new Gizmox.WebGUI.Forms.TextBox();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.lblJe = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(344, 224);
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
            this.btnSave.Location = new System.Drawing.Point(220, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "序号(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "品名(*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "单位(*)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "单价(*)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "数量(*)";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(118, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // txtXh
            // 
            this.txtXh.Location = new System.Drawing.Point(110, 53);
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(121, 20);
            this.txtXh.TabIndex = 1;
            // 
            // txtPm
            // 
            this.txtPm.Location = new System.Drawing.Point(110, 91);
            this.txtPm.Name = "txtPm";
            this.txtPm.Size = new System.Drawing.Size(121, 20);
            this.txtPm.TabIndex = 3;
            // 
            // txtDw
            // 
            this.txtDw.Location = new System.Drawing.Point(313, 53);
            this.txtDw.Name = "txtDw";
            this.txtDw.Size = new System.Drawing.Size(121, 21);
            this.txtDw.TabIndex = 11;
            // 
            // txtDj
            // 
            this.txtDj.Location = new System.Drawing.Point(313, 91);
            this.txtDj.Name = "txtDj";
            this.txtDj.Size = new System.Drawing.Size(121, 21);
            this.txtDj.TabIndex = 12;
            this.txtDj.Leave += new System.EventHandler(this.txtDj_Leave);
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(313, 127);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(121, 21);
            this.txtSl.TabIndex = 13;
            this.txtSl.Leave += new System.EventHandler(this.txtDj_Leave);
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
            this.label21.Location = new System.Drawing.Point(62, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "编码(*)";
            // 
            // txtBm
            // 
            this.txtBm.Location = new System.Drawing.Point(110, 127);
            this.txtBm.Name = "txtBm";
            this.txtBm.Size = new System.Drawing.Size(121, 20);
            this.txtBm.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "金额";
            // 
            // lblJe
            // 
            this.lblJe.AutoSize = true;
            this.lblJe.ForeColor = System.Drawing.Color.DarkRed;
            this.lblJe.Location = new System.Drawing.Point(310, 175);
            this.lblJe.Name = "lblJe";
            this.lblJe.Size = new System.Drawing.Size(35, 13);
            this.lblJe.TabIndex = 6;
            this.lblJe.Text = "je";
            // 
            // FrmJhmxXX
            // 
            this.AcceptButton = this.btnSave;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.lblJe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBm);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtDj);
            this.Controls.Add(this.txtDw);
            this.Controls.Add(this.txtPm);
            this.Controls.Add(this.txtXh);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(487, 303);
            this.Text = "进货明细详细信息";
            this.Load += new System.EventHandler(this.FrmYuanGongXX_Load);
            this.ResumeLayout(false);

        }


        #endregion
        private Button btnClose;
        private Button btnSave;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblId;
        private TextBox txtXh;
        private TextBox txtPm;
        private TextBox txtDw;
        private TextBox txtDj;
        private TextBox txtSl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private Label label21;
        private TextBox txtBm;
        private ImageList imgLst;
        private Label label2;
        private Label lblJe;
    }
}