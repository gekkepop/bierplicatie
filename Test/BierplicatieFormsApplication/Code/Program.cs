using System;
using System.Windows.Forms;

namespace BierplicatieFormsApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string opstarttijd = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DatumTijd datum = new DatumTijd();
            datum.DatumWegschrijven();
            Application.Run(new Hoofdscherm());
            //Application.Run(new Overzichtspagina());
        }
    }
}