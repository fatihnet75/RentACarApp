using System;
using RentaCar.Entities;
using RentaCar.Repository.DbContext;

namespace RentaCar.Repository.Car
{
	public class RezervationRepository : AppDbContext
    {
        public void SetRezervasyon(CarRezervation rezervation)
        {
            string query = $"INSERT INTO [dbo].[Rezervasyon] VALUES ('{rezervation.Tc}','{rezervation.Plaka}','{rezervation.FirstYil}','{rezervation.LastYil}')";
            var response = Query(query);

     
        }
    }
}
