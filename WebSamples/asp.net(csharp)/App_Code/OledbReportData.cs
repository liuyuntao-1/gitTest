using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.IO.Compression;

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//class  OledbReportData 产生提供给报表生成需要的 XML 或 JSON 数据，采用 OleDb 数据引擎
public class OledbReportData
{
    //★特别提示★：
    //连接Grid++Report Access例子数据库的连接串，应该修改为与实际一致，如果安装目录不在C:\Grid++Report 5.0，应进行修改。
    public const string OleDbConnStr = @"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=C:\Grid++Report 6\Samples\Data\Northwind.mdb";

    //定义在SQL中表示日期值的包围符号，Access用“#”, 而MS SQl Server用“'”，为了生成两者都可用的查询SQL语句，将其参数化定义出来。这样处理只是为了演示例子方便
    public const char DateSqlBracketChar = '#';

    //根据查询SQL,产生提供给报表生成需要的 XML 数据，字段值为空也产生数据
    public static void FullGenNodeXmlData(System.Web.UI.Page DataPage, string QuerySQL, bool ToCompress)
    {
        OleDbConnection ReportConn = new OleDbConnection(OleDbConnStr);
        OleDbCommand ReportDataCommand = new OleDbCommand(QuerySQL, ReportConn);
        ReportConn.Open();
        OleDbDataReader ReportDataReader = ReportDataCommand.ExecuteReader();
        XMLReportData.GenNodeXmlDataFromReader(DataPage, ReportDataReader, ToCompress? ResponseDataType.ZipBinary : ResponseDataType.PlainText);
        ReportDataReader.Close();
        ReportConn.Close();
    }

    //获取 Count(*) SQL 查询到的数据行数。参数 QuerySQL 指定获取报表数据的查询SQL
    public static int BatchGetDataCount(string QuerySQL)
    {
        int Total = 0;

        OleDbConnection ReportConn = new OleDbConnection(OleDbConnStr);
        OleDbCommand ReportDataCommand = new OleDbCommand(QuerySQL, ReportConn);
        ReportConn.Open();
        OleDbDataReader ReportDataReader = ReportDataCommand.ExecuteReader();
        if (ReportDataReader.Read())
            Total = ReportDataReader.GetInt32(0);
        ReportDataReader.Close();
        ReportConn.Close();

        return Total;
    }

    //<<protected function
    //根据查询SQL,产生提供给报表生成需要的 XML 或 JSON 数据
    protected static void DoGenDetailData(System.Web.UI.Page DataPage, string QuerySQL, ResponseDataType DataType, bool IsJSON)
    {
        OleDbConnection ReportConn = new OleDbConnection(OleDbConnStr);
        OleDbDataAdapter ReportDataAdapter = new OleDbDataAdapter(QuerySQL, ReportConn);
        DataSet ReportDataSet = new DataSet();
        ReportConn.Open();
        ReportDataAdapter.Fill(ReportDataSet);
        ReportConn.Close();

        if (IsJSON)
            JSONReportData.GenDataSet(DataPage, ReportDataSet, DataType);
        else
            XMLReportData.GenDataSet(DataPage, ReportDataSet, DataType);
    }
    //>>protected function

    //特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    //<<保留前面版本的函数，兼容以前版本所写程序
    //根据查询SQL,产生提供给报表生成需要的 XML 数据，采用 OleDb 数据引擎
    public static void GenNodeXmlData(System.Web.UI.Page DataPage, string QuerySQL, bool ToCompress)
    {
        DoGenDetailData(DataPage, QuerySQL, ToCompress ? ResponseDataType.ZipBinary : ResponseDataType.PlainText, false);
    }

    //根据查询SQL,产生提供给报表生成需要的 XML 数据，采用 OleDb 数据引擎, 这里只产生报表参数数据
    //当报表没有明细时，调用本方法生成数据，查询SQL应该只能查询出一条记录
    public static void GenParameterReportData(System.Web.UI.Page DataPage, string ParameterQuerySQL)
    {
        DoGenDetailData(DataPage, ParameterQuerySQL, ResponseDataType.PlainText, false);
    }

    //根据查询SQL,产生提供给报表生成需要的 XML 数据，采用 OleDb 数据引擎, 根据RecordsetQuerySQL获取报表明细数据，根据ParameterQuerySQL获取报表参数数据
    public static void GenEntireReportData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL, bool ToCompress)
    {
        OleDbConnection ReportConn = new OleDbConnection(OleDbConnStr);
        DataSet ReportDataSet = new DataSet();
        ReportConn.Open();
        OleDbDataAdapter DataAdapter1 = new OleDbDataAdapter(RecordsetQuerySQL, ReportConn);
        DataAdapter1.Fill(ReportDataSet, "Detail");
        OleDbDataAdapter DataAdapter2 = new OleDbDataAdapter(ParameterQuerySQL, ReportConn);
        DataAdapter2.Fill(ReportDataSet, "Master");
        ReportConn.Close();
        XMLReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType);
    }
    //>>保留前面版本的函数，兼容以前版本所写程序
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//class  OledbXMLReportData 根据SQL产生报表需要的 XML 数据，采用 OleDb 数据引擎
public class OledbXMLReportData : OledbReportData
{
    public static void GenOneRecordset(System.Web.UI.Page DataPage, string QuerySQL)
    {
        OledbReportData.DoGenDetailData(DataPage, QuerySQL, ReportDataBase.DefaultDataType, false);
    }

