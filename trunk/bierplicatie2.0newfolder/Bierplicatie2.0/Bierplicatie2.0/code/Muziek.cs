using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Bierplicatie2._0.code
{
    class Muziek
    {
        private SoundPlayer muziek = new SoundPlayer();

        public Muziek()
        {
            // TODO: Complete member initialization
        }

        public void afspelen(string locatie)
        {
            if (File.Exists(locatie))
            {
                muziek.SoundLocation = locatie;
                muziek.Play();
            }
            else
            {
                //muziek.SoundLocation = @"C:\bierplicatie\Media\Emma.wav";
                //muziek.Play();
            }
        }

    }
}
