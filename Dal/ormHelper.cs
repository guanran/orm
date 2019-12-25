using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Dal
{
    public class ormHelper
    {

        //public string connectionString = ConfigurationManager.ConnectionStrings["hrconstr"].ConnectionString;
        string connectionString = ConfigurationManager.AppSettings["hrconstr"];
        public  T Get<T>(object id)
        {
            Type type = typeof(T);
            StringBuilder strSQl = new StringBuilder();
            strSQl.AppendFormat("select * from  {0} with(nolock) ", GetTableName<T>());
            //反射
            PropertyInfo[] properties = type.GetProperties();

            //string sq = string.Join(",",properties.);
            foreach (var item in properties)
            {
                //根据特性去取列名
                object[] uAttr = item.GetCustomAttributes(typeof(ColumnNameAttribute), false);
                if (uAttr != null && uAttr.Length > 0)
                {
                    ColumnNameAttribute cattr = uAttr[0] as ColumnNameAttribute;
                    if (cattr != null)
                    {
                        //主键查找
                        if (IsPrimaryKey(cattr.Type))
                        {
                            strSQl.AppendFormat(" where {0} = @ID  ", cattr.Name);
                            break;
                        }
                    }
                }

            }
            SqlParameter[] paramenters =
            {
                new SqlParameter("@ID",id)
            };

            List<T> list = QueryList<T>(strSQl.ToString(), paramenters);

            if (list != null && list.Count > 0)
            {
                return list.FirstOrDefault();
            }
            else
            {
                return default(T);
            }

        }


        //根据特性标签判断是否为主键
        private static bool IsPrimaryKey(ColumnType ctype)
        {
            if (ctype == ColumnType.IdentityAndPrimaryKey || ctype == ColumnType.PrimaryKey)
            {
                return true;
            }
            return false;
        }


        public List<T> QueryList<T>(string SQLString, params SqlParameter[] cmdParms)
        {
            DataSet ds = Query(SQLString, cmdParms);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ConvertHelper.DataTableToIList<T>(ds.Tables[0]).ToList();
            }
            return null;
        }

        public DataSet Query(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdd = conn.CreateCommand())
                {
                    cmdd.CommandText = SQLString;
                    cmdd.CommandType = CommandType.Text;
                    if (cmdParms != null)
                    {
                        foreach (SqlParameter parameter in cmdParms)
                        {
                            if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && (parameter.Value == null))
                            {
                                parameter.Value = DBNull.Value;
                            }
                            cmdd.Parameters.Add(parameter);
                        }
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmdd))
                    {
                        DataSet ds = new DataSet();
                        try
                        {
                            da.Fill(ds, "ds");
                            cmdd.Parameters.Clear();
                        }
                        catch (System.Data.SqlClient.SqlException ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        return ds;
                    }
                }
            }
        }


        private static string GetTableName<T>()
        {
            Type type = typeof(T);
            object[] table = type.GetCustomAttributes(typeof(TableNameAttribute), false);
            if (table != null && table.Length > 0)
            {
                TableNameAttribute tAttr = table[0] as TableNameAttribute;
                if (tAttr != null)
                {
                    return tAttr.Name;
                }
            }
            return "";
        }

    }

    //TableName 特性 表名
    public class TableNameAttribute:Attribute
    {
        public string Name { get; set; }
        public TableNameAttribute(string Name)
        {
            this.Name = Name;
        }
    }

    public class ColumnNameAttribute : Attribute
    {
        public string Name { get; set; }
        public ColumnType Type { get; set; }
        public ColumnNameAttribute(string Name)
        {
            this.Name = Name;
        }

        public ColumnNameAttribute(string Name, ColumnType type)
        {
            this.Name = Name;
            this.Type = type;
        }
    }
    public enum ColumnType
    {
        Normal = 0,
        PrimaryKey = 1,
        ReadOnly = 2,
        Identity = 3,
        IdentityAndPrimaryKey = 4,
    }
}
