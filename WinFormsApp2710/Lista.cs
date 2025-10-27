using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2710
{
    internal class Lista
    {
        public int liczbaElementow = 0;
        public Element head;
        public Element tail;

        public void Dodaj(int liczba)
        {
            Element temp = new Element();
            temp.wartość = liczba;
            if(head != null)
            {
                liczbaElementow++;
                tail.next = temp;
                temp.prev = tail;
                tail = temp;
            }else
            {
                liczbaElementow = 1;
                head = temp;
                tail = temp;
            }
        }
        public void DodajPo(Element e, int liczba)
        {
            Element temp = new Element();
            temp.wartość = liczba;
            if (e.next == null)
            {
                tail = temp;
                temp.prev = e;
                e.next = temp;
            }else
            {
                temp.next = e.next;
                e.next = temp;
                temp.prev = e;
            }
            liczbaElementow++;
        }
        public void DodajPrzed(Element e, int liczba)
        {
            Element temp = new Element();
            temp.wartość = liczba;
            if (e.prev == null)
            {
                head = temp;
                temp.next = e;
                e.prev = temp;
            }
            else
            {
                temp.prev = e.prev;
                e.prev = temp;
                temp.next = e;
            }
            liczbaElementow++;
        }
    }
}
