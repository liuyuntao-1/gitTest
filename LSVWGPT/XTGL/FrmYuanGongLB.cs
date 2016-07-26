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
    public partial class FrmYuanGongLB : UserControl
    {
        public FrmYuanGongLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        public void Prepare()
        {
            this.dsJckj1.EnforceConstraints = false;
            tjigouTableAdapter1.Fill(dsJckj1.tjigou);
            trolesTableAdapter1.Fill(dsJckj1.troles);
            createTableAndRelation();
            tygTableAdapter1.Fill(dsJckj1.tyg);
        }
        private void createTableAndRelation()
        {
            string cmd;
            cmd = "SELECT dm,mc FROM toptionxm WHERE lbdm='gw' ORDER BY dm";
            DataTable dtGw = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);//ʹ��ClsMSSQL.GetDataTable��ù��ڸ�λ��ѧ��ѡ��ı�dtGw��dtXl
            cmd = "SELECT dm,mc FROM toptionxm WHERE lbdm='xl' ORDER BY dm";
            DataTable dtXl = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);//ʹ��ClsMSSQL.GetDataTable��ù��ڸ�λ��ѧ��ѡ��ı�dtGw��dtXl
            //dsJckj1.Tables.Add����dtGw��dtXl����dsJckj1���ݼ�
            dsJckj1.Tables.Add(dtGw);
            dsJckj1.Tables.Add(dtXl);
            DataRelation rel;
            //new DataRelation������ϵ��������Ҫ3������������ϵ����������С��ӱ����
            rel = new DataRelation("yg_gw", dtGw.Columns["dm"], dsJckj1.tyg.gwColumn);
            //ʹ��dsJckj1.Relations.Add�����ݼ�dsJckj1��ӹ�ϵ
            dsJckj1.Relations.Add(rel);
            rel = new DataRelation("yg_xl", dtXl.Columns["dm"], dsJckj1.tyg.xlColumn);
            dsJckj1.Relations.Add(rel);
            //ʹ�á�dsJckj1.tyg.gwsColumn.Expression =��Ϊ�ֶθ����ʽ
            dsJckj1.tyg.gwsColumn.Expression = "Parent(yg_gw).mc";
            dsJckj1.tyg.xlsColumn.Expression = "Parent(yg_xl).mc";
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.NEW, bds, dsJckj1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.EDIT, bds, dsJckj1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.DETAIL, bds, dsJckj1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);
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