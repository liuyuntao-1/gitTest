#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using LSLib.Classes;
using JXC.Datasets;

using JXC.Datasets.DSJxcTableAdapters;

#endregion

namespace JXC.JH
{
    public partial class FrmJhmxXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJxc dsJxc1;
        private tjhmxTableAdapter tjhmxTableAdapter1;
        private DataGridView dgv;
        
        
        #endregion
        public FrmJhmxXX()
        {
            InitializeComponent();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJxc1.tjhmx.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断及数据验证
            ClsD.TextBoxTrim(this);
            if (!ClsReg.NaturalNum.IsMatch(txtXh.Text))
            {
                ClsMsgBox.Jg("序号必须为整数！");
                return;
            }
            if (string.IsNullOrEmpty(txtPm.Text))
            {
                ClsMsgBox.Jg("品名不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtBm.Text))
            {
                ClsMsgBox.Jg("编码不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtDw.Text))
            {
                ClsMsgBox.Jg("单位不可为空！");
                return;
            }
            if (!ClsReg.RMB.IsMatch(txtDj.Text))
            {
                ClsMsgBox.Jg("单价数据不正确！");
                return;
            }
            if (!ClsReg.NaturalNum.IsMatch(txtSl.Text))
            {
                ClsMsgBox.Jg("数量必须为整数！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存进货明细时遇到了错误：", ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aNED"></param>
        /// <param name="aBds"></param>
        /// <param name="aDSJckj"></param>
        /// <param name="atygTableAdapter1"></param>
        /// <param name="aDgv"></param>
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJxc aDSJxc,
            tjhmxTableAdapter atjhmxTableAdapter1, int aJhdId = 0, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJxc1 = aDSJxc;
            tjhmxTableAdapter1 = atjhmxTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJxc1.tjhmx);
            if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }
        private void binding()
        {
            this.lblId.DataBindings.Clear();
            this.lblId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtXh.DataBindings.Clear();
            this.txtXh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtPm.DataBindings.Clear();
            this.txtPm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "pm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtBm.DataBindings.Clear();
            this.txtBm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtDw.DataBindings.Clear();
            this.txtDw.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dw", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtDj.DataBindings.Clear();
            this.txtDj.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dj", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtSl.DataBindings.Clear();
            this.txtSl.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "sl", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.lblJe.DataBindings.Clear();
            this.lblJe.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "je", true,
                DataSourceUpdateMode.OnValidation));
        }

        private void fillCmbs()
        {
            //fillCmbJigou();
           
            fillCmbXb();
            fillCmbRole();
            fillCmbGw();
            fillCmbXl();
            fillCmbZt(); ;
        }
        private void fillCmbJgTree(TreeView trV)
        {
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0, id1, mc1, id2, mc2,
       id3, mc3, id4, mc4, id5, mc5 
FROM vjigoua 
WHERE jb > 0
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string idFld, mcFld;
            foreach (DataRow r in dt.Rows)
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 1; i <= jb; i++)
                {
                    idFld = "id" + i;
                    tns = trV.Nodes.Find(r[idFld].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        mcFld = "mc" + i;
                        tn = new TreeNode(r[idFld].ToString() + ":" + r[mcFld].ToString());
                        tn.Name = r[idFld].ToString();
                        tn.ImageIndex = 0;
                        tn.SelectedImageIndex = 1;
                        if (tp == null)
                            trV.Nodes.Add(tn);
                        else
                            tp.Nodes.Add(tn);
                        tp = tn;
                    }
                }
            }
        }
        //        private void fillCmbJigou()
        //        {
        //            string cmd = @"
        //SELECT id, mc FROM tjigou 
        //ORDER BY mc";
        //            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
        //            cmbJigou.DataSource = dt;
        //            cmbJigou.DisplayMember = "mc";
        //            cmbJigou.ValueMember = "id";
        //        }
        private void fillCmbXb()
        {
            List<ClsBhMcByte> lst = new List<ClsBhMcByte>();
            lst.Add(new ClsBhMcByte(1, "男"));
            lst.Add(new ClsBhMcByte(0, "女"));
            
        }
        private void fillCmbRole()
        {
            string cmd = @"
SELECT id, mc FROM troles 
ORDER BY mc";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            
        }
        private void fillCmbGw()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'gw'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            
        }
        private void fillCmbXl()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'xl'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            
        }
        private void fillCmbZt()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'ryzt'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            
        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmYuanGongXX_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbJgTree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbJigou_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDj_Leave(object sender, EventArgs e)
        {
            if (ClsReg.RMB.IsMatch(txtDj.Text) && ClsReg.NaturalNum.IsMatch(txtSl.Text))
                bds.EndEdit();
        }
    }
}