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
        /// ��ȡ������ɫ�����й���ģ��id
        /// </summary>
        /// <param name="aRoleId"></param>
        /// <returns></returns>
        private List<int> getFuncsList(int aRoleId)
        {
            string cmd = "SELECT funcid FROM trolefuncs WHERE roleid = " + roleId;
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            //ʹ��Linq��DataTable�е�����������funcidת��Ϊһ��������List<int>
            List<int> lst = (from r in dt.AsEnumerable() select r.Field<int>("funcid")).ToList<int>();
            return lst;
        }
        public void Prepare(int aRoleId, string aRoleMc)
        {
            roleId = aRoleId;
            this.Text += "��" + aRoleMc;
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
                    //������r[id].ToString()Ϊ�����Ҿ���ָ���������ڵ㣬����ѡ�������ӽڵ㣬����һ��list[]��
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        tn = createANode(r, i);
                        if (tp == null)
                            trV.Nodes.Add(tn);//��trV�ؼ����ӽڵ�
                        else
                            tp.Nodes.Add(tn);//�򸸽ڵ�tp�����ӽڵ�
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
            tn.CheckBox = CheckBoxVisibility.True;//ʹ�ý��ǰ��ʾ�򹴿�
            tn.Checked = funcsLst.Contains(Convert.ToInt32(r[id]));//��ʾ�����ǰ��ɫ������ǰ���Ĺ��ܣ����ڵ�ǰ���ǰ��
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
        /// �ݹ�ػ�ø����������ѡ�е�ĩ�����ڵ�(������ģ��)��id�б�
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
        #region ExecuteCmd��ִ��SQL����洢���̣�����Ӱ�������
        /// <summary>
        /// <para>ִ��SQL����洢���̣�����Ӱ���������</para>
        /// <para>����ʹ��ArrayList arrLstParams�������������������������Ҳ����������ͣ�</para>
        /// <para>�����߿�ʹ��arrLstParams��ʵ�μ������Ͳ����ķ���ֵ��</para>
        /// <para>����Ǵ洢���̣�����Ҫ����isStProcΪtrue��</para>
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
                if (arrLstParams != null) //�����null����AddRange
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
                    ClsMsgBox.Cw("ExecuteCmd�����˴���", ex);
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
            //�������ѡ�е�ĩ�����ڵ�(������ģ��)��id�б�
            funcsLst.Clear();
            foreach (TreeNode node in trV.Nodes)
                getAllCheckedIds(node);
            //ɾ����ǰ��ɫ��ԭ�еĹ���ģ��
            trolefuncsTableAdapter trolefuncsTableAdapter1 = new trolefuncsTableAdapter();
            trolefuncsTableAdapter1.DeleteByRoleId(roleId);
            //��trolefuncs���в�������ѡ�еĹ���ģ��id
            //����������һ���ɲ��������¼��INSERT���
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