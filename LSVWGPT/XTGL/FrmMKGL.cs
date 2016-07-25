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
    //模块管理
    //加载到TabPage中的界面必须是父类为UserControl的“窗体”，其实就是用户控件。
    public partial class FrmMKGL : UserControl
    {
        //在FrmMKGL的开始增加一个名字为rootId的私有成员
        private int rootId;
        public FrmMKGL()
        {
            InitializeComponent();
            
        }

        private void FrmMKGL_Load(object sender, EventArgs e)
        {
            Prepare();
        }

        //实现控件的初始化任务
        public void Prepare()
        {
            string cmd = "SELECT id FROM tfuncs WHERE bm = 'root'";
            //在Prepare函数中添加为rootId获取值的代码
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
            string bm = "bm" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            return tn;
        }

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                //通过当前选中结点的Name获取对应模块在tfuncs表中的id值。
                int id = Int32.Parse(e.Node.Name);
                //调用tfuncsTableAdapter1的FillById方法向dsJckj1.tfuncs表对象中填入指定id的一条记录。
                tfuncsTableAdapter1.FillById(dsJckj1.tfuncs, id);
            }
        }
        
        
        

        private void txtBm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //以认可方式结束编辑状态。
            bds.EndEdit();
            //将所有的TextBox控件进行去首尾空格操作。
            ClsD.TextBoxTrim(grpMain);
            if (string.IsNullOrEmpty(txtXh.Text))
            {
                ClsMsgBox.Jg("序号不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("名称不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtBm.Text))
            {
                ClsMsgBox.Jg("编码不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtJb.Text))
            {
                ClsMsgBox.Jg("级别不可为空！");
                return;
            }
            try
            {
                //将dsJckj1.tfuncs中的内容，即用户编辑修改的内容写入到SQL Server数据库中。
                tfuncsTableAdapter1.Update(dsJckj1.tfuncs);
                //该语句在新增模块后将tfuncsTableAdapter1.Update返回（因为设配置了“刷新数据表”）的id值(该id值通过bds的绑定赋给了lblId.Text)赋给新增模块对应结点的Name属性。
                trV.Name = lblId.Text;
                trV.SelectedNode.Text = txtMc.Text;
                trV.SelectedNode.Tag = txtBm.Text;
                //语句解除对不允许trV点击操作的限制
                if (!trV.Enabled)
                    trV.Enabled = true;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存模块信息时遇到了如下错误：", ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //以取消方式结束编辑状态。
            bds.CancelEdit();
            //将暂存到dsJckj1.tfuncs中尚未写入数据库的内容恢复到编辑修改之前的值。
            dsJckj1.tfuncs.RejectChanges();
            //如添加了新结点，则需要删除
            //增加了if(!trV.Enabled)程序段用于处理新增模块后点击取消按钮的行为。
            if (!trV.Enabled)
            {
                TreeNode tn = trV.SelectedNode;
                TreeNode tm = tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                trV.SelectedNode = tm;
                tn.Parent.Nodes.Remove(tn); //是移除结点的程序语句
                trV.Enabled = true;
            }
        }

        private void mnuNewBrother_Click(object sender, EventArgs e)
        {
            //保证在新模块的信息输入未保存或取消前，用户不能点击模块树中的结点。
            trV.Enabled = false;
            //创建一个新的结点，Text值预设为“”号。
            TreeNode tn = new TreeNode("*");

            if (trV.SelectedNode.Level == 0)
                trV.Nodes.Add(tn);
            else
                trV.SelectedNode.Parent.Nodes.Add(tn);
            trV.SelectedNode = tn; //结点设为当前的选中结点。
            dsJckj1.tfuncs.Rows.Clear(); //清除tfuncs表中已经加入的数据。
            //先用bds.AddNew()为dsJckj1.tfuncs表添加一行，而(DSJckj.tfuncsRow)((DataRowView)bds.AddNew()).Row获取新加的行对象，该行对象是DSJckj.tfuncsRow类型的。 
            DSJckj.tfuncsRow r = (DSJckj.tfuncsRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level + 1); //以结点在树中的层级level给r.jb赋值
            //使用三元运算符给r.pid赋值，如果结点为第0层，则赋rootId，否则赋父结点的id，该id在创建结点时已经存到了结点的Name属性中。
            r.pid = tn.Level == 0 ? rootId : Int32.Parse(tn.Parent.Name);
        }

        private void mnuNewChild_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 4)
            {
                ClsMsgBox.Jg("模块层次不允许超过5级。");
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
            //首先用trV.SelectedNode.HasNodes判断当前结点如果含有下级结点，则不执行删除操作。
            if (trV.SelectedNode.HasNodes)
                ClsMsgBox.Jg("本结点不是末端结点，不允许删除！");
            else
                ClsMsgBox.YesNo("确实要删除当前模块吗？", deleting);//使用回调函数deleting处理点击按钮后的程序行为
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //删除数据库中的模块记录
                string cmd = string.Format("DELETE FROM tfuncs WHERE id = {0}", trV.SelectedNode.Name);
                int rows = ClsMSSQL.ExecuteCmd(cmd, ClsCBCon.ConStrKj);
                if (rows != 1)
                {
                    string s = string.Format("删除模块表命令影响的记录行数{0}不为1。", rows);
                    ClsMsgBox.Cw(s);
                }
                else
                {
                    //删除模块树中的结点
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