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
using LSVWGPT.Datasets;
using LSVWGPT.Datasets.DSJckjTableAdapters;
using LSVWGPT.Classes;

#endregion

namespace LSVWGPT.XTGL
{
    public partial class FrmOptionLBXX : Form
    {
        #region �Զ����Ա����
        private EnumNED NED;
        private BindingSource bds;
        private DSJckj dsJckj1;
        private toptionlbTableAdapter toptionlbTableAdapter1;
        private DataGridView dgv;
        #endregion
        public FrmOptionLBXX()
        {
            InitializeComponent();
         

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckj1.toptionlb.RejectChanges();//���޸ĵ����ݻָ�Ϊԭ��������
            this.DialogResult = DialogResult.Cancel;//���ڵ��ú����ж��ǵ���رհ�ť���صġ�
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region ��ֵ�ж�
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtDm.Text))
            {
                ClsMsgBox.Jg("���벻��Ϊ�գ�");
                return;
            }
            if (!ClsReg.AlphaNumeric.IsMatch(txtDm.Text))
            {
                ClsMsgBox.Jg("�����������ĸ�����ַ���");
                return;
            }
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("���Ʋ���Ϊ�գ�");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                toptionlbTableAdapter1.Update(dsJckj1.toptionlb);//�������ݵ����ݿ�
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);//����������������ClsD.TurnDgvToBdsCurrRec��ȷ��DataGridView�������µ�һҳʱ��������Ϊ��ǰ�Ļҳ
                }
                this.DialogResult = DialogResult.OK;//���ڵ��ú����ж��ǵ�����水ť���صġ�
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("����ѡ�����ʱ�����˴���", ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aNED"></param>
        /// <param name="aBds"></param>
        /// <param name="aDSJckj"></param>
        /// <param name="atoptionlbTableAdapter1"></param>
        /// <param name="aDgv"></param>
        /// ͨ��Prepare�����򱾴��崫��NED��bds��dsJckj1��toptionlbTableAdapter1��dgv�Ȳ���������dgvΪĬ�ϲ�����Ĭ��ֵΪnull
        /// ��һ��ֵ����������˼�������ж��ã��ڶ�����bds��BindingSource����Դ����������DataSource�����ĸ��Ǹ��洢���̣������dgv
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJckj aDSJckj,
            toptionlbTableAdapter atoptionlbTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();//���ֶΰ󶨵��ؼ�
            NED = aNED;
            dsJckj1 = aDSJckj;
            toptionlbTableAdapter1 = atoptionlbTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJckj1.toptionlb);//Ϊ��TextBox�����������ĳ���
            //����������ʽ(NED == EnumNED.NEW)���ñ�����ʱ��ִ��bds.AddNew(); ����һ����¼��
            if (NED == EnumNED.NEW)
            {
                bds.AddNew();
            }
            else if (NED == EnumNED.DETAIL)//������ϸ��Ϣ��ʽ(NED == EnumNED.DETAIL)���ñ�����ʱ����this.btnSave.Visible = false;���������û��޸Ŀؼ��е����ݣ������ܱ���
            {
                this.btnSave.Visible = false;
            }
        }
        //binding()����ʵ���ֶεİ󶨣����ڰ󶨵��ǵ��ô����bds�����ݼ������ݱ����ʱ����Ԥ�⣬����ñ�̰�
        private void binding()
        {
            this.txtDm.DataBindings.Clear();
            this.txtDm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtMc.DataBindings.Clear();
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}