using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bierplicatie2._0.code
{
    class InvullenNaamVelden
    {
        private List<string> gevuldeNaamVelden = new List<string>();
        public InvullenNaamVelden()
        {
        }

        public List<string> terugGevenNamenMakkelijk(List<string> namen, int status)
        {
            gevuldeNaamVelden.Clear();
            switch (status)
            {
                case 1:
                    InvullenVeldenHoofdscherm(namen);
                    break;
                case 2:
                    InvullenVeldenGastScherm(namen);
                    break;
                case 3:
                    InvullenVeldenKrattenInvoerScherm(namen);
                    break;
                default:
                    break;
            }


            return gevuldeNaamVelden;
        }

        private void InvullenVeldenHoofdscherm(List<string> namen)
        {
            int i = 1;
            foreach (string naam in namen)
            {
                gevuldeNaamVelden.Add("" + i + ".    " + naam);
                i++;
            }
            gevuldeNaamVelden.Add("" + i + ".    Gasten");
            i++;
            gevuldeNaamVelden.Add("" + i + ".    Invoer");
            i++;
            gevuldeNaamVelden.Add("Huidige aantal bier:");
        }

        private void InvullenVeldenGastScherm(List<string> namen)
        {
            int i = 1;
            foreach (string naam in namen)
            {
                gevuldeNaamVelden.Add("" + i + ".    Gast van " + naam);
                i++;
            }
            gevuldeNaamVelden.Add("" + i + ".    Terug");
        }
        private void InvullenVeldenKrattenInvoerScherm(List<string> namen)
        {
            int i = 1;
            foreach (string naam in namen)
            {
                gevuldeNaamVelden.Add("" + i + ".    Krat voor " + naam);
                i++;
            }
            gevuldeNaamVelden.Add("");
            i++;
            gevuldeNaamVelden.Add("" + i + ".    Terug");
        }

    }
}
