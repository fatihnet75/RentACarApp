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
    public class Credit : AppDbContext
    {
        public void SetCredit(CarCredit Credit)
        {
            string query = "INSERT INTO [dbo].[Kredi] VALUES (@kartid,  @cvv, @kartisim)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kartid", Credit.KartId);
                    command.Parameters.AddWithValue("@cvv", Credit.Cvv);
                    command.Parameters.AddWithValue("@kartisim", Credit.KartName);
                   


                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
