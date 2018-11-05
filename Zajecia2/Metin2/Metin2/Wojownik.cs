using System;

namespace Metin2
{
    class Wojownik
    {
        private string nick;
        private int level;
        public int punktyZycia;
        private int obrazenia;
        private int liczbaMikstur;

        public Wojownik(string nick, int level)
        {
            this.nick = nick;
            this.level = level;
        }
        public Wojownik(string nick, int level, int punktyZycia, int obrazenia, int liczbaMikstur)
        {
            this.nick = nick;
            this.level = level;
            this.punktyZycia = punktyZycia;
            this.obrazenia = obrazenia;
            this.liczbaMikstur = liczbaMikstur;
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

        public void ZaatakujNinje(Ninja ninja)
        {
            ninja.punktyZycia -= obrazenia;
        }
    }
}