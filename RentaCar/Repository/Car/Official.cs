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
    public class Official : AppDbContext
    {
        public void SetEmployee(CarOficcial oficcial)
        {
            string query = "INSERT INTO [dbo].[yetkili] VALUES (@tc,@pozisyon ,@rütbe)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tc",oficcial.tc);
                    command.Parameters.AddWithValue("@pozisyon", oficcial.pzisyon);
                    command.Parameters.AddWithValue("@rütbe", oficcial.Rütbe)

                    command.ExecuteNonQuery();
                }
            }
        }
}
