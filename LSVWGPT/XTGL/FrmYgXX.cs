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
using LSVWGPT.Datasets;
using LSVWGPT.Datasets.DSJckjTableAdapters;
using LSVWGPT.Classes;

#endregion

namespace LSVWGPT.XTGL
{
    public partial class FrmYgXX : Form
    {
        
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJckj dsJckj1;
        private tygTableAdapter tygTableAdapter1;
        private DataGridView dgv;
        #endregion
        public FrmYgXX()
        {
            InitializeComponent();
            fillCmbs();

        }
        #region 为ComboBox填充下拉选项
        private void fillCmbs()
        {
            fillCmbBmlx();
        }
        private void fillCmbBmlx()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'bmlx'";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            cmbJgid.DataSource = dt;
            cmbJgid.DisplayMember = "dmmc";
            cmbJgid.ValueMember = "dm";
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckj1.tyg.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断
            ClsD.TextBoxTrim(this);

            if (string.IsNullOrEmpty(txtXm.Text))
            {
                ClsMsgBox.Jg("所在部门的机构id不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(cmbJgid.Text))
            {
                ClsMsgBox.Jg("所在部门的机构id不可为空！");
                return;
            }

            //if (string.IsNullOrEmpty(cmbXb.Text))
            //{
            //    ClsMsgBox.Jg("性别不可为空！");
            //    return;
            //}
            //if (string.IsNullOrEmpty(chkZt.Text))
            //{
            //    ClsMsgBox.Jg("人员状态不可为空！");
            //    return;
            //}
            
            if (!ClsReg.AlphaNumeric.IsMatch(cmbJgid.Text))
            {
                ClsMsgBox.Jg("所在部门的机构id包含非字母数字字符！");
                return;
            }
            if (!ClsReg.AlphaNumeric.IsMatch(cmbRoleid.Text))
            {
                ClsMsgBox.Jg("角色id包含非字母数字字符！");
                return;
            }


            #endregion



            try
            {
                bds.EndEdit();
                tygTableAdapter1.Update(dsJckj1.tyg);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存员工时遇到了错误：", ex);
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
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJckj aDSJckj,
            tygTableAdapter atygTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJckj1 = aDSJckj;
            tygTableAdapter1 = atygTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJckj1.tyg);
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
            this.txtXm.DataBindings.Clear();
            this.txtXm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xm", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.cmbJgid.DataBindings.Clear();
            this.cmbJgid.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jgid", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.cmbXb.DataBindings.Clear();
            this.cmbXb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xb", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.cmbGw.DataBindings.Clear();
            this.cmbGw.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "gw", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.cmbXl.DataBindings.Clear();
            this.cmbXl.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xl", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.cmbRoleid.DataBindings.Clear();
            this.cmbRoleid.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "roleid", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.cmbZt.DataBindings.Clear();
            this.cmbZt.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "zt", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.chkActive.DataBindings.Clear();
            this.chkActive.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "active", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.dtpRzrq.DataBindings.Clear();
            this.dtpRzrq.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "rzrq", true,
                DataSourceUpdateMode.OnPropertyChanged));

            this.dtpLzrq.DataBindings.Clear();
            this.dtpLzrq.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "lzrq", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        private void FrmRolesXX_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpRzrq_Click(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkZt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpLzrq_Click(object sender, EventArgs e)
        {

        }
    }
}