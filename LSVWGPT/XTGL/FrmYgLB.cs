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

#endregion

namespace LSVWGPT.XTGL
{
    public partial class FrmYgLB : UserControl
    {
        public FrmYgLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        public void Prepare()
        {
            tygTableAdapter1.Fill(dsJckj1.tyg);
        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmYgXX f = new FrmYgXX();
            f.Prepare(EnumNED.NEW, bds, dsJckj1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmYgXX f = new FrmYgXX();
            f.Prepare(EnumNED.EDIT, bds, dsJckj1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmYgXX f = new FrmYgXX();
            f.Prepare(EnumNED.DETAIL, bds, dsJckj1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            Datasets.DSJckj.tygRow r = (Datasets.DSJckj.tygRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.gw);
            if (ClsMSSQL.Exists(cmd, ClsCBCon.ConStrKj))
            {
                ClsMsgBox.Jg("该类别下存在项目无法删除");
                return;
            }
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();
                tygTableAdapter1.Update(dsJckj1.tyg);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }
    }
}