using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2212;

namespace WinFormsApp0112
{
    internal class Drzewo
    {
        public DrzewoWezel korzen;

        public Drzewo(int[] lis)
        {
            korzen = new DrzewoWezel(lis.FirstOrDefault());
            for (int i = 1; i < lis.Length; i++)
            {
                DrzewoWezel wez = korzen;
                while (true)
                {
                    if (wez.wartosc < lis[i])
                    {
                        if (wez.prawe is not null)
                        {
                            wez = wez.prawe;
                        }
                        else
                        {
                            wez.prawe = new DrzewoWezel(lis[i], wez);
                            break;
                        }
                    }
                    else
                    {
                        if (wez.lewe is not null)
                        {
                            wez = wez.lewe;
                        }
                        else
                        {
                            wez.lewe = new DrzewoWezel(lis[i], wez);
                            break;
                        }
                    }
                }
            }
        }

        private String ToVals(DrzewoWezel wez)
        {
            if (wez.lewe is not null)
            {
                if (wez.prawe is not null)
                {
                    return wez.wartosc.ToString() + " (L-" + ToVals(wez.lewe) + " P-" + ToVals(wez.prawe) + ")";
                }
                return wez.wartosc.ToString() + " (L-" + ToVals(wez.lewe) + ")";
            }
            if (wez.prawe is not null)
            {
                return wez.wartosc.ToString() + " (P-" + ToVals(wez.prawe) + ")";
            }
            return wez.wartosc.ToString();
        }

        override
        public String ToString()
        {
            String txt = ToVals(korzen);
            return txt;
        }
    }
}