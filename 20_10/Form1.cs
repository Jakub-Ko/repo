using System.Drawing;

namespace Template
{
    public partial class Form1 : Form
    {
        Random rnd = new();
        List<int> lista = new();
        int size = 10;

        public Form1()
        {
            InitializeComponent();
            losuj();
        }

        private void losuj()
        {
            label2.Text = "";
            lista.Clear();
            for (int i = 0; i < size; i++)
            {
                int r = rnd.Next(1, 100);
                lista.Add(r);
            }
            lista.Reverse();
            label1.Text = String.Join(" ", lista);
        }

        private void sortuj(List<int> T, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                sortuj(T, l, m);
                sortuj(T, m + 1, r);
                scal(T, l, m, r);
            }
        }

        private void scal(List<int> T, int l, int m, int r)
        {
            List<int> left = new();
            List<int> right = new();

            for (int i = l; i <= m; i++)
                left.Add(T[i]);

            for (int j = m + 1; j <= r; j++)
                right.Add(T[j]);

            int iLeft = 0;
            int iRight = 0;
            int k = l;

            while (iLeft < left.Count && iRight < right.Count)
            {
                if (left[iLeft] <= right[iRight])
                {
                    T[k] = left[iLeft];
                    iLeft++;
                }
                else
                {
                    T[k] = right[iRight];
                    iRight++;
                }
                k++;
            }

            while (iLeft < left.Count)
            {
                T[k] = left[iLeft];
                iLeft++;
                k++;
            }

            while (iRight < right.Count)
            {
                T[k] = right[iRight];
                iRight++;
                k++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            losuj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sortuj(lista,0,lista.Count - 1);
            label2.Text = String.Join(" ", lista);
        }
    }
}