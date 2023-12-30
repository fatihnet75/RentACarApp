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
    public partial class Delete : Form
    {
        delete del = new delete();
        public Delete()
        {
            InitializeComponent();
        }

        private void Silbutton1_Click(object sender, EventArgs e)
        {
            del.DeleteCar(Convert.ToInt64(deletetextBox1.Text));
            Girir girir = new Girir();
            girir.Show();
        }
    }
}
