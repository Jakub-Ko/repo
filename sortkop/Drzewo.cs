using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortkop
{
    internal class Drzewo
    {
        public Wezel korzen;
        public int liczbaElementow = 12;
        public Wezel Dodaj(int liczba)
        {
            var rodzic = this.ZnajdzRodzica();
            return rodzic.Dodaj(liczba);
        }
        public void PrzywrocWlasnoscKopca(Wezel w)
        {
            _ = 0;
        }
        public Wezel ZnajdzRodzica()
        {
            var rodzic = this.korzen;
            /*if not null wyzej i rodzic = rodzic.dzieckoPrLe*/
            return rodzic;
        }
    }
}
