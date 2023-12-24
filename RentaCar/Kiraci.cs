using RentaCar.Entities;
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
    public partial class Kiraci : Form
    {
        private readonly CarService carService;
        private string plaka;
        private readonly RezervationRepository rezervation;
        public Kiraci(CarService carService, string plaka)
        {
            this.carService = carService;
            this.plaka = plaka;
            rezervation = new RezervationRepository();
            InitializeComponent();
        }

        private void DEVAM_Click(object sender, EventArgs e)
        {
            var carRezervation = new CarRezervation()
            {
                FirstYil = DateTime.Now,
                LastYil = DateTime.Now,
                Plaka = plaka,
                Tc = Convert.ToInt64(tcTextBox.Text)
            };

            rezervation.SetRezervasyon(carRezervation);
            odeme odeme = new odeme();
            odeme.Show();
        }
    }
}
