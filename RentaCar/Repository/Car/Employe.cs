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
    public class Employe : AppDbContext
    {
        public void SetEmployee(CarEmployee employe)
        {
            string query = "INSERT INTO [dbo].[personel] VALUES (@Turkiyeno,@telefon, @rütbe )";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Turkiyeno", employe.tc);
                    command.Parameters.AddWithValue("@telefon", employe.Telefon);
                    command.Parameters.AddWithValue("@rütbe", employe.Rutbe);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
