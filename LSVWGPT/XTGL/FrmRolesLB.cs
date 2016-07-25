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

#endregion

namespace LSVWGPT.XTGL
{
    public partial class FrmRolesLB : UserControl
    {
        public FrmRolesLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        public void Prepare()
        {
            trolesTableAdapter1.Fill(dsJckj1.troles);
        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.NEW, bds, dsJckj1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.EDIT, bds, dsJckj1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.DETAIL, bds, dsJckj1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            Datasets.DSJckj.trolesRow r = (Datasets.DSJckj.trolesRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            if (ClsMSSQL.Exists(cmd, ClsCBCon.ConStrKj))
            {
                ClsMsgBox.Jg("������´�����Ŀ�޷�ɾ��");
                return;
            }
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();
                trolesTableAdapter1.Update(dsJckj1.troles);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void btnFuncs_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmRoleFuncs f = new FrmRoleFuncs();
            DSJckj.trolesRow r = (DSJckj.trolesRow)(((DataRowView)bds.Current).Row);
            f.Prepare(r.id, r.mc);
            f.ShowDialog();
        }
    }
}