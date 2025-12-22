using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp0112
{
    internal class DrzewoWezel
    {
        public DrzewoWezel? rodzic;
        public DrzewoWezel? prawe;
        public DrzewoWezel? lewe;
        public int wartosc;

        public DrzewoWezel(int wartosc)
        {
            this.wartosc = wartosc;
        }
        public DrzewoWezel(int wartosc, DrzewoWezel rodzic)
        {
            this.wartosc = wartosc;
            this.rodzic = rodzic;

        }
    }
}