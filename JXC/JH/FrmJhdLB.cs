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
using JXC.Datasets.DSJxcTableAdapters;

#endregion

namespace JXC.JH
{
    public partial class FrmJhdLB : UserControl
    {
       
        public FrmJhdLB()
        {
            InitializeComponent();
        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        public void Prepare()
        {
            this.dsJxc1.EnforceConstraints = false;
            createTableAndRelation();
            this.tjhdTableAdapter1.Connection.ConnectionString = ClsCBCon.ConStrJxc;
            this.tjhdTableAdapter1.Fill(dsJxc1.tjhd);



        }
        private void createTableAndRelation()
        {
            //string cmd;
            //cmd = "SELECT jhdid, sum(sl*dj) AS hj FROM tjhmx GROUP BY jhdid ORDER BY jhdid";
            //DataTable dtJhdHj = ClsMSSQL.GetDataTable(cmd, ClsCBCon.ConStrJxc);
            //dsJxc1.Tables.Add(dtJhdHj);
            //DataRelation rel;
            //rel = new DataRelation("jhdhj", dtJhdHj.Columns["jhdid"], dsJxc1.tjhd.idColumn);
            //dsJxc1.Relations.Add(rel);
            //dsJxc1.tjhd.hjaColumn.Expression = "Parent(jhdhj).hj";
        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.NEW, bds, dsJxc1, tjhdTableAdapter1, dgv); 

            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.EDIT, bds, dsJxc1, tjhdTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.DETAIL, bds, dsJxc1, tjhdTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;

            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();
                tjhdTableAdapter1.Update(dsJxc1.tjhd);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void pnlTop_Click(object sender, EventArgs e)
        {

        }
    }
}