using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2212
{
    internal class Krawedz
    {
        public Wezel a;
        public Wezel b;
        public int waga;

        public Krawedz(int a, int b, int waga)
        {
            this.a = new Wezel(a);
            this.b = new Wezel(b);
            this.waga = waga;
        }
    }
}
