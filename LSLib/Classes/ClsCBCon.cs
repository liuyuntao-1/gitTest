using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLib.Classes
{
    //数据库连接串类
    //类ClsDBCon被设计为静态（static）类，该类的所有成员都应该是静态的。
    public static class ClsCBCon
    {
        //static ClsDBCon()为类的构造函数。静态类的构造函数将在类首次引用时调用。
         static ClsCBCon()
        {
            //将从Web.config中读取名字为lsjckjConnectionString的数据库连接串的内容。
            ConStrKj = ConfigurationManager.ConnectionStrings["lsjckjConnectionString"].ConnectionString;
            ConStrJxc = ConfigurationManager.ConnectionStrings["jxcConnectionString"].ConnectionString;
        }
        //定义了类的一个属性。
        public static string ConStrKj { get; set; }

        /// <summary>
        /// 基础框架数据库连接串
        /// </summary>
        public static string ConStrJxc { get; set; }
    }
}
