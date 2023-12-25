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
    public class Electiric : AppDbContext
    {
        public void SetElectiric(CarElectiric electiric)
        {
            string query = "INSERT INTO [dbo].[Elektrik] VALUES (@plaka, @model ,@marka)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@plaka", electiric.Plaka);
                    command.Parameters.AddWithValue("@marka", electiric.model);
                    command.Parameters.AddWithValue("@model", electiric.marka);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
