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
        private int no;

        public pesin(int miktar, int no)
        {
            InitializeComponent();
            this.miktar = miktar;
            this.no = no;
            toplamlabel2.Text = Convert.ToString(miktar);

            // 'advance' nesnesini başlatın
            advance = new Advance(); // 'Advance' yerine kullandığınız gerçek sınıf adını yazın
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            var carAdvance = new CarAdvance
            {
                id = no,
                Tarih = Convert.ToDateTime(tarihTextBox.Text),
                ToplamPara = Convert.ToInt32(toplamlabel2.Text),
            };

            advance.SetAdvance(carAdvance);
            Girir basla = new Girir();
            basla.Show();
        }
    }
}
