using System.Drawing;

namespace Template
{
    public partial class Form1 : Form
    {
        Random rnd = new();
        List<int> lista = new();
        int i = 3;
        int size = 10;

        public Form1()
        {
            InitializeComponent();
            label1.Text = (i/2).ToString();
            sortuj(lista, 0, lista.Count);
        }

        private void losuj()
        {
            label2.Text = "";
            lista.Clear();
            for (int i = 0; i < size; i++)
            {
                int r = rnd.Next(1, 10);
                lista.Add(r);
            }
            lista.Reverse();
            label1.Text = String.Join(" ", lista);
        }

        private void sortuj(List<int> T,int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                sortuj(T,l,m);
                sortuj(T,m+1,r);
                scal(T, l, m, r);
            }
        }

        private void scal(List<int> T, int l, int m, int r)
        {
            _ = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            losuj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            losuj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sortuj(lista, 0, lista.Count -1);
            label2.Text = String.Join(" ", lista);
        }
    }
}