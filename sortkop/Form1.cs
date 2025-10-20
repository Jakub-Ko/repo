namespace sortkop
{
    public partial class Form1 : Form
    {
        List<int> lista = new List<int> {10, 4, 8, 5, 12, 2, 6, 11, 3, 9, 7, 1};
        int num = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = String.Join(" ", lista);
            label2.Text = "";
            label2.Text = num.ToString();
        }

        private void sortuj(List<int> l)
        {
            for(int i = 1; i < l.Count; i++)
            {
                while (i>0 && l[i - 1]> l[i])
                {
                    int temp = l[i];
                    l[i] = l[i - 1];
                    l[i - 1] = temp;
                    i--;
                    num++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sortuj(lista);
            label1.Text = String.Join(" ", lista);
            label2.Text = "";
            label2.Text = num.ToString();
        }
    }
}