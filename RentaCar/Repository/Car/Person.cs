using RentaCar.Entities;
using RentaCar.Repository.DbContext;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Repository.Car
{
    public class Person : AppDbContext
    {
        public void Setperson(CarPerson person)
        {
            string query = "INSERT INTO [dbo].[kişi] VALUES (@Turkiyeno,@plaka)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Turkiyeno", person.tc+1);
                    command.Parameters.AddWithValue("@plaka", person.Plaka);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
