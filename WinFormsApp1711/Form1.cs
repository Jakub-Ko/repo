using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1711
{
    public partial class Form1 : Form
    {
        int[] lista = new int[] { 6,5,5,1,8,7 };
        int[] liczbyDoSortowania = null;
        public Form1()
        {
            InitializeComponent();

            String txt = "Mamy = ";
            foreach (int i in lista)
            {
                txt += i;
                txt += ", ";
            }
            txt = txt.Remove(txt.Length - 2);
            label1.Text = txt;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            button4.Enabled = false;
            label5.Text = "";
            label5.Enabled = false;
        }

        public void quickSort(int[] tab)
        {
            // TODO sort / 2
            newTab(tab,0,3);
        }

        public int[] newTab(int[] tab, int first, int last)
        {
            // czy dobrze ? 0 1 2 3 4 5
            int[] newTab = new int[last-first];
            for (int i = first; i<=last; i++)
            {
                
            }
            return newTab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> nowaLista = new();
            foreach (int i in lista)
            {
                nowaLista.Add(i);
                for (int j = nowaLista.Count-1; j >= 1; j--)
                {
                    if (nowaLista[j - 1] > nowaLista[j])
                    {
                        int temp = nowaLista[j];
                        nowaLista[j] = nowaLista[j - 1];
                        nowaLista[j - 1] = temp;
                    }
                }
            }

            String txt = "Otrzymaliœmy = ";
            foreach (int i in nowaLista)
            {
                txt += i;
                txt += ", ";
            }
            txt = txt.Remove(txt.Length - 2);
            label2.Text = txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = lista.Length - 1; i >= 0; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    if (lista[j - 1] > lista[j])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j - 1];
                        lista[j - 1] = temp;
                    }
                }
            }

            String txt = "Otrzymaliœmy = ";
            foreach (int i in lista)
            {
                txt += i;
                txt += ", ";
            }
            txt = txt.Remove(txt.Length - 2);
            label3.Text = txt;
        }

        private int[] Generuj()
        {
            return new int[] { 2, 5, 1, 3, 4, 0, 6, 2, 5 };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.liczbyDoSortowania = Generuj();
            String txt = "Wygenerowano = ";
                foreach (int i in liczbyDoSortowania)
            {
                txt += i;
                txt += ", ";
            }
            txt = txt.Remove(txt.Length - 2);
            label4.Text = txt;
            button4.Enabled = true;
            label5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            quickSort(this.liczbyDoSortowania);
            String txt = "(nie)Posortowane = ";
            foreach (int i in liczbyDoSortowania)
            {
                txt += i;
                txt += ", ";
            }
            txt = txt.Remove(txt.Length - 2);
            label5.Text = txt;
        }
    }
}