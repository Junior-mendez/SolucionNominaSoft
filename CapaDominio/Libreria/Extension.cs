using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Libreria
{
    public static class Extension
    {
        public static T GetColumnValue<T>(this SqlDataReader record, String columnName)
        {
            return GetColumnValue<T>(record, columnName, default(T));
        }

        public static T GetColumnValue<T>(this SqlDataReader objDr, String columnName, T defaultValue)
        {
            try
            {
                Object value = objDr[columnName];
                if (value == null || value == DBNull.Value)
                {
                    return defaultValue;
                }
                else
                {
                    if (defaultValue == null && objDr[columnName] is DateTime)
                    {
                        DateTime date = (DateTime)value;
                        Object sdate = date.ToStringDate();
                        return (T)sdate;
                    }
                    if (objDr[columnName] is Int64 || objDr[columnName] is Int32 || objDr[columnName] is Int16 || objDr[columnName] is Byte || objDr[columnName] is Decimal || objDr[columnName] is Double)
                    {
                        return (T)Convert.ChangeType(value, typeof(T));
                    }
                    else
                        return (T)value;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public static String ToStringDate(this DateTime date)
        {
            return date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