    public static void GenMultiRecordset(System.Web.UI.Page DataPage, ArrayList QueryList)
    {
        OleDbConnection ReportConn = new OleDbConnection(OleDbConnStr);
        DataSet ReportDataSet = new DataSet();

        ReportConn.Open();

        foreach (ReportQueryItem item in QueryList)
        {
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(item.QuerySQL, ReportConn);
            DataAdapter.Fill(ReportDataSet, item.RecordsetName);
        }

        ReportConn.Close();

        XMLReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType);
    }

    //特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    //<<保留前面版本的函数，兼容以前版本所写程序
    //产生报表明细记录数据，数据将被加载到明细网格的记录集中
    public static void GenDetailData(System.Web.UI.Page DataPage, string QuerySQL)
    {
        GenOneRecordset(DataPage, QuerySQL);
    }

    //这里只产生报表参数数据，数据加载到报表参数、非明细网格中的部件框中
    //当报表没有明细时，调用本方法生成数据，查询SQL应该只能查询出一条记录
    public static void GenParameterData(System.Web.UI.Page DataPage, string ParameterQuerySQL)
    {
        GenOneRecordset(DataPage, ParameterQuerySQL);
    }

    //根据RecordsetQuerySQL获取报表明细数据，对应数据加载到报表的明细网格的记录集中
    //根据ParameterQuerySQL获取报表参数数据，对应数据加载到报表参数、非明细网格中的部件框中
    public static void GenEntireData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL, ResponseDataType DataType)
    {
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem(RecordsetQuerySQL, "Detail"));
        QueryList.Add(new ReportQueryItem(ParameterQuerySQL, "Master"));
        GenMultiRecordset(DataPage, QueryList);
    }
    public static void GenEntireData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL)
    {
        GenEntireData(DataPage, RecordsetQuerySQL, ParameterQuerySQL, ReportDataBase.DefaultDataType);
    }
    //>>保留前面版本的函数，兼容以前版本所写程序
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//class  OledbJsonReportData 根据SQL产生报表需要的 JSON 数据，采用 OleDb 数据引擎
public class OledbJsonReportData : OledbReportData
{
    public static void GenOneRecordset(System.Web.UI.Page DataPage, string QuerySQL)
    {
        OledbReportData.DoGenDetailData(DataPage, QuerySQL, ReportDataBase.DefaultDataType, true);
    }

    public static void GenMultiRecordset(System.Web.UI.Page DataPage, ArrayList QueryList)
    {
        OleDbConnection ReportConn = new OleDbConnection(OleDbConnStr);
        DataSet ReportDataSet = new DataSet();

        ReportConn.Open();

        foreach (ReportQueryItem item in QueryList)
        {
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(item.QuerySQL, ReportConn);
            DataAdapter.Fill(ReportDataSet, item.RecordsetName);
        }

        ReportConn.Close();

        JSONReportData.GenDataSet(DataPage, ReportDataSet, ReportDataBase.DefaultDataType);
    }


    //特别提示：以下函数为兼容以前版本而保留，请勿再用之，无须兼容考虑可删除之
    //<<保留前面版本的函数，兼容以前版本所写程序
    //产生报表明细记录数据，数据将被加载到明细网格的记录集中
    public static void GenDetailData(System.Web.UI.Page DataPage, string QuerySQL)
    {
        GenOneRecordset(DataPage, QuerySQL);
    }

    //这里只产生报表参数数据，数据将加载到报表参数、非明细网格中的部件框中
    //当报表没有明细时，调用本方法生成数据，查询SQL应该只能查询出一条记录
    public static void GenParameterData(System.Web.UI.Page DataPage, string ParameterQuerySQL)
    {
        GenOneRecordset(DataPage, ParameterQuerySQL);
    }

    //根据RecordsetQuerySQL获取报表明细数据，对应数据加载到报表的明细网格的记录集中
    //根据ParameterQuerySQL获取报表参数数据，对应数据加载到报表参数、非明细网格中的部件框中
    public static void GenEntireData(System.Web.UI.Page DataPage, string RecordsetQuerySQL, string ParameterQuerySQL)
    {
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem(RecordsetQuerySQL, "Detail"));
        QueryList.Add(new ReportQueryItem(ParameterQuerySQL, "Master"));
        GenMultiRecordset(DataPage, QueryList);
    }
    //>>保留前面版本的函数，兼容以前版本所写程序
}
