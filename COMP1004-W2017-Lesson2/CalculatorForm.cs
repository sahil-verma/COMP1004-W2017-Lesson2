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
    public partial class CalculatorForm : Form
    {
        //3. create a reference to the previous form
        public Form previousForm;

        //'_' means private variables 
        //PRIVATE INSTANCE VARIABLES
        private string _operand1;
        private string _operand2;
        private bool _isCalculatorClear;
        //CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// default constructor
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method clears the claculator app and resets the variables
        /// </summary>
        private void _clearCalculator() {
            this._operand1 = "";
            this._operand2 = "";
            this._isCalculatorClear = true;
            ResultTextBox.Text = "0";
        }

        /// <summary>
        /// Event Handler fro all claculator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _CalculatorButton_Click(object sender, EventArgs e)
        {
            //Button CalculatorButton = (Button)sender;
            Button CalculatorButton = sender as Button;

            switch (CalculatorButton.Tag.ToString())
            {
                case "Operand":
                    if (this._isCalculatorClear) {
                        ResultTextBox.Text = CalculatorButton.Text;
                        this._isCalculatorClear = false;
                    }
                    else {
                        ResultTextBox.Text += CalculatorButton.Text;
                    }
                    break;
                case "Operator":
                    break;
                case "Other":
                    break;
            }
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure", "Confirm", 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if(result == DialogResult.OK)
            {
                this.previousForm.Close();
            }

            else
            {
                e.Cancel = true;
            }
        }
           
    }
}
