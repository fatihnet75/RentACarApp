using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentaCar.Entities;
using RentaCar.Repository;
using RentaCar.Repository.Car;
using RentaCar.Repository.DbContext;
using RentaCar.Service;
using System.Data.SqlClient;

namespace RentaCar
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            IServiceCollection services = new ServiceCollection();

            // Register other services
            services.AddScoped<CarRepository>();
            services.AddScoped<FuelRepository>();
            services.AddScoped<CarService>();
            services.AddScoped<AppDbContext>();
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1'e servisleri enjekte ederek oluþturun
            Arac_bilgileri form1 = new Arac_bilgileri(serviceProvider.GetRequiredService<CarService>());

            Application.Run(new Girir());
        }


        
    }
}