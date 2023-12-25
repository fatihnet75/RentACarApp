using RentaCar.Entities;
using RentaCar.Repository.Car;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentaCar
{
    public partial class kredi : Form
    {
        private readonly Credit credit;
        public kredi()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            var Carcredit = new CarCredit {

                KartName = Convert.ToString(adTextBox.Text),
                KartId = Convert.ToInt64(kartIdTextBox.Text),
                Cvv = Convert.ToInt32(CvvTextBox.Text),

            };
            credit.SetCredit(Carcredit);
            Girir basla = new Girir();
            basla.Show();
        }
        
    }
}
