using RentaCar.Entities;
using RentaCar.Repository.Car;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RentaCar
{
    public partial class aracOzellik : Form
    {
        private readonly NewCar newcar = new NewCar();
        private readonly Gasoline gasoline = new Gasoline();
        private readonly Electiric electiric = new Electiric();
        public aracOzellik()
        {
            InitializeComponent();
        }

        private void devamButton_Click(object sender, EventArgs e)
        {
            var carElectiric=new CarElectiric()
            { 
             Plaka =Convert.ToInt64(plakaTextBox.Text),
             marka=Convert.ToString(markaTextBox.Text),
             model=Convert.ToString(modelkTextBox.Text),
            };
            var AddCars = new AddCArs()
            {
                Plaka = Convert.ToInt64(plakaTextBox.Text),
                Renk = Convert.ToString(renkTextBox.Text),
                Yil = Convert.ToDateTime(yilTextBox.Text),
                Fiyat=Convert.ToInt32(fiyatTextBox.Text),

            };
            var carGasoline = new CarGasoline()
            {
                Plaka = Convert.ToInt64(plakaTextBox.Text),
                marka = Convert.ToString(markaTextBox.Text),
                model = Convert.ToString(modelkTextBox.Text),
            };

            newcar.SetCar(AddCars);
            if (benzinRadioButton.Checked)
            {
               gasoline.SetGasoline(carGasoline);
            }
            else if (elektrikRadioButton.Checked)
            {
                electiric.SetElectiric(carElectiric);
            }
            aracSahibi aracSahibi = new aracSahibi();
            aracSahibi.Show();
        }
    }
}
