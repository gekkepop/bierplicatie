using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bierplicatie2._0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<string> namen = ReadNames();
            HuidigeDatumWegSchrijven();
            Application.Run(new Hoofdscherm(namen));
        }

        private static List<string> ReadNames()
        {
            List<string> namen = new List<string>();
            try
            {
                StreamReader namenlezer = new StreamReader(@"C:\bierplicatie\namen.txt");
                string regel;
                while ((regel = namenlezer.ReadLine()) != null)
                {
                    namen.Add(regel);
                }
                namenlezer.Close();
            }
            catch
            {
                MessageBox.Show(@"Er is geen textbestand met namen gevonden in C:\bierplicatie\namen.txt. Plaats deze met daarin voor iedere regel de namen van de huisgenoten.");
                Application.Exit();
            }
            return namen;
        }

        private static void HuidigeDatumWegSchrijven()
        {
            StreamWriter datumSchrijven = new StreamWriter(@"C:\Bierplicatie\Config\DatumTijd.txt");
            DateTime huidigeTijd = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);
            datumSchrijven.WriteLine(new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond));
            datumSchrijven.Close();
        }
    }
}
