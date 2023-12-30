using RentaCar.Entities;
using RentaCar.Repository.Car;
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
    public partial class update : Form
    {
        private readonly Update updatee;

        public update()
        {
            InitializeComponent();
            updatee = new Update(); // updatee örneğini başlatın
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCArs addcars = new AddCArs
            {
                Plaka = Convert.ToInt64(plakaTextBox1.Text),
                Renk = Convert.ToString(renkTextBox3.Text),
                Yil = Convert.ToDateTime(yıilTextBox1.Text),
                Fiyat = Convert.ToInt32(fiyatTextBox2.Text),
            };

            updatee.UpdateCar(addcars, Convert.ToInt64(plakaTextBox1.Text));
            Girir basla = new Girir();
            basla.Show();
        }
    }
}

