using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using BierplicatieFormsApplication;

namespace BierplicatieFormsApplication
{
    class Muziek
    {

        SoundPlayer muziek = new SoundPlayer();

        public Muziek()
        {
        }

        public void afspelen(string locatie)
        {
            muziek.SoundLocation = locatie;
            muziek.Play();
        }
    }
}
