using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLib.Classes
{
    public class ClsMSSQL
    {
        #region GetDataTable
        //函数的功能是以连接串aCntStr打开数据库，返回aSelectCmd中SELECT语句的输出内容为C#中的DataTable。
        public static DataTable GetDataTable(string aSelectCmd, string aCntStr)
        {
            //创建一个虚拟表
            DataTable dt = new DataTable();
            //using:导入
            //创建连接             
            using (SqlConnection conn = new SqlConnection(aCntStr))//确保在数据库连接对象conn用完后将数据库关闭。
            {
                //打开连接,其中的conn对象用连接串aCntStr建立
                conn.Open();
                //创建command对象
                //将aSelectCmd中的SELECT语句建立为conn中的一个命令。
                SqlCommand cmd = new SqlCommand(aSelectCmd, conn);
                //创建适配器
                ////将cmd构造为一个可以进行数据读写操作的适配器(adapter)对象da。
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                try
                {
                    //填充,实现将数据库中的数据填入到C#的数据表对象dt中。
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    //调用通用对话框类
                    ClsMsgBox.Cw("GetDataTable遇到了错误。", ex);
                    // 重新引发异常，这是为了中断上层的调用程序，避免其使用不正确的GetDataTable返回结果运行后面的程序代码。
                    throw ex;
                }
                finally
                {
                    //关闭连接
                    conn.Close();
                }
            }
            return dt;
        
    }
        #endregion

        #region Exists  判断表中是否存在满足某一条件的记录

        //判断表中是否存在给字段取定值的记录,即：SELECT * FROM t WHERE f=v是否返回记录。        
        public static bool Exists(string aTable, string aQueryField, string aQueryValue, string acntStr)
        {
            string cmdText = string.Format("SELECT * FROM {0} WHERE {1}='{2}'",
                aTable, aQueryField, aQueryValue);
            return Exists(cmdText, acntStr);
        }
        
        //根据一个SELECT语句判断数据表中是否存在记录.
        //cmdText参数的形式应该形如：SELECT * FROM t1 WHERE id=5.
        //函数通过将它转换为如下形式而达致功能实现：
        //SELECT CASE WHEN EXISTS(SELECT * FROM t1 WHERE id=5) THEN 1 ELSE 0 END.
        //第二个参数为数据库连接串
        public static bool Exists(string cmdText, string acntStr)
        {
            bool b = false;
            using (SqlConnection conn = new SqlConnection(acntStr))
            {
                conn.Open();
                string cmdTextA = "EXISTS" + ClsQ.Q0(cmdText, '(');
                cmdTextA = "SELECT CASE WHEN " + cmdTextA + " THEN 1 ELSE 0 END";
                SqlCommand cmd = new SqlCommand(cmdTextA, conn);
                try
                {
                    //cmd.ExecuteScalar()返回cmd生成的表的第一行第一列的值。本例返回1或0。 
                    //MS SQL数据库的T-SQL没有定义布尔数据类型，需要在VS中使用Convert.ToBoolean函数将1、0分别转换为true和false。
                    b = Convert.ToBoolean(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Cw("Exists遇到了错误。", ex);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return b;
        }
        #endregion

        #region GetValue
        /// <summary>
        /// <para>执行SQL语句或存储过程，返回结果集第一行第一列的值。</para>
        /// <para>可以使用ArrayList arrLstParams传入参数，参数可以是输入型也可以是输出型，</para>
        /// <para>调用者可使用arrLstParams的实参检查输出型参数的返回值。</para>
        /// <para>如果是存储过程，则需要设置isStProc为true。</para>
        /// </summary>
        
        public static Object GetValue(string aSQLCmd, string aConStr,
            ArrayList arrLstParams = null, bool isStProc = false)
        {
            Object ret = null;
            using (SqlConnection conn = new SqlConnection(aConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(aSQLCmd, conn);
                if (arrLstParams != null) //如果是null不能AddRange
                {
                    //cmd.Parameters.AddRange向SqlParameterCollection的末尾添加值数组，
                    //arrLstParams.ToArray将arraylist的元素复制到一个指定元素类型的新数组
                    cmd.Parameters.AddRange(arrLstParams.ToArray(typeof(SqlParameter)));
                }
                if (isStProc)
                    cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    //在数据库中执行aSQLCmd中的命令，并返回结果集第一行第一列的值。
                    ret = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Cw("GetValue遇到了错误。", ex);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return ret;
        }


        /// <summary>
        /// 根据给定的条件返回指定表中指定字段的值
        /// </summary>
        /// <param name="aOutField"></param>
        /// <param name="aTable"></param>
        /// <param name="aWhere"></param>
        /// <param name="aConStr"></param>
        /// <returns></returns>
        public static Object GetValue(string aOutField, string aTable, string aWhere, string aConStr)
        {
            string cmdText = string.Format("SELECT {0} FROM {1} WHERE {2}",
                aOutField, aTable, aWhere);
            return GetValue(cmdText, aConStr);
        }
        /// <summary>
        /// 根据给定字段的值从一个表中查询某个字段的值
        /// </summary>
        /// <param name="aOutField"></param>
        /// <param name="aTable"></param>
        /// <param name="aQueryField"></param>
        /// <param name="aQueryValue"></param>
        /// <param name="aConStr"></param>
        /// <returns></returns>
        public static Object GetValue(string aOutField, string aTable,
            string aQueryField, string aQueryValue, string aConStr)
        {
            string aWhere = string.Format("{0}='{1}'", aQueryField, aQueryValue);
            return GetValue(aOutField, aTable, aWhere, aConStr);
        }
        #endregion

        #region GetStr
        public static string GetStr(string aSQLCmd, string aConStr,
            ArrayList arrLstParams = null, bool isStProc = false)
        {
            Object o = GetValue(aSQLCmd, aConStr, arrLstParams, isStProc);
            return Convert.ToString(o);
        }
        public static string GetStr(string aOutField, string aTable, string aWhere, string aConStr)
        {
            Object o = GetValue(aOutField, aTable, aWhere, aConStr);
            return Convert.ToString(o);
        }
        public static string GetStr(string aOutField, string aTable,
            string aQueryField, string aQueryValue, string aConStr)
        {
            Object o = GetValue(aOutField, aTable, aQueryField, aQueryValue, aConStr);
            return Convert.ToString(o);
        }
        #endregion

        #region GetInt
        public static int GetInt(string aOutField, string aTable,
            string aQueryField, string aQueryValue, string aConStr)
        {
            Object o = GetStr(aOutField, aTable, aQueryField, aQueryValue, aConStr);
            return Convert.ToInt32(o);
        }
        #endregion

        #region SetValue
        /// <summary>
        /// <para>将指定数据表tbn中键字段名为keyFldn值为keyFldv的记录的</para>
        /// <para>名为valueFldn的字段的值置为valueFldv。</para>
        /// </summary>
        /// <param name="tbn"></param>
        /// <param name="keyFldn">串类型和整型都可工作</param>
        /// <param name="keyFldv"></param>
        /// <param name="valueFldn">串类型和整型都可工作</param>
        /// <param name="valueFldv"></param>
        /// <param name="acntStr"></param>
        public static void SetValue(string tbn, string keyFldn, string keyFldv,
            string valueFldn, object valueFldv, string acntStr)
        {
            ExecuteCmd(string.Format("update {0} set {1}='{2}' where {3} = '{4}'",
                tbn, valueFldn, valueFldv.ToString(), keyFldn, keyFldv), acntStr);
        }
        #endregion

        #region tconfig表的读写操作
        public static string GetConfigStr(string aItemDm, string aConStr)
        {
            return GetStr("nr", "tconfig", "dm", aItemDm, aConStr);
        }
        public static int GetConfigInt(string aItemDm, string aConStr)
        {
            return Convert.ToInt32(GetConfigStr(aItemDm, aConStr));
        }
        public static void SetConfigItem(string aItemDm, object aItemValue, string aConStr)
        {
            SetValue("tconfig", "dm", aItemDm, "nr", aItemValue.ToString(), aConStr);
        }
        #endregion

        #region ExecuteCmd：执行SQL语句或存储过程，返回影响的行数
        /// <summary>
        /// <para>执行SQL语句或存储过程，返回影响的行数。</para>
        /// <para>可以使用ArrayList arrLstParams传入参数，参数可以是输入型也可以是输出型，</para>
        /// <para>调用者可使用arrLstParams的实参检查输出型参数的返回值。</para>
        /// <para>如果是存储过程，则需要设置isStProc为true。</para>
        /// </summary>
        /// <param name="aSQLCmd"></param>
        /// <param name="aConStr"></param>
        /// <param name="arrLstParams"></param>
        /// <param name="isStProc"></param>
        public static int ExecuteCmd(string aSQLCmd, string aConStr,
                    ArrayList arrLstParams = null, bool isStProc = false)
        {
            int rows = 0;
            using (SqlConnection conn = new SqlConnection(aConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(aSQLCmd, conn);
                if (arrLstParams != null) //如果是null不能AddRange
                {
                    cmd.Parameters.AddRange(arrLstParams.ToArray(typeof(SqlParameter)));
                }
                if (isStProc)
                    cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    //执行cmd中的SQL命令，返回影响的行数。
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Cw("ExecuteCmd遇到了错误：", ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            return rows;
        }
        #endregion
    }
}
