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
        #region 为ComboBox填充下拉选项
        //函数fillCmbs()建立一种机制，即如果界面上有多个ComboBox，则他们的选项填充将分别编写为独立的函数，并在fillCmbs()中调用，而fillCmbs()本身则在Prepare中调用
        private void fillCmbs()
        {
            fillCmbBmlx();
        }
        //fillCmbBmlx中先定义了获取下拉项的SELECT语句，再用该语句获取数据并保存到表变量dt中。 
        private void fillCmbBmlx()
        {
            string cmd = @"
SELECT dm, mc, dmmc FROM voptionxm 
WHERE lbdm = 'bmlb'
ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            //cmbBmlx.DataSource为cmbBmlx设置下拉项的数据来源
            cmbBmlx.DataSource = dt;
            //cmbBmlx.DisplayMember用于设定下拉后显示项的数据列
            cmbBmlx.DisplayMember = "dmmc";
            //cmbBmlx.ValueMember用于设定点击下拉项后返回的数值列
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
                    //按照以r[id].ToString()为名查找具有指定键的树节点，可以选择搜索子节点，返回一个list[]。
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        tn = createANode(r, i);
                        if (tp == null)
                            trV.Nodes.Add(tn);//向trV控件添加节点
                        else
                            tp.Nodes.Add(tn);//向父节点tp中添加节点
                    }
                }
            }
        }
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            
            //使用指定的文本初始化 TreeNode 类的新实例。
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
                ClsMsgBox.Jg("名称不可为空！");
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
                ClsMsgBox.Cw("保存机构信息时遇到了如下错误：", ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckj1.tjigou.RejectChanges();
            //如添加了新结点，则需要删除
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
                ClsMsgBox.Jg("不允许为根结点添加同级结点。");
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
                ClsMsgBox.Jg("机构层次不允许超过5级。");
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
                ClsMsgBox.Jg("本结点为根结点，不允许删除！");
            else if (trV.SelectedNode.HasNodes)
                ClsMsgBox.Jg("本结点不是末端结点，不允许删除！");
            else
                ClsMsgBox.YesNo("确实要删除当前机构吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //删除数据库中的机构记录
                string cmd = string.Format("DELETE FROM tjigou WHERE id = {0}", trV.SelectedNode.Name);
                int rows = ClsMSSQL.ExecuteCmd(cmd, ClsCBCon.ConStrKj);
                if (rows != 1)
                {
                    string s = string.Format("删除机构表命令影响的记录行数{0}不为1。", rows);
                    ClsMsgBox.Cw(s);
                }
                else
                {
                    //删除机构树中的结点
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