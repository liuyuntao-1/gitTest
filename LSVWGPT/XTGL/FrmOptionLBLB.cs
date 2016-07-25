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
    public partial class FrmOptionLBLB : UserControl
    {
        //lbRowָ��toptionlb��ĵ�ǰ��¼��������һ��ǿ���ͻ��Ķ��󣬿��������ݿ��е��ֶ����������и��ֶε�ֵ��
        private Datasets.DSJckj.toptionlbRow lbRow;
        public FrmOptionLBLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        
        public void Prepare()
        {
            toptionlbTableAdapter1.Fill(dsJckj1.toptionlb);
        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmOptionLBXX f = new FrmOptionLBXX();
            //��EnumNED.NEW(����)��ʽ����FrmOptionLBXX���塣
            f.Prepare(EnumNED.NEW, bds, dsJckj1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //���toptionlb��Ϊ�գ���bds.Current == null����û�м�¼���Ա༭��������򷵻�
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            //��EnumNED.EDIT(�༭)��ʽ����FrmOptionLBXX����
            f.Prepare(EnumNED.EDIT, bds, dsJckj1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            //��EnumNED.DETAIL(��ϸ)��ʽ����FrmOptionLBXX���塣
            f.Prepare(EnumNED.DETAIL, bds, dsJckj1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //��ȡ��ǰ��¼��ע��ʹ�������ݼ���toptionlb���ǿ��������toptionlbRow����r
            Datasets.DSJckj.toptionlbRow r = (Datasets.DSJckj.toptionlbRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            //ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj)�ж������ǰѡ�������ѡ���ִ��ɾ������
            if (ClsMSSQL.Exists(cmd, ClsCBCon.ConStrKj))
            {
                ClsMsgBox.Jg("������´�����Ŀ�޷�ɾ��");
                return;
            }
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);//ʹ�ûص�����deleting��ɾ����������ȷ��ѯ��
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();//����ǰ��¼��VS�����ݼ���dsJckj1.toptionlb��ɾ��
                toptionlbTableAdapter1.Update(dsJckj1.toptionlb);//ִ�д����ݿ���ɾ���Ĳ���
                ClsD.TurnDgvToBdsCurrRec(dgv);//��λ��ȷ�Ļҳ����Ϊɾ��һ����¼���ܵ���dgv��ҳ����ԭ����һҳ
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //���toptionlb��Ϊ�գ���bds.Current == null������lbRowΪnull��ֱ�ӷ��ء�
            if (bds.Current == null)
            {
                lbRow = null;
                return;
            }
            lbRow = (Datasets.DSJckj.toptionlbRow)(((DataRowView)bds.Current).Row);//�����ȡtoptionlb��ĵ�ǰ��
            //����һ�ε��� AcceptChanges ֮�󣬸���δ���ġ�
            //�þ�������Ƿ�ֹ��toptionlb�����ӻ�ɾ����¼ʱ, 
            //ִ�е������r.dm��r.mc�ĸ�ֵ���ʱ��r��Ӧ�Ķ���Ϊnull��������
            //�����ǰ�в����������У���lbRow.RowState == DataRowState.Unchanged
            if (lbRow.RowState == DataRowState.Unchanged)
            {
                //��toptionxm�������뵱ǰѡ�������룬��lbRow.dm����Ӧ�ļ�¼
                toptionxmTableAdapter1.FillByLbdm(dsJckj1.toptionxm, lbRow.dm);
            }
            else
                //�˾������toptionxm���д�ǰװ��Ķ�Ӧ����ѡ������ѡ����Ŀ
                dsJckj1.toptionxm.Clear();
        }

        private void btnNewXM_Click(object sender, EventArgs e)
        {
            //����Ϊ��ʱ��ִ�б�����
            //�����˶�����Ϊ�յ��ж�
            if (bds.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.NEW, bdsXM, dsJckj1, toptionxmTableAdapter1, dgvXM, lbRow.dm);
            f.ShowDialog();
        }

        private void btnEditXM_Click(object sender, EventArgs e)
        {
            //����Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.EDIT, bdsXM, dsJckj1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDetailXM_Click(object sender, EventArgs e)
        {
            //�б��Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.DETAIL, bdsXM, dsJckj1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDelXM_Click(object sender, EventArgs e)
        {
            //�б��Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deletingXM);
        }
        private void deletingXM(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bdsXM.RemoveCurrent();
                toptionxmTableAdapter1.Update(dsJckj1.toptionxm);
                ClsD.TurnDgvToBdsCurrRec(dgvXM);
            }
        }
    }
}