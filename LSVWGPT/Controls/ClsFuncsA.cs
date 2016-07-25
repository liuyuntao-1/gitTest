using Gizmox.WebGUI.Forms;
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
        public override void Call(int aId, string aBm, string aMc)
        {
            #region 系统管理
            //模块管理
            if (string.Compare(aBm, "mkgl", true) == 0)
            {
                FrmMKGL c = new FrmMKGL();
                tp.Controls.Clear();
                tp.Controls.Add(c);
                return;
            }
            #endregion
            ClsMsgBox.Jg(aId + "," + aBm + "," + aMc + Environment.NewLine
              + "此功能正在实现中...");
        }
        private TabPage tp;
        public ClsFuncsA(TabPage aTp)
        {
            tp = aTp;
        }
    }
}
