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
    //ģ�����
    //���ص�TabPage�еĽ�������Ǹ���ΪUserControl�ġ����塱����ʵ�����û��ؼ���
    public partial class FrmMKGL : UserControl
    {
        //��FrmMKGL�Ŀ�ʼ����һ������ΪrootId��˽�г�Ա
        private int rootId;
        public FrmMKGL()
        {
            InitializeComponent();
            
        }

        private void FrmMKGL_Load(object sender, EventArgs e)
        {
            Prepare();
        }

        //ʵ�ֿؼ��ĳ�ʼ������
        public void Prepare()
        {
            string cmd = "SELECT id FROM tfuncs WHERE bm = 'root'";
            //��Prepare���������ΪrootId��ȡֵ�Ĵ���
            rootId = Convert.ToInt32(ClsMSSQL.GetValue(cmd, ClsCBCon.ConStrKj));
            createFuncTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
        }

        private void createFuncTree()
        {
            string cmd = @"
SELECT id, mc, bm, jb,
       id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
       id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 
FROM vfuncsa 
WHERE jb > 0
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
                for (int i = 1; i <= jb; i++)
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
            string bm = "bm" + jb;
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            return tn;
        }

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                //ͨ����ǰѡ�н���Name��ȡ��Ӧģ����tfuncs���е�idֵ��
                int id = Int32.Parse(e.Node.Name);
                //����tfuncsTableAdapter1��FillById������dsJckj1.tfuncs�����������ָ��id��һ����¼��
                tfuncsTableAdapter1.FillById(dsJckj1.tfuncs, id);
            }
        }
        
        
        

        private void txtBm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //���Ͽɷ�ʽ�����༭״̬��
            bds.EndEdit();
            //�����е�TextBox�ؼ�����ȥ��β�ո������
            ClsD.TextBoxTrim(grpMain);
            if (string.IsNullOrEmpty(txtXh.Text))
            {
                ClsMsgBox.Jg("��Ų���Ϊ�գ�");
                return;
            }
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("���Ʋ���Ϊ�գ�");
                return;
            }
            if (string.IsNullOrEmpty(txtBm.Text))
            {
                ClsMsgBox.Jg("���벻��Ϊ�գ�");
                return;
            }
            if (string.IsNullOrEmpty(txtJb.Text))
            {
                ClsMsgBox.Jg("���𲻿�Ϊ�գ�");
                return;
            }
            try
            {
                //��dsJckj1.tfuncs�е����ݣ����û��༭�޸ĵ�����д�뵽SQL Server���ݿ��С�
                tfuncsTableAdapter1.Update(dsJckj1.tfuncs);
                //�����������ģ���tfuncsTableAdapter1.Update���أ���Ϊ�������ˡ�ˢ�����ݱ�����idֵ(��idֵͨ��bds�İ󶨸�����lblId.Text)��������ģ���Ӧ����Name���ԡ�
                trV.Name = lblId.Text;
                trV.SelectedNode.Text = txtMc.Text;
                trV.SelectedNode.Tag = txtBm.Text;
                //������Բ�����trV�������������
                if (!trV.Enabled)
                    trV.Enabled = true;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("����ģ����Ϣʱ���������´���", ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //��ȡ����ʽ�����༭״̬��
            bds.CancelEdit();
            //���ݴ浽dsJckj1.tfuncs����δд�����ݿ�����ݻָ����༭�޸�֮ǰ��ֵ��
            dsJckj1.tfuncs.RejectChanges();
            //��������½�㣬����Ҫɾ��
            //������if(!trV.Enabled)��������ڴ�������ģ�����ȡ����ť����Ϊ��
            if (!trV.Enabled)
            {
                TreeNode tn = trV.SelectedNode;
                TreeNode tm = tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                trV.SelectedNode = tm;
                tn.Parent.Nodes.Remove(tn); //���Ƴ����ĳ������
                trV.Enabled = true;
            }
        }

        private void mnuNewBrother_Click(object sender, EventArgs e)
        {
            //��֤����ģ�����Ϣ����δ�����ȡ��ǰ���û����ܵ��ģ�����еĽ�㡣
            trV.Enabled = false;
            //����һ���µĽ�㣬TextֵԤ��Ϊ�����š�
            TreeNode tn = new TreeNode("*");

            if (trV.SelectedNode.Level == 0)
                trV.Nodes.Add(tn);
            else
                trV.SelectedNode.Parent.Nodes.Add(tn);
            trV.SelectedNode = tn; //�����Ϊ��ǰ��ѡ�н�㡣
            dsJckj1.tfuncs.Rows.Clear(); //���tfuncs�����Ѿ���������ݡ�
            //����bds.AddNew()ΪdsJckj1.tfuncs�����һ�У���(DSJckj.tfuncsRow)((DataRowView)bds.AddNew()).Row��ȡ�¼ӵ��ж��󣬸��ж�����DSJckj.tfuncsRow���͵ġ� 
            DSJckj.tfuncsRow r = (DSJckj.tfuncsRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level + 1); //�Խ�������еĲ㼶level��r.jb��ֵ
            //ʹ����Ԫ�������r.pid��ֵ��������Ϊ��0�㣬��rootId�����򸳸�����id����id�ڴ������ʱ�Ѿ��浽�˽���Name�����С�
            r.pid = tn.Level == 0 ? rootId : Int32.Parse(tn.Parent.Name);
        }

        private void mnuNewChild_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 4)
            {
                ClsMsgBox.Jg("ģ���β�������5����");
                return;
            }
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dsJckj1.tfuncs.Rows.Clear();
            DSJckj.tfuncsRow r = (DSJckj.tfuncsRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level + 1);
            r.pid = Int32.Parse(tn.Parent.Name);
        }

        private void mnuDel_Click(object sender, EventArgs e)
        {
            //������trV.SelectedNode.HasNodes�жϵ�ǰ�����������¼���㣬��ִ��ɾ��������
            if (trV.SelectedNode.HasNodes)
                ClsMsgBox.Jg("����㲻��ĩ�˽�㣬������ɾ����");
            else
                ClsMsgBox.YesNo("ȷʵҪɾ����ǰģ����", deleting);//ʹ�ûص�����deleting��������ť��ĳ�����Ϊ
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //ɾ�����ݿ��е�ģ���¼
                string cmd = string.Format("DELETE FROM tfuncs WHERE id = {0}", trV.SelectedNode.Name);
                int rows = ClsMSSQL.ExecuteCmd(cmd, ClsCBCon.ConStrKj);
                if (rows != 1)
                {
                    string s = string.Format("ɾ��ģ�������Ӱ��ļ�¼����{0}��Ϊ1��", rows);
                    ClsMsgBox.Cw(s);
                }
                else
                {
                    //ɾ��ģ�����еĽ��
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

        
    }
}