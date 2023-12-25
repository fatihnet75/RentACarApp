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
    public class Gasoline : AppDbContext
    {
        public void SetGasoline(CarGasoline gasoline)
        {
            string query = "INSERT INTO [dbo].[Benzin] VALUES (@plaka, @model ,@marka)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@plaka", gasoline.Plaka);
                    command.Parameters.AddWithValue("@marka", gasoline.model);
                    command.Parameters.AddWithValue("@model", gasoline.marka);

                    command.ExecuteNonQuery();
                }
            }
        }   }
}
