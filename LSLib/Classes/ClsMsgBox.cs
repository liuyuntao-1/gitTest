using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLib.Classes
{
    //通用对话框类
    // MessageBoxButtons说明对话框中显示的按钮
    // MessageBoxIcon说明对话框中显示的图标
    public static class ClsMsgBox
    {
        
        // 提示对话框
        public static void Ts(string mess)
        {
            MessageBox.Show(mess, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        // 警告对话框
        public static void Jg(string mess)
        {
            MessageBox.Show(mess, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        // 错误对话框
        public static void Cw(string mess)
        {
            MessageBox.Show(mess, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        // YesNo询问对话框
        public static void YesNo(string mess, EventHandler hdl)
        {
            MessageBox.Show(mess, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, hdl);
        }
        
        // OKCancel询问对话框
        public static void OKCancel(string mess, EventHandler hdl)
        {
            MessageBox.Show(mess, "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, hdl);
        }
        
        // Cw(string mess, Exception ex)函数是Cw(string mess)函数的一个重载。
        // Exception错误信息对话框      
        public static void Cw(string mess, Exception ex)
        {
            Cw(mess + "\n错误类型：" + ex.GetType() + "\n错误信息：\n" + ex.Message);
        }
    }
}
