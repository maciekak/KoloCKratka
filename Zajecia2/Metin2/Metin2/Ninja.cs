using System;

namespace Metin2
{
    class Ninja
    {
        private string nick;
        private int level;
        public int punktyZycia;
        private int obrazenia;
        private int liczbaMikstur;
        private bool czyMaLuk;

        public Ninja(string nick, int level)
        {
            this.nick = nick;
            this.level = level;
        }
        public Ninja(string nick, int level, int punktyZycia, int obrazenia, int liczbaMikstur, bool czyMaLuk)
        {
            this.nick = nick;
            this.level = level;
            this.punktyZycia = punktyZycia;
            this.obrazenia = obrazenia;
            this.liczbaMikstur = liczbaMikstur;
            this.czyMaLuk = czyMaLuk;
        }

        public void PokazNaglowekPostaci()
        {
            Console.WriteLine("Wojownik: level: " + this.level + ", nick: " + this.nick);
        }

        public void PokazSzczegoloweInfoPostaci()
        {
            PokazNaglowekPostaci();
            Console.WriteLine("HP: " + punktyZycia + "\tObrazenia: " + obrazenia + "\tPoty: " + liczbaMikstur);
        }

        public void ZaatakujWojownika(Wojownik wojownik)
        {
            wojownik.punktyZycia -= obrazenia;
        }
    }
}