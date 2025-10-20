using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortkop
{
    internal class Wezel
    {
        public Wezel rodzic;
        public Wezel dzieckoLewe;
        public Wezel dzieckoPrawe;
        public int wartosc;

        public Wezel(int liczba)
        {
            this.wartosc = liczba;
        }

        public Wezel Dodaj(int liczba)
        {
            Wezel dziecko = new Wezel(liczba);
            if (this.dzieckoLewe == null)
            {
                this.dzieckoLewe = dziecko;
            }
            else
            {
                if(this.dzieckoPrawe == null)
                {
                    this.dzieckoPrawe = dziecko;
                }
                else
                {
                    throw new Exception(".........");
                }
            }
            dziecko.rodzic = this;
            return dziecko;
        }
    }
}
