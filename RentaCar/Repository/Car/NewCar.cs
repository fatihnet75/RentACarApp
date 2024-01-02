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
    public class NewCar : AppDbContext
    {
        public void SetCar(AddCArs car)
        {
            string query = "INSERT INTO [dbo].[Araç] VALUES (@plaka, @renk ,@fiyat,@yıl)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@plaka", car.Plaka);
                    command.Parameters.AddWithValue("@renk", car.Renk);
                    command.Parameters.AddWithValue("@fiyat", car.Fiyat);
                    command.Parameters.AddWithValue("@yıl", car.Yil);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void SetCarCursor(AddCArs car)
        {
            string insertQuery = "INSERT INTO [dbo].[Araç] VALUES (@plaka, @renk, @fiyat, @yıl)";
            string cursorQuery = "DECLARE arac_cursor CURSOR FOR SELECT plaka, renk, fiyat, yil FROM [dbo].[Araç]";
            string fetchNext = "FETCH NEXT FROM arac_cursor INTO @plaka, @renk, @fiyat, @yil";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                using (SqlCommand cursorCommand = new SqlCommand(cursorQuery, connection))
                using (SqlCommand fetchNextCommand = new SqlCommand(fetchNext, connection))
                {
                    // INSERT işlemini gerçekleştir
                    insertCommand.Parameters.AddWithValue("@plaka", car.Plaka);
                    insertCommand.Parameters.AddWithValue("@renk", car.Renk);
                    insertCommand.Parameters.AddWithValue("@fiyat", car.Fiyat);
                    insertCommand.Parameters.AddWithValue("@yil", car.Yil);

                    // Kürsörü aç
                    cursorCommand.ExecuteNonQuery();

                    // Kürsördeki her kaydı işle
                    fetchNextCommand.Parameters.Add("@plaka", System.Data.SqlDbType.BigInt);
                    fetchNextCommand.Parameters.Add("@renk", System.Data.SqlDbType.VarChar, 20);
                    fetchNextCommand.Parameters.Add("@fiyat", System.Data.SqlDbType.Int);
                    fetchNextCommand.Parameters.Add("@yil", System.Data.SqlDbType.Date);

                    using (SqlDataReader reader = fetchNextCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Kürsörden verileri al
                            car.Plaka = Convert.ToInt64(reader["plaka"]);
                            car.Renk = reader["renk"].ToString();
                            car.Fiyat = Convert.ToInt32(reader["fiyat"]);
                            car.Yil = Convert.ToDateTime(reader["yil"]);

                            // INSERT işlemini gerçekleştir
                            insertCommand.Parameters["@plaka"].Value = car.Plaka;
                            insertCommand.Parameters["@renk"].Value = car.Renk;
                            insertCommand.Parameters["@fiyat"].Value = car.Fiyat;
                            insertCommand.Parameters["@yil"].Value = car.Yil;

                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    // Kürsörü kapat
                    cursorCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
