using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2212
{
    internal class Graf
    {
        public List<Wezel> wezly = new();
        public List<Krawedz> krawedzie = new();

        public Graf(List<Krawedz> k)
        {
            krawedzie = k;
            SortujKrawedzie();
            krawedzie.ForEach(ka => WezlyAdd(ka));
        }

        private void WezlyAdd(Krawedz k)
        {
            if (!wezly.Contains(k.a))
            {
                wezly.Append(k.a);
            }
            if (!wezly.Contains(k.b))
            {
                wezly.Append(k.b);
            }
        }

        public void Add(Krawedz k)
        {
            if (krawedzie.Contains(k))
            {
                return;
            }

            krawedzie.Append(k);
            switch (Check(k))
            {
                case 2:
                    wezly.Append(k.b);
                    break;
                case 3:
                    wezly.Append(k.a);
                    break;
                default:
                    break;

            }
            SortujKrawedzie();
            WezlyAdd(k);
        }

        // cztery przypadki
        // +2W +K / +W +K / +K X(przy 1W)X / +K (przy 2W) Złączenie grafów

        public void Join(Graf g)
        {
            // Złączenie grafów
        }

        public int Check(Krawedz k)
        {
            // 1-oba 2-lewy 3-prawy 0-nic
            if (this.wezly.Contains(k.a))
            {
                if (!this.wezly.Contains(k.b))
                {
                    return 1;
                }
                return 2;
            }
            if (!this.wezly.Contains(k.b))
            {
                return 3;
            }
            return 0;
        }

        public void SortujKrawedzie()
        {
            krawedzie = krawedzie.OrderBy(k => k.waga).ToList();
        }
    }
}
