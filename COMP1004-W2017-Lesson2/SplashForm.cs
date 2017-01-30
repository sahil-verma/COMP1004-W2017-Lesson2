using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson2
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //1. intantiate 
            CalculatorForm calulcatoForm = new CalculatorForm();

            //2. pass a reference to the 
            calulcatoForm.previousForm = this;

            this.SplashFormTimer.Enabled = false;
            calulcatoForm.Show();
            this.Hide();
            //this.Show();
            //this.Close();
        }
    }
}
