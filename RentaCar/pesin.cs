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
    public partial class pesin : Form
    {
        private readonly Advance advance;
        private int miktar;
        public pesin(int miktar)
        {
            InitializeComponent();
            this.miktar = miktar;
            toplamlabel2.Text = Convert.ToString(miktar);
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            var carAdvance = new CarAdvance {
                Tarih = Convert.ToDateTime(tarihTextBox.Text),
                ToplamPara = Convert.ToInt32(toplamlabel2.Text),
            
            };

            advance.SetAdvance(carAdvance);
            Girir basla = new Girir();
            basla.Show();
        }
        
    }
}
