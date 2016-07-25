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
    //�������û��ؼ�
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

        //����ΪTreeViewEventArgs�Ĳ���e��Node���Է��ص�ǰ��������trV�Ľ�㡣
        //ֻ��ĩ�˹��ܽ�㣬��û���¼��ӽڵ�Ĺ��ܣ��Ž��й��ܵ��á�
        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!e.Node.HasNodes)              
                funcs.Call(Int32.Parse(e.Node.Name), e.Node.Tag.ToString(), e.Node.Text);  //Int32.Parse��һ�ֽ���ת��Ϊint�ķ���
        }

        
        //ʵ�ֿؼ��ĳ�ʼ������
        public void Prepare(ClsFuncs aFuncs)
        {
            funcs = aFuncs;
            createFuncTree();
            //�ж�����������н�㣬����ȫ��չ������ѡ�е�1����㡣
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
        }
        //�ú���ʵ�ֹ������Ĵ���
        private void createFuncTree()
        {
            //��˫����ǰ�� @���ű�ʾ��ԭʼ�ַ������ַ���
            //�����һ����vfuncsa��ͼ��ѡ��������������Ҫ��Ϣ��SELECT��䡣
            //���е�jb > 0�����˳��˸�(root)��¼�� 
            //ORDER BY�Ӿ�ȷ��ȡ���ļ�¼����ȷ��˳������
            string cmd = @"
SELECT id, mc, bm, jb,
       id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
       id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 
FROM vfuncsa 
WHERE jb > 0
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
            //�����Ǵ�Session�л�ȡ��¼ʱ�����userRow��Ϣ������ת��ΪDSJckj.vusersRow���ͣ����󷽱����й���Ϣ��ʹ��
            DSJckj.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSJckj.vusersRow;
            if (userRow.qx >= 1024)
            {
                //cmd.Split�������ַ���cmd���зֽ�Ϊ�ַ�������
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                //��WHERE����滻Ϊ��ȡΪ��ɫ����Ĺ���ģ��Ĳ�ѯ����
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                cmd = string.Join(Environment.NewLine, cmds);//string.Join���ַ�����������Ϊһ����
            }
            //�����ݿ��ж�ȡ��¼���浽dt�������
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            //��dt�е��н��б���
            foreach (DataRow r in dt.Rows)
            {
                //��ȡ��ǰ���ܵļ�����ֵ
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                //ѭ�������жϵ�ǰ����ģ��ĸ��ϼ�����ģ�����Ƿ��Ѿ�����������Ѿ�������ֵ��tp�������δ�����򴴽���
                for (int i = 1; i <= jb; i++)
                {
                    //���ڹ��켶��i��Ӧ��id����ͼ�ֶ���
                    id = "id" + i;
                    //��trV�����н��(����һ����㼰���еĸ��²��ӽڵ�)������NameΪ��ǰ����ģ���id�Ľ�㣬���ڿ��ܴ��ڶ��Name��ͬ�Ľ�㣬���ؽ����һ��Ԫ������ΪTreeNode�����顣
                    //������r[id].ToString()Ϊ�����Ҿ���ָ���������ڵ㣬����ѡ�������ӽڵ㣬����һ��list[]��
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    //���tns���н�㣬��if(tns.Length > 0)����ֻ����һ����������ֵ��tp��
                    if (tns.Length > 0)
                        tp = tns[0];
                    else//���򴴽�r(ģ����Ϣ�У�����һ������ģ�鼰����ϼ�ģ�����Ϣ)�е�i����ģ���㣺tn = createANode(r, i);
                    {
                        tn = createANode(r, i);
                        //if (tp == null)��˵����ǰ���Ϊһ����㣬��ӵ�trV��Nodes�����У�trV.Nodes.Add(tn);
                        if (tp == null)
                            trV.Nodes.Add(tn);//��trV�ؼ���ӽڵ�
                        else//����tpӦ���ǵ�ǰ���ĸ���㣬�ͽ���ǰ���ӵ�tp��Nodes�����У�tp.Nodes.Add(tn);
                            tp.Nodes.Add(tn);//�򸸽ڵ�tp����ӽڵ�
                        tp = tn;
                    }
                }
            }
        }
        private TreeNode createANode(DataRow r, int jb)
        {
            //ǰ3�й����i����id��mc��bm��Ӧ����ͼ�ֶ���
            string id = "id" + jb;
            string mc = "mc" + jb;
            string bm = "bm" + jb;
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
            //����һ��TreeNode���tn��tn��ʾ���ı�ȡģ���mc��Nameȡģ���id����ģ���bm�򱣴浽tn��Tag�����С� 
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            return tn;
        }
        

        //UCFuncsTree�Ľ������˫������
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