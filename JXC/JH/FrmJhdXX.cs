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
    public partial class FrmJhdXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJxc dsJxc1;
        private tjhdTableAdapter tjhdTableAdapter1;
        private DataGridView dgvMaster;


        #endregion
        public FrmJhdXX()
        {
            InitializeComponent();


        }

        private void initMx()
        {
            tableAdapterManager1.tjhdTableAdapter = tjhdTableAdapter1;
            tableAdapterManager1.tjhmxTableAdapter = tjhmxTableAdapter1;
            this.tjhdTableAdapter1.Connection.ConnectionString = ClsCBCon.ConStrJxc;
            this.tjhmxTableAdapter1.Connection.ConnectionString = ClsCBCon.ConStrJxc;
            bdsMx.DataSource = bds;
            bdsMx.DataMember = "FK_tjhmx_tjhd";
            if (NED != EnumNED.NEW)
            {
                tjhmxTableAdapter1.FillByJhdId(dsJxc1.tjhmx, Int32.Parse(lblId.Text));
            }
        }
        private void bindDgv()
        {
            dgv.DataSource = bdsMx;
            colId.DataPropertyName = "id";
            colXh.DataPropertyName = "xh";
            colPm.DataPropertyName = "pm";
            colBm.DataPropertyName = "bm";
            colDw.DataPropertyName = "dw";
            colSl.DataPropertyName = "sl";
            colDj.DataPropertyName = "dj";

            colJe.DataPropertyName = "je";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJxc1.tjhd.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断及数据验证
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtJhdh.Text))
            {
                ClsMsgBox.Jg("进货单号不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtGhsh.Text))
            {
                ClsMsgBox.Jg("供货商不可为空！");
                return;
            }

            #endregion
            try
            {
                bds.EndEdit();
                tableAdapterManager1.UpdateAll(dsJxc1); 
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgvMaster);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存进货单时遇到了错误：", ex);
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
            tjhdTableAdapter atjhdTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            tjhdTableAdapter1 = atjhdTableAdapter1;
            binding();
            NED = aNED;
            dsJxc1 = aDSJxc;
            dgvMaster = aDgv;
            initMx();
            bindDgv();

            ClsD.SetMaxLength(this, dsJxc1.tjhd);
            if (NED == EnumNED.NEW)
            {
                bds.AddNew();

            }
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }
        private void binding()
        {
            this.lblId.DataBindings.Clear();
            this.lblId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtJhdh.DataBindings.Clear();
            this.txtJhdh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jhdh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtGhsh.DataBindings.Clear();
            this.txtGhsh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "ghsh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtLxr.DataBindings.Clear();
            this.txtLxr.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "lxr", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtLxdh.DataBindings.Clear();
            this.txtLxdh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "lxdh", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.lblHj.DataBindings.Clear();
            this.lblHj.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "hj", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        private void fillCmbs()
        {


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

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bdsMx.Current == null)
                return;
            FrmJhmxXX f = new FrmJhmxXX();

            f.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lblId.Text.Trim()))
            {
                ClsMsgBox.Ts("");
                return;
            }
            int tryint;
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.NEW, bdsMx, dsJxc1, tjhmxTableAdapter1,
                Convert.ToInt32(lblId.Text), dgv);
            f.ShowDialog();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bdsMx.Current == null)
                return;

            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bdsMx.RemoveCurrent();
                tjhdTableAdapter1.Update(dsJxc1.tjhd);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bdsMx.Current == null)
                return;
            FrmJhmxXX f = new FrmJhmxXX();

            f.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}