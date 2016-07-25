using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LSLib.Classes
{
    public class ClsReg
    {
        /// <summary>
        /// 关于字母数字的正则表达式。
        /// </summary>
        public static Regex AlphaNumeric
        {
            get
            {
                return new Regex(@"^[0-9a-zA-Z]+$");
            }
        }
        /// <summary>
        /// 关于自然数的正则表达式。
        /// 自然数是0或任何整数，但没有符号。
        /// </summary>
        public static Regex NaturalNum
        {
            get
            {
                return new Regex(@"^\d*$");
            }
        }
        // <summary>
        /// 关于人民币(2位小数)的正则表达式。
        /// </summary>
        public static Regex RMB
        {
            get
            {
                return new Regex(@"^([1-9]\d*|0)(\.\d{0,2})?$");
            }
        }
    }
}
