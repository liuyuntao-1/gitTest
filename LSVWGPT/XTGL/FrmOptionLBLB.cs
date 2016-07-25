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
        //lbRow指向toptionlb表的当前记录，由于是一个强类型化的对象，可以用数据库中的字段名引用其中各字段的值。
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
            //以EnumNED.NEW(新增)方式调用FrmOptionLBXX窗体。
            f.Prepare(EnumNED.NEW, bds, dsJckj1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //如果toptionlb表为空，即bds.Current == null，则没有记录可以编辑，因而程序返回
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            //以EnumNED.EDIT(编辑)方式调用FrmOptionLBXX窗体
            f.Prepare(EnumNED.EDIT, bds, dsJckj1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            //以EnumNED.DETAIL(详细)方式调用FrmOptionLBXX窗体。
            f.Prepare(EnumNED.DETAIL, bds, dsJckj1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            //获取当前记录，注意使用了数据集中toptionlb表的强类型行类toptionlbRow变量r
            Datasets.DSJckj.toptionlbRow r = (Datasets.DSJckj.toptionlbRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            //ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj)判断如果当前选项类别有选项，则不执行删除操作
            if (ClsMSSQL.Exists(cmd, ClsCBCon.ConStrKj))
            {
                ClsMsgBox.Jg("该类别下存在项目无法删除");
                return;
            }
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);//使用回调函数deleting对删除操作进行确认询问
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();//将当前记录从VS的数据集表dsJckj1.toptionlb中删除
                toptionlbTableAdapter1.Update(dsJckj1.toptionlb);//执行从数据库中删除的操作
                ClsD.TurnDgvToBdsCurrRec(dgv);//定位正确的活动页，因为删除一条记录可能导致dgv总页数比原来少一页
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //如果toptionlb表为空，即bds.Current == null，则置lbRow为null，直接返回。
            if (bds.Current == null)
            {
                lbRow = null;
                return;
            }
            lbRow = (Datasets.DSJckj.toptionlbRow)(((DataRowView)bds.Current).Row);//否则获取toptionlb表的当前行
            //自上一次调用 AcceptChanges 之后，该行未更改。
            //该句的作用是防止在toptionlb中增加或删除记录时, 
            //执行到里面的r.dm和r.mc的赋值语句时因r对应的东西为null，而报错
            //如果当前行不是新增的行，即lbRow.RowState == DataRowState.Unchanged
            if (lbRow.RowState == DataRowState.Unchanged)
            {
                //向toptionxm表中填入当前选项类别代码，即lbRow.dm，对应的记录
                toptionxmTableAdapter1.FillByLbdm(dsJckj1.toptionxm, lbRow.dm);
            }
            else
                //此句是清空toptionxm表中此前装入的对应其他选项类别的选项项目
                dsJckj1.toptionxm.Clear();
        }

        private void btnNewXM_Click(object sender, EventArgs e)
        {
            //类别表为空时不执行本操作
            //增加了对类别表为空的判断
            if (bds.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.NEW, bdsXM, dsJckj1, toptionxmTableAdapter1, dgvXM, lbRow.dm);
            f.ShowDialog();
        }

        private void btnEditXM_Click(object sender, EventArgs e)
        {
            //类别表为空时不执行本操作
            if (bds.Current == null)
                return;
            //数据表为空时不执行本操作
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.EDIT, bdsXM, dsJckj1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDetailXM_Click(object sender, EventArgs e)
        {
            //列表表为空时不执行本操作
            if (bds.Current == null)
                return;
            //数据表为空时不执行本操作
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.DETAIL, bdsXM, dsJckj1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDelXM_Click(object sender, EventArgs e)
        {
            //列表表为空时不执行本操作
            if (bds.Current == null)
                return;
            //数据表为空时不执行本操作
            if (bdsXM.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deletingXM);
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