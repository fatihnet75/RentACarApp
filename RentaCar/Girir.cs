using RentaCar.Repository;
using RentaCar.Repository.Car;
using RentaCar.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Girir : Form
    {
        public Girir()
        {
            InitializeComponent();
        }
        //araç ekle
        private void button1_Click(object sender, EventArgs e)
        {
            aracOzellik aracOzellik = new aracOzellik();
            aracOzellik.Show();
        }
        // araç kirala
        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of the CarRepository class
            CarRepository carRepository = new CarRepository();
            FuelRepository fuelRepository = new FuelRepository();

            try
            {
                // Pass the CarRepository instance to the CarService constructor
                CarService carService = new CarService(carRepository,fuelRepository);

                // Now, you can pass the carService instance to the Arac_bilgileri constructor
                Arac_bilgileri aracBilgileriForm = new Arac_bilgileri(carService);

                // Show the created form
                aracBilgileriForm.Show();

                // Optionally, close the current form if needed
                // this.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during form creation
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // araç sil
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //Araç güncelle
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
