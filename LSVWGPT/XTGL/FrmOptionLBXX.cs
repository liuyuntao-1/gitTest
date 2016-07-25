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
    public partial class FrmOptionLBXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJckj dsJckj1;
        private toptionlbTableAdapter toptionlbTableAdapter1;
        private DataGridView dgv;
        #endregion
        public FrmOptionLBXX()
        {
            InitializeComponent();
         

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckj1.toptionlb.RejectChanges();//将修改的数据恢复为原来的数据
            this.DialogResult = DialogResult.Cancel;//用于调用函数判断是点击关闭按钮返回的。
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
                toptionlbTableAdapter1.Update(dsJckj1.toptionlb);//保存数据到数据库
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);//如果是新增，则调用ClsD.TurnDgvToBdsCurrRec，确保DataGridView增加了新的一页时，将其设为当前的活动页
                }
                this.DialogResult = DialogResult.OK;//用于调用函数判断是点击保存按钮返回的。
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存选项类别时遇到了错误：", ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aNED"></param>
        /// <param name="aBds"></param>
        /// <param name="aDSJckj"></param>
        /// <param name="atoptionlbTableAdapter1"></param>
        /// <param name="aDgv"></param>
        /// 通过Prepare函数向本窗体传递NED、bds、dsJckj1、toptionlbTableAdapter1、dgv等参数，其中dgv为默认参数，默认值为null
        /// 第一个值是新增的意思，下面判断用，第二个是bds，BindingSource数据源，第三个是DataSource，第四个是个存储过程，第五个dgv
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJckj aDSJckj,
            toptionlbTableAdapter atoptionlbTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();//将字段绑定到控件
            NED = aNED;
            dsJckj1 = aDSJckj;
            toptionlbTableAdapter1 = atoptionlbTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJckj1.toptionlb);//为各TextBox设置最大允许的长度
            //当以新增方式(NED == EnumNED.NEW)调用本窗体时，执行bds.AddNew(); 新增一条记录。
            if (NED == EnumNED.NEW)
            {
                bds.AddNew();
            }
            else if (NED == EnumNED.DETAIL)//当以详细信息方式(NED == EnumNED.DETAIL)调用本窗体时，置this.btnSave.Visible = false;，即允许用户修改控件中的内容，但不能保存
            {
                this.btnSave.Visible = false;
            }
        }
        //binding()函数实现字段的绑定，由于绑定的是调用窗体的bds及数据集和数据表，设计时不可预测，因而用编程绑定
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