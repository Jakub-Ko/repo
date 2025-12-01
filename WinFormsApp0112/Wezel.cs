using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp0112
{
    internal class Wezel
    {
        public Wezel? rodzic;
        public Wezel? prawe;
        public Wezel? lewe;
        public int wartosc;

        public Wezel(int wartosc)
        {
            this.wartosc = wartosc;
        }
        public Wezel(int wartosc, Wezel rodzic)
        {
            this.wartosc = wartosc;
            this.rodzic = rodzic;

        }
    }
}
