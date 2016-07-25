using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace LSVWGPT.XTGL
{
    partial class FrmRoleFuncs
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoleFuncs));
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // trV
            // 
            this.trV.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.trV.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trV.ImageKey = "Folders.Folder_yellow_close_16.ico1";
            this.trV.ImageList = this.imgLst;
            this.trV.Location = new System.Drawing.Point(0, 0);
            this.trV.Name = "trV";
            this.trV.SelectedImageKey = "Folders.Folder_yellow_open_16.ico";
            this.trV.Size = new System.Drawing.Size(270, 470);
            this.trV.TabIndex = 0;
            this.trV.NodeMouseDoubleClick += new Gizmox.WebGUI.Forms.TreeNodeMouseClickEventHandler(this.trV_NodeMouseDoubleClick);
            this.trV.AfterCheck += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterCheck);
            // 
            // imgLst
            // 
            this.imgLst.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images1"))});
            this.imgLst.ImageSize = new System.Drawing.Size(8, 8);
            this.imgLst.Images.SetKeyName(0, "Folders.Folder_yellow_close_16.ico1");
            this.imgLst.Images.SetKeyName(1, "Folders.Folder_yellow_open_16.ico");
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(292, 224);
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
            this.btnSave.Location = new System.Drawing.Point(292, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmRoleFuncs
            // 
            this.AcceptButton = this.btnSave;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.trV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(427, 470);
            this.Text = "角色功能设置";
            this.Load += new System.EventHandler(this.UCFuncsTree_Load);
            this.ResumeLayout(false);

        }


        #endregion
        private ImageList imgLst;
        public TreeView trV;
        private Button btnClose;
        private Button btnSave;
    }
}