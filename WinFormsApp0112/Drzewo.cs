using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp0112
{
    internal class Drzewo
    {
        public Wezel korzen;

        public Drzewo(int[] lis)
        {
            korzen = new Wezel(lis.FirstOrDefault());
            for (int i = 1; i < lis.Length; i++)
            {
                Wezel wez = korzen;
                while(true)
                {
                    if(wez.wartosc < lis[i])
                    {
                        if (wez.prawe is not null)
                        {
                            wez = wez.prawe;
                        }
                        else
                        {
                            wez.prawe = new Wezel(lis[i], wez);
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
                            wez.lewe = new Wezel(lis[i], wez);
                            break;
                        }
                    }
                }
            }
        }

        private void Usun(Wezel wez)
        {
            if(wez.rodzic is not null)
            {
                if(wez.rodzic.wartosc <= wez.wartosc)
                {
                    /*wez.rodzic.prawe == wez;*/
                    throw new NotImplementedException("TODO");
                }
                else
                {
                    /*wez.rodzic.lewe == wez;*/
                    throw new NotImplementedException("TODO");
                }
            }
            else
            {
                /*korzen == wez;*/
                if (wez.lewe is not null)
                {
                    throw new NotImplementedException("ERROR: wez.lewe shouldn't be null");
                }
                if (wez.prawe is null)
                {
                    wez = null;
                    throw new NotImplementedException("wez.prawe is null TODO...?");
                }
                korzen = wez.prawe;
                wez.prawe.rodzic = null;
                wez.prawe = null;
            }
        }

        private int UsunNajm()
        {
            Wezel wez = korzen;
            while(wez.lewe is not null)
            {
                wez = wez.lewe;
            }
            int wartosc = wez.wartosc;
            Usun(wez);
            return wartosc;
        }

        public void ObrotLewo(Wezel wez)
        {
            if(wez == korzen || wez.rodzic is null)
            {
                return;
            }
            if(wez.rodzic == korzen)
            {
                korzen = wez;
            }
            Wezel rdzen = wez.rodzic;
            if(rdzen.prawe != wez)
            {
                throw new NotImplementedException("ERROR w Obrot...: rdzen.prawe != wez");
                /*return;*/
            }
            if(wez.lewe is not null)
            {
                rdzen.prawe = wez.lewe;
                wez.lewe.rodzic = rdzen;
            }
            wez.lewe = rdzen;
            wez.rodzic = rdzen.rodzic;
            if(rdzen.rodzic is not null)
            {
                if(rdzen.rodzic.lewe == rdzen)
                {
                    rdzen.rodzic.lewe = wez;
                    wez.rodzic = rdzen.rodzic;
                }
                else
                {
                    rdzen.rodzic.prawe = wez;
                    wez.rodzic = rdzen.rodzic;
                }
            }
            rdzen.rodzic = wez;
        }

        private String ToVals(Wezel wez)
        {
            if(wez.lewe is not null)
            {
                if (wez.prawe is not null)
                {
                    return wez.wartosc.ToString() + " (L-" + ToVals(wez.lewe) + " P-" + ToVals(wez.prawe) + ")";
                }
                return wez.wartosc.ToString() + " (L-" + ToVals(wez.lewe) + ")";
            }
            if(wez.prawe is not null)
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
