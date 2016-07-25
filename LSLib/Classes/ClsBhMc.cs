using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLib.Classes
{
    public class ClsBhMc
    {
        public ClsBhMc(object abh, string amc)
        {
            Bh = abh;
            Mc = amc;
        }
        public object Bh { get; set; }
        public string Mc { get; set; }
        public string BhMc
        {
            get
            {
                return Bh + ":" + Mc;
            }
        }
    }
    public class ClsBhMcByte : ClsBhMc
    {
        public ClsBhMcByte(Byte abh, string amc) : base(abh, amc)
        {
        }
    }
    public class ClsBhMcString : ClsBhMc
    {
        public ClsBhMcString(string abh, string amc) : base(abh, amc)
        {
        }
    }
}
