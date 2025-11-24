namespace sortkop
{
    public partial class Form1 : Form
    {
        int[] lista = {50, 30, 70, 20, 40, 60, 80, 65, 75, 85};
        int num = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = String.Join(" ", lista);
            label2.Text = "";
            label2.Text = num.ToString();
        }

        private void sortuj(int[] l)
        {
            Drzewo drz = new Drzewo(lista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = new Drzewo(lista).sorted();
        }
    }
}