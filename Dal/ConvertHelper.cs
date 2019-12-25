using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Dal
{
    public class ConvertHelper
    {
        public static string DateTimeToString(DateTime? obj, string format)
        {
            if (obj != null)
            {
                try
                {
                    return Convert.ToDateTime(obj).ToString(format);
                }
                catch
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        public static string ToString(object obj)
        {
            if (obj != null)
            {
                try
                {
                    return Convert.ToString(obj);
                }
                catch
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        public static Int32 ToInt32(object obj, Int32 defaultvalue = 0)
        {
            if (obj != null)
            {
                try
                {
                    return Convert.ToInt32(obj);
                }
                catch
                {
                    return defaultvalue;
                }
            }
            else
            {
                return defaultvalue;
            }
        }
        public static Guid ToGuid(object obj)
        {
            if (obj != null)
            {
                try
                {
                    return new Guid(obj.ToString());
                }
                catch
                {
                    return new Guid("00000000-0000-0000-0000-000000000000");
                }
            }
            else
            {
                return new Guid("00000000-0000-0000-0000-000000000000");
            }
        }
        public static bool GuidIsNull(object obj)
        {
            if (obj != null)
            {
                try
                {
                    if (ToGuid(obj) == new Guid("00000000-0000-0000-0000-000000000000"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 从汉字转换到16进制
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetHexFromChs(string s)
        {
            string str = string.Empty;

            if (!string.IsNullOrEmpty(s))
            {
                if ((s.Length % 2) != 0)
                {
                    s += " ";//空格
                    //throw new ArgumentException("s is not valid chinese string!");
                }

                System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");

                byte[] bytes = chs.GetBytes(s);

                for (int i = 0; i < bytes.Length; i++)
                {
                    str += string.Format("{0:X}", bytes[i]);
                }
            }

            return str;
        }
        /// <summary>
        /// 从16进制转换成汉字
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string GetChsFromHex(string hex)
        {
            if (hex == null)
                throw new ArgumentNullException("hex");
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
                //throw new ArgumentException("hex is not a valid number!", "hex");
            }
            // 需要将 hex 转换成 byte 数组。
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2),
                        System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    // Rethrow an exception with custom message.
                    throw new ArgumentException("hex is not a valid hex number!", "hex");
                }
            }

            // 获得 GB2312，Chinese Simplified。
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");


            return chs.GetString(bytes);
        }

        public static IList<T> DataTableToIList<T>(DataTable dt)
        {
            if (dt == null)
                return null;

            DataTable p_Data = dt;
            // 返回值初始化 
            IList<T> result = new List<T>();
            for (int j = 0; j < p_Data.Rows.Count; j++)
            {
                T _t = (T)Activator.CreateInstance(typeof(T));
                PropertyInfo[] propertys = _t.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    for (int i = 0; i < p_Data.Columns.Count; i++)
                    {
                        // 属性与字段名称一致的进行赋值 
                        if (pi.Name.ToLower().Equals(p_Data.Columns[i].ColumnName.ToLower()))
                        {
                            // 数据库NULL值单独处理 
                            if (p_Data.Rows[j][i] != DBNull.Value)
                                pi.SetValue(_t, p_Data.Rows[j][i], null);
                            else
                                pi.SetValue(_t, null, null);
                            break;
                        }
                    }
                }
                result.Add(_t);
            }
            return result;
        }

        /// <summary>
        /// 将泛类型集合List类转换成DataTable
        /// </summary>
        /// <param name="list">泛类型集合</param>
        /// <returns></returns>
        public static DataTable ListToDataTable<T>(List<T> entitys)
        {
            //检查实体集合不能为空
            if (entitys == null || entitys.Count < 1)
            {
                throw new Exception("需转换的集合为空");
            }
            //取出第一个实体的所有Propertie
            Type entityType = entitys[0].GetType();
            PropertyInfo[] entityProperties = entityType.GetProperties();

            //生成DataTable的structure
            //生产代码中，应将生成的DataTable结构Cache起来，此处略
            DataTable dt = new DataTable();
            for (int i = 0; i < entityProperties.Length; i++)
            {
                //dt.Columns.Add(entityProperties[i].Name, entityProperties[i].PropertyType);
                dt.Columns.Add(entityProperties[i].Name);
            }
            //将所有entity添加到DataTable中
            foreach (object entity in entitys)
            {
                //检查所有的的实体都为同一类型
                if (entity.GetType() != entityType)
                {
                    throw new Exception("要转换的集合元素类型不一致");
                }
                object[] entityValues = new object[entityProperties.Length];
                for (int i = 0; i < entityProperties.Length; i++)
                {
                    entityValues[i] = entityProperties[i].GetValue(entity, null);
                }
                dt.Rows.Add(entityValues);
            }
            return dt;
        }
    }
}