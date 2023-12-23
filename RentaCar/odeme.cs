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
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }

        private void krediButton_Click(object sender, EventArgs e)
        {
            kredi kredi = new kredi();
            kredi.Show();
        }

        private void pesinButton_Click(object sender, EventArgs e)
        {
            pesin pesin = new pesin();
            pesin.Show();
        }
    }
}
