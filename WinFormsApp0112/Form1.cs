namespace WinFormsApp0112
{
    public partial class Form1 : Form
    {
        int[] listaLiczb = { 3, 2, 5, 1, 4, 2};
        public Form1()
        {
            InitializeComponent();
            label1.Text = "1\n2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drzewo tree = new Drzewo(listaLiczb);
            label1.Text = tree.ToString();
        }
    }
}