#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using LSLib.Classes;
using LSVWGPT.Datasets;

#endregion

namespace LSVWGPT.Controls
{
    //功能树用户控件
    public partial class UCFuncsTree : UserControl
    {

        private ClsFuncs funcs;

        public UCFuncsTree()
        {
            InitializeComponent();
        }

        private void UCFuncsTree_Load(object sender, EventArgs e)
        {

        }

        //类型为TreeViewEventArgs的参数e的Node属性返回当前被操作的trV的结点。
        //只有末端功能结点，即没有下级子节点的功能，才进行功能调用。
        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!e.Node.HasNodes)              
                funcs.Call(Int32.Parse(e.Node.Name), e.Node.Tag.ToString(), e.Node.Text);  //Int32.Parse是一种将串转换为int的方法
        }

        
        //实现控件的初始化任务
        public void Prepare(ClsFuncs aFuncs)
        {
            funcs = aFuncs;
            createFuncTree();
            //判断如果功能树有结点，则将其全部展开，并选中第1个结点。
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
        }
        //该函数实现功能树的创建
        private void createFuncTree()
        {
            //在双引号前的 @符号表示用原始字符定义字符串
            //设计了一个从vfuncsa视图中选择建立功能树所需要信息的SELECT语句。
            //其中的jb > 0条件滤除了根(root)记录。 
            //ORDER BY子句确保取出的记录以正确的顺序排列
            string cmd = @"
SELECT id, mc, bm, jb,
       id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
       id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 
FROM vfuncsa 
WHERE jb > 0
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
            //功能是从Session中获取登录时保存的userRow信息，将其转化为DSJckj.vusersRow类型，这大大方便了有关信息的使用
            DSJckj.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSJckj.vusersRow;
            if (userRow.qx >= 1024)
            {
                //cmd.Split将多行字符串cmd按行分解为字符串数组
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                //将WHERE语句替换为获取为角色分配的功能模块的查询条件
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                cmd = string.Join(Environment.NewLine, cmds);//string.Join将字符串数组链接为一个串
            }
            //从数据库中读取记录保存到dt表变量中
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            //对dt中的行进行遍历
            foreach (DataRow r in dt.Rows)
            {
                //获取当前功能的级别数值
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                //循环依次判断当前功能模块的各上级功能模块结点是否已经创建，如果已经创建则赋值给tp，如果尚未创建则创建。
                for (int i = 1; i <= jb; i++)
                {
                    //用于构造级别i对应的id的视图字段名
                    id = "id" + i;
                    //从trV的所有结点(包括一级结点及所有的各下层子节点)中搜索Name为当前级别模块的id的结点，由于可能存在多个Name相同的结点，返回结果是一个元素类型为TreeNode的数组。
                    //按照以r[id].ToString()为名查找具有指定键的树节点，可以选择搜索子节点，返回一个list[]。
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    //如果tns中有结点，即if(tns.Length > 0)，则只会有一个，将它赋值给tp。
                    if (tns.Length > 0)
                        tp = tns[0];
                    else//否则创建r(模块信息行，包括一个功能模块及其各上级模块的信息)中第i级的模块结点：tn = createANode(r, i);
                    {
                        tn = createANode(r, i);
                        //if (tp == null)，说明当前结点为一级结点，则加到trV的Nodes集合中：trV.Nodes.Add(tn);
                        if (tp == null)
                            trV.Nodes.Add(tn);//向trV控件添加节点
                        else//否则，tp应该是当前结点的父结点，就将当前结点加到tp的Nodes集合中：tp.Nodes.Add(tn);
                            tp.Nodes.Add(tn);//向父节点tp中添加节点
                        tp = tn;
                    }
                }
            }
        }
        private TreeNode createANode(DataRow r, int jb)
        {
            //前3行构造第i级的id、mc和bm对应的视图字段名
            string id = "id" + jb;
            string mc = "mc" + jb;
            string bm = "bm" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            //创建一个TreeNode结点tn，tn显示的文本取模块的mc，Name取模块的id，而模块的bm则保存到tn的Tag对象中。 
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            return tn;
        }
        

        //UCFuncsTree的结点增加双击功能
        private void trV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.HasNodes)
                if (e.Node.IsExpanded)
                    e.Node.Collapse();
                else
                    e.Node.Expand();
        }
    }
}