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
    public partial class aracSahibi : Form
    {
        public aracSahibi()
        {
            InitializeComponent();
        }

        private void devamButton_Click(object sender, EventArgs e)
        {
            EkFiyat ekFiyat = new EkFiyat();
            ekFiyat.Show();
        }
    }
}
