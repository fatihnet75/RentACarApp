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

        public Kiraci(CarService carService, string plaka)
        {
            this.carService = carService;
            InitializeComponent();
            label1.Text = plaka;
        }

        private void DEVAM_Click(object sender, EventArgs e)
        {
            odeme odeme = new odeme();
            odeme.Show();
        }
    }
}
