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
        public int liczbaElementow = 0;

        public void Dodaj(int liczba)
        {
            Wezel wez = korzen;
            while(wez is not null)
            {
                if(liczba < wez.wartosc)
                {
                    if (wez.dzieckoLewe is not null)
                    {
                        wez = wez.dzieckoLewe;
                    }
                    else
                    {
                        wez.dzieckoLewe = new Wezel(liczba, wez);
                        return;
                    }
                }
                else
                {
                    if (wez.dzieckoPrawe is not null)
                    {
                        wez = wez.dzieckoPrawe;
                    }
                    else
                    {
                        wez.dzieckoPrawe = new Wezel(liczba, wez);
                        return;
                    }
                }
            }
        }

        public Drzewo(int[] l)
        {
            if (l.Length < 1)
            {
                return;
            }
            this.korzen = new Wezel(l[0]);
            this.liczbaElementow++;
            for (int i = 1; i < l.Length; i++)
            {
                Dodaj(l[i]);
                this.liczbaElementow++;
            }
        }

        public int[] sorted()
        {
            int[] lista = new int[liczbaElementow];
            Wezel wez = korzen;
            while(wez.dzieckoLewe is not null)
            {
                wez = wez.dzieckoLewe;
            }
            int i = 0;
            while (i < liczbaElementow)
            {
                if(wez.dzieckoLewe is not null)
                {
                    wez = wez.dzieckoLewe;
                }
                else
                {
                    if (wez.dzieckoPrawe is not null)
                    {
                        wez = wez.dzieckoPrawe;
                    }
                    else
                    {
                        lista[i] = wez.wartosc;
                        i++;
                        if (wez.rodzic is not null)
                        {
                            if(wez.rodzic.dzieckoLewe is not null)
                            {
                                _ = 0;
                            }
                        }
                    }
                }
            }
            return lista;
        }
    }
}
