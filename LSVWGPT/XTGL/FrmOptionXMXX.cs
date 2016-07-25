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
    public partial class FrmOptionXMXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJckj dsJckj1;
        private toptionxmTableAdapter toptionxmTableAdapter1;
        private DataGridView dgv;
        #endregion
        public FrmOptionXMXX()
        {
            InitializeComponent();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckj1.toptionxm.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtDm.Text))
            {
                ClsMsgBox.Jg("代码不可为空！");
                return;
            }
            if (!ClsReg.AlphaNumeric.IsMatch(txtDm.Text))
            {
                ClsMsgBox.Jg("代码包含非字母数字字符！");
                return;
            }
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("名称不可为空！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                toptionxmTableAdapter1.Update(dsJckj1.toptionxm);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存选项项目时遇到了错误：", ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aNED"></param>
        /// <param name="aBds"></param>
        /// <param name="aDSJckj"></param>
        /// <param name="atoptionxmTableAdapter1"></param>
        /// <param name="aDgv"></param>
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJckj aDSJckj,
             toptionxmTableAdapter atoptionxmTableAdapter1,
             DataGridView aDgv = null, string aLbdm = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJckj1 = aDSJckj;
            toptionxmTableAdapter1 = atoptionxmTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJckj1.toptionxm);
            if (NED == EnumNED.NEW)
            {
                //获取新增记录的行
                DSJckj.toptionxmRow r = (DSJckj.toptionxmRow)((DataRowView)bds.AddNew()).Row;
                //为新增的记录赋所属选项类别的代码
                r.lbdm = aLbdm;
            }
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }
        private void binding()
        {
            this.txtDm.DataBindings.Clear();
            this.txtDm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtMc.DataBindings.Clear();
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}