using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson2
{
    public static class Program
    {
        //declared public static from - Apllication GLOBAL
        public static SplashForm MySplashForm;

        //delcared public static Form - Calculator Form
        public static CalculatorForm MyCalculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize SplashForm
            Program.MySplashForm = new SplashForm();
            Program.MyCalculatorForm = new CalculatorForm();

            Application.Run(Program.MySplashForm);
        }
    }
}
