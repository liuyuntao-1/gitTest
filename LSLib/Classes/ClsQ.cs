using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLib.Classes
{    
    /// 在字符串两端添加引号或括号等符号
    /// 类名前要增加明确的访问修饰符，此处为public    
    public class ClsQ
    {        
        /// 该类的成员均为公用的静态成员函数，即直接用类名引用的函数，因此成员函数均以public static开始。
        /// 类的主要函数是public static string Q0(string s, char quoter)，功能是根据quoter给串s两侧加符号。        
        public static string Q0(string s, char quoter)
        {
            //声明了一个字符型数组，并进行了初始化
            char[] quoters = { '"', '\'', '(', '[', '‘', '“' };
            //Contains：用于确定一个数据是否是数组中的元素
            if (!quoters.Contains(quoter))
            {
                return s;
            }
            else
            {
                switch (quoter)
                {
                    case '"':
                        return '"' + s + '"';
                    case '\'':
                        return '\'' + s + '\'';
                    case '(':
                        return '(' + s + ')';
                    case '[':
                        return '[' + s + ']';
                    case '‘':
                        return '‘' + s + '’';
                    case '“':
                        return '“' + s + '”';
                    default:
                        return s;
                }
            }
                
        }
        
        public static string Q1(string s)
        {
            return Q0(s,'\'');
        }
        public static string Q2(string s)
        {
            return Q0(s,'\"');
        }
    }
}
