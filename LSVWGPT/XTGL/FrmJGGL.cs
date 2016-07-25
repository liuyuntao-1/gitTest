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
//using LSVWGPT.Classes;
using LSVWGPT.Datasets;

#endregion

namespace LSVWGPT.XTGL
{
    public partial class FrmJGGL : UserControl
    {
        
        public FrmJGGL()
        {
            InitializeComponent();
            Prepare();
        }

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                int id = Int32.Parse(e.Node.Name);
                tjigouTableAdapter1.FillById(dsJckj1.tjigou, id);
            }
        }
        public void Prepare()
        {
            createJgTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
            fillCmbs();
        }
        #region ΪComboBox�������ѡ��
        //����fillCmbs()����һ�ֻ��ƣ�������������ж��ComboBox�������ǵ�ѡ����佫�ֱ��дΪ�����ĺ���������fillCmbs()�е��ã���fillCmbs()��������Prepare�е���
        private void fillCmbs()
        {
            fillCmbBmlx();
        }
        //fillCmbBmlx���ȶ����˻�ȡ�������SELECT��䣬���ø�����ȡ���ݲ����浽�����dt�С� 
        private void fillCmbBmlx()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'bmlb'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            //cmbBmlx.DataSourceΪcmbBmlx�����������������Դ
            cmbBmlx.DataSource = dt;
            //cmbBmlx.DisplayMember�����趨��������ʾ���������
            cmbBmlx.DisplayMember = "dmmc";
            //cmbBmlx.ValueMember�����趨���������󷵻ص���ֵ��
            cmbBmlx.ValueMember = "dm";
        }
        #endregion
        private void createJgTree()
        {
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0,  id1, mc1,  id2, mc2, 
       id3, mc3,  id4, mc4,  id5, mc5
FROM vjigoua 
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            foreach (DataRow r in dt.Rows)
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 0; i <= jb; i++)
                {
                    id = "id" + i;
                    //������r[id].ToString()Ϊ�����Ҿ���ָ���������ڵ㣬����ѡ�������ӽڵ㣬����һ��list[]��
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        tn = createANode(r, i);
                        if (tp == null)
                            trV.Nodes.Add(tn);//��trV�ؼ���ӽڵ�
                        else
                            tp.Nodes.Add(tn);//�򸸽ڵ�tp����ӽڵ�
                    }
                }
            }
        }
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            
            return tn;
        }

        private void txtBm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bds.EndEdit();
            ClsD.TextBoxTrim(grpMain);
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("���Ʋ���Ϊ�գ�");
                txtMc.Focus();
                return;
            }
            try
            {
                tjigouTableAdapter1.Update(dsJckj1.tjigou);
                trV.Name = lblId.Text;
                trV.SelectedNode.Text = txtMc.Text;
                if (!trV.Enabled)
                    trV.Enabled = true;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("���������Ϣʱ���������´���", ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckj1.tjigou.RejectChanges();
            //��������½�㣬����Ҫɾ��
            if (!trV.Enabled)
            {
                TreeNode tn = trV.SelectedNode;
                TreeNode tm = tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                trV.SelectedNode = tm;
                tn.Parent.Nodes.Remove(tn);
                trV.Enabled = true;
            }
        }

        private void mnuNewBrother_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 0)
            {
                ClsMsgBox.Jg("������Ϊ��������ͬ����㡣");
                return;
            }
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Parent.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dsJckj1.tjigou.Rows.Clear();
            DSJckj.tjigouRow r = (DSJckj.tjigouRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level );
            r.pid = Int32.Parse(tn.Parent.Name);
        }

        private void mnuNewChild_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 5)
            {
                ClsMsgBox.Jg("������β�������5����");
                return;
            }
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dsJckj1.tjigou.Rows.Clear();
            DSJckj.tjigouRow r = (DSJckj.tjigouRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level);
            r.pid = Int32.Parse(tn.Parent.Name);
        }

        private void mnuDel_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 0)
                ClsMsgBox.Jg("�����Ϊ����㣬������ɾ����");
            else if (trV.SelectedNode.HasNodes)
                ClsMsgBox.Jg("����㲻��ĩ�˽�㣬������ɾ����");
            else
                ClsMsgBox.YesNo("ȷʵҪɾ����ǰ������", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //ɾ�����ݿ��еĻ�����¼
                string cmd = string.Format("DELETE FROM tjigou WHERE id = {0}", trV.SelectedNode.Name);
                int rows = ClsMSSQL.ExecuteCmd(cmd, ClsCBCon.ConStrKj);
                if (rows != 1)
                {
                    string s = string.Format("ɾ������������Ӱ��ļ�¼����{0}��Ϊ1��", rows);
                    ClsMsgBox.Cw(s);
                }
                else
                {
                    //ɾ���������еĽ��
                    TreeNode tn = trV.SelectedNode;
                    TreeNode tm = tn.NextNode != null ? tn.NextNode :
                        tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                    trV.SelectedNode = tm;
                    if (tn.Level == 0)
                        trV.Nodes.Remove(tn);
                    else
                        tn.Parent.Nodes.Remove(tn);
                }
            }
        }

        private void cmbBmlx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void txtXh_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}