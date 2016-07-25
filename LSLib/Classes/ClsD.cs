using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLib.Classes
{
    public class ClsD
    {
        //TextBoxTrim接受一个类型为Control的参数，实际传入的应该是窗体Form(或其子类)、UserControl(或其子类)、GroupBox以及Panel等容器类的对象。
        public static void TextBoxTrim(Control ctrl)
        {
            //foreach循环遍历ctrl的Controls对象集合
            foreach (Control c in ctrl.Controls)
            {
                //判断如果Controls控件中有GroupBox类的控件，则进行递归TextBoxTrim(c); (函数调用自身)
                if (c is GroupBox)
                    TextBoxTrim(c);                
                else if (c is TextBox)//判断如果Controls控件中有TextBox类的控件，则对其Text施行Trim()操作，该操作去除串首尾的空格。
                {
                    TextBox t = (TextBox)c;
                    t.Text = t.Text.Trim();
                }
            }
        }
        #region SetMaxLength设置最大长度
        /// <summary>
        /// 为窗体上所有的绑定了system.string类型的数据表字段的textbox根据字段最大长度设置maxlength，
        /// 支持GroupBox的递归.
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="tbl"></param>
        public static void SetMaxLength(Control ctrl, DataTable tbl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is GroupBox)
                    SetMaxLength(c, tbl);
                else if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if (t.Enabled && !t.ReadOnly)
                        if (t.DataBindings["Text"] != null)//判断TextBox绑定了字段
                        {
                            string fld = t.DataBindings["text"].BindingMemberInfo.BindingField;//获得绑定字段的名字
                            //判断绑定字段的类型为System.String，
                            if (String.Compare(tbl.Columns[fld].DataType.ToString(), "System.String", true) == 0)
                            {
                                //以数据集表定义的列（即字段）的最大长度（该数值是从数据库中取得的）设定TextBox的MaxLength
                                t.MaxLength = tbl.Columns[fld].MaxLength;
                            }
                        }
                }
            }
        }
        #endregion

        #region TurnDgvToBdsCurrRecdgv在新增记录时如果页数大于1则可以跳转到新增的记录的所在页
        public static void TurnDgvToBdsCurrRec(DataGridView dgv)
        {
            BindingSource bds = (BindingSource)dgv.DataSource;
            if (bds.Position == -1)
                return;
            //Math.Ceiling函数获取大于等于函数参数的最小整数
            int page = (int)Math.Ceiling(bds.Position / (decimal)dgv.ItemsPerPage);
            dgv.CurrentPage = page;
            //将当前记录显示在可见的DataGridView区域内
            dgv.FirstDisplayedScrollingRowIndex = bds.Position;
        }
        #endregion
    }
}
