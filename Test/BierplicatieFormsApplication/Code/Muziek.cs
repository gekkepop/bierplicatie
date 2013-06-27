using System.Media;

namespace BierplicatieFormsApplication
{
    internal class Muziek
    {
        private SoundPlayer muziek = new SoundPlayer();

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