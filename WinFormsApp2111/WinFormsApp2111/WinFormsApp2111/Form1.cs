namespace WinFormsApp2111
{
    public partial class Form1 : Form
    {
        static Random rnd = new();
        // int[] lista = { rnd.Next(-100, 101), rnd.Next(-100, 101), rnd.Next(-100, 101), rnd.Next(-100, 101), rnd.Next(-100, 101), };
        int[] lista = { 3, 5, 6, 7};
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            setLabel(label1,lista);
        }

        private void setLabel(Label lab, int[] lis)
        {
            String txt = "";
            foreach(int el in lis)
            {
                txt = txt + el + " ";
            }
            lab.Text = txt;
        }

        private int[] sort(int[] li)
        {
            int maxL = li.FirstOrDefault();
            int minL = li.FirstOrDefault();
            foreach (int el in li)
            {
                if(minL > el)
                {
                    minL = el;
                }
                else
                {
                    if(maxL < el)
                    {
                        maxL = el;
                    }
                }
            }
            int[] pusta = new int[maxL - minL + 1];
            for (int i = 0; i < pusta.Length; i++)
            {
                pusta[i] = 0;
            }
            for (int i = 0; i < li.Length; i++)
            {
                pusta[li[i] - minL]++;
            }
            int[] posortowana = new int[li.Length];
            int j = 0;
            int k = 0;
            // posortowana[i] = pusta[j] * (minL+j);
            while(j < posortowana.Length)
            {
                while (pusta[k] < 1)
                {
                    k++;
                }
                posortowana[j] = pusta[k] * (minL+k);
                pusta[k]--;
                j++;
            }
            return posortowana;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = rnd.Next(-100, 101);
            }
            setLabel(label1,lista);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setLabel(label2, sort(lista));
        }
    }
}