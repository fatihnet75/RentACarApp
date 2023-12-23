

using AutoMapper;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data.SqlClient;

namespace RentaCar.Repository.DbContext
{
    public class AppDbContext
    {/// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
        private SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=DESKTOP-V0VK574\\SQLEXPRESS;Database=GoACar;User Id=User;Password=123456;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<IDictionary<string, object>> Query(string query)
        {
            List<IDictionary<string, object>> result = new List<IDictionary<string, object>>();

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IDictionary<string, object> values = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnName = reader.GetName(i);
                                object columnValue = reader.GetValue(i);
                                if (!values.ContainsKey(columnName))
                                    values.Add(columnName, columnValue);
                            }

                            result.Add(values);
                        }
                    }
                }
            }

            return result;
        }
    }
}

