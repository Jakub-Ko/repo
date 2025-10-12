namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<int> lista = new();
        int size = 10;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            losuj();

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
            label1.Text = String.Join(" ",lista);
        }

        private void sortuj()
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1; ++i)
            {
                for(int j = 0; j < n - i - 1; ++j)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
            label2.Text = String.Join(" ", lista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            losuj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sortuj();
        }
    }
}
