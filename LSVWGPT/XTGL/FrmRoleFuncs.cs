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
using System.Linq;
using System.Collections;
using System.Data.SqlClient;
using LSVWGPT.Datasets.DSJckjTableAdapters;

#endregion

namespace LSVWGPT.XTGL
{
    public partial class FrmRoleFuncs : Form
    {
        private int roleId;
        private List<int> funcsLst;
        public FrmRoleFuncs()
        {
            InitializeComponent();
        }

        

        private void UCFuncsTree_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 获取给定角色的所有功能模块id
        /// </summary>
        /// <param name="aRoleId"></param>
        /// <returns></returns>
        private List<int> getFuncsList(int aRoleId)
        {
            string cmd = "SELECT funcid FROM trolefuncs WHERE roleid = " + roleId;
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            //使用Linq将DataTable中的整数数据列funcid转换为一个更简洁的List<int>
            List<int> lst = (from r in dt.AsEnumerable() select r.Field<int>("funcid")).ToList<int>();
            return lst;
        }
        public void Prepare(int aRoleId, string aRoleMc)
        {
            roleId = aRoleId;
            this.Text += "—" + aRoleMc;
            funcsLst = getFuncsList(roleId);
            createFuncTree();
            trV.ExpandAll();
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
            tn.CheckBox = CheckBoxVisibility.True;//使得结点前显示打勾框
            tn.Checked = funcsLst.Contains(Convert.ToInt32(r[id]));//表示如果当前角色包括当前结点的功能，则在当前结点前打勾
            return tn;
        }
        

        private void trV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.HasNodes)
                if (e.Node.IsExpanded)
                    e.Node.Collapse();
                else
                    e.Node.Expand();
        }

        private void trV_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = e.Node.Checked;
            }
        }
        /// <summary>
        /// 递归地获得给定结点所有选中的末端树节点(即功能模块)的id列表
        /// </summary>
        private void getAllCheckedIds(TreeNode pNode)
        {
            foreach (TreeNode node in pNode.Nodes)
            {
                if (!node.HasNodes && node.Checked)
                {
                    funcsLst.Add(Convert.ToInt32(node.Name));
                }
                getAllCheckedIds(node);
            }
        }
        #region ExecuteCmd：执行SQL语句或存储过程，返回影响的行数
        /// <summary>
        /// <para>执行SQL语句或存储过程，返回影响的行数。</para>
        /// <para>可以使用ArrayList arrLstParams传入参数，参数可以是输入型也可以是输出型，</para>
        /// <para>调用者可使用arrLstParams的实参检查输出型参数的返回值。</para>
        /// <para>如果是存储过程，则需要设置isStProc为true。</para>
        /// </summary>
        /// <param name="aSQLCmd"></param>
        /// <param name="aConStr"></param>
        /// <param name="arrLstParams"></param>
        /// <param name="isStProc"></param>
        public static int ExecuteCmd(string aSQLCmd, string aConStr,
                    ArrayList arrLstParams = null, bool isStProc = false)
        {
            int rows = 0;
            using (SqlConnection conn = new SqlConnection(aConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(aSQLCmd, conn);
                if (arrLstParams != null) //如果是null不能AddRange
                {
                    cmd.Parameters.AddRange(arrLstParams.ToArray(typeof(SqlParameter)));
                }
                if (isStProc)
                    cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Cw("ExecuteCmd遇到了错误：", ex);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return rows;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            //获得所有选中的末端树节点(即功能模块)的id列表
            funcsLst.Clear();
            foreach (TreeNode node in trV.Nodes)
                getAllCheckedIds(node);
            //删除当前角色的原有的功能模块
            trolefuncsTableAdapter trolefuncsTableAdapter1 = new trolefuncsTableAdapter();
            trolefuncsTableAdapter1.DeleteByRoleId(roleId);
            //向trolefuncs表中插入所有选中的功能模块id
            //方法：构造一个可插入多条记录的INSERT语句
            if (funcsLst.Count > 0)
            {
                string[] insLst = funcsLst.ConvertAll(
                    delegate (int n) {
                        string s = roleId + "," + n;
                        return ClsQ.Q0(s, '(');
                    }).ToArray();
                string str = string.Join(",", insLst);
                string sql = "INSERT INTO trolefuncs (roleid, funcid) VALUES " + str;
                ClsMSSQL.ExecuteCmd(sql, ClsCBCon.ConStrKj);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}