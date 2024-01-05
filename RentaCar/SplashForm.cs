// SplashForm.cs
using System;
using System.Threading;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            // You can set any additional properties for the splash screen here
            
        }

        public void ShowMainForm()
        {
            // Simulate some loading time
            Thread.Sleep(3000);

            // Close the splash screen and show the main form
            this.Close();
        }
    }
}
