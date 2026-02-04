using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Attendance_Management_System.DAL
{
    public class DapperContext
    {
        public static readonly string connectionString = ConfigurationManager
                .ConnectionStrings["DB"]
                .ConnectionString;

        public static void ExecuteWithoutReturn(string procName, DynamicParameters param = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(procName, param, commandType: CommandType.StoredProcedure);
            }
        }

        public static T ExecuteReturnScalar<T>(string procName, DynamicParameters param = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return (T)Convert.ChangeType(
                    connection.ExecuteScalar(procName, param, commandType: CommandType.StoredProcedure),
                    typeof(T)
                );
            }
        }

        
        public static IEnumerable<T> ReturnList<T>(string procName, DynamicParameters param = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<T>(procName, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}