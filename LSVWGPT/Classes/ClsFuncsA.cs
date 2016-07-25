using Gizmox.WebGUI.Forms;
using JXC.JH;
using LSLib.Classes;
using LSVWGPT.XTGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVWGPT.Classes
{
    public class ClsFuncsA : ClsFuncs
    {
        //每个模块都将加载到tp中。
        private TabPage tp;
        public ClsFuncsA(TabPage aTp)
        {
            tp = aTp;
        }
        public override void Call(int aId, string aBm, string aMc)
        {
            tp.Controls.Clear();
            #region 系统管理
            //模块管理
            //判断选中的功能菜单，string.Compare的第三个参数为true表示忽略大小写的比较。
            if (string.Compare(aBm, "xtgl-mkgl", true) == 0)
            {
                //创建FrmMKGL类的对象。
                FrmMKGL c = new FrmMKGL();
                //将创建的FrmMKGL对象加载到tp即tpMain中
                tp.Controls.Add(c);
                return;
            }
            //选项管理
            if (string.Compare(aBm, "xtgl-xxgl", true) == 0)
            {
                FrmOptionLBLB c = new FrmOptionLBLB();
                tp.Controls.Add(c);
                return;
            }
            //机构管理
            if (string.Compare(aBm, "xtgl-jggl", true) == 0)
            {
                FrmJGGL c = new FrmJGGL();
                tp.Controls.Add(c);
                return;
            }
            //角色管理
            if (string.Compare(aBm, "xtgl-jsgl", true) == 0)
            {
                FrmRolesLB c = new FrmRolesLB();
                tp.Controls.Add(c);
                return;
            }
            //配置管理
            if (string.Compare(aBm, "sysconfig", true) == 0)
            {
                FrmConfig c = new FrmConfig();
                c.Dock = DockStyle.Fill;
                //将tp即tpMain中的控件清除
                tp.Controls.Clear();
                tp.Controls.Add(c);
                return;
            }
            //员工管理
            if (string.Compare(aBm, "xtgl-yggl", true) == 0)
            {
                FrmYuanGongLB c = new FrmYuanGongLB();
                //该代码将使窗体充满父容器控件的空间，对于数据量较大的窗体，应该进行此操作
                c.Dock = DockStyle.Fill;
                tp.Controls.Add(c);
                return;
            }
            //进货单录入
            if (string.Compare(aBm, "jxc-jhdlr", true) == 0)
            {
                FrmJhdLB c = new FrmJhdLB();
                c.Dock = DockStyle.Fill;
                tp.Controls.Add(c);
                return;
            }
            #endregion

            //Call函数先用ClsMsgBox.Jg测试函数被调用了
            ClsMsgBox.Jg(aId + "," + aBm + "," + aMc + Environment.NewLine
              + "此功能正在实现中...");
        }

        
    }
}
