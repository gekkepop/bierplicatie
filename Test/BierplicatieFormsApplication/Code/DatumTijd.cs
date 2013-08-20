using System.Collections.Generic;
using System.IO;

namespace BierplicatieFormsApplication
{
    internal class DatumTijd
    {
        private System.DateTime vandaag = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, System.DateTime.Now.Second, System.DateTime.Now.Millisecond);

        public System.DateTime opstarttijd
        {
            get { return vandaag; }
            set { vandaag = value; }
        }
        //

        public bool DatumWegschrijven()
        {
            if (!File.Exists(@"C:\Bierplicatie\Config\DatumTijd.txt"))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(@"C:\Bierplicatie\Config\DatumTijd.txt"));
                FileStream datum = File.Create(@"C:\Bierplicatie\Config\DatumTijd.txt");

                datum.Close();
            }

            StreamWriter datumschrijven = new StreamWriter(@"C:\Bierplicatie\Config\DatumTijd.txt");
            datumschrijven.WriteLine(vandaag);

            datumschrijven.Close();

            StreamReader datumLezen = new StreamReader(@"C:\Bierplicatie\Config\DatumTijd.txt");
            List<string> datumgelezen = new List<string>();
            string regel;
            while ((regel = datumLezen.ReadLine()) != null)
            {
                datumgelezen.Add(regel);
            }
            return true;
        }
    }
}