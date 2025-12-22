namespace WinFormsApp0112
{
    public partial class Form1 : Form
    {
        static int[] listaLiczb = { 3, 2, 5, 1, 4, 2};
        Drzewo tree = new Drzewo(listaLiczb);
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label1.Text = tree.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tree.ObrotLewo(tree.korzen.prawe);
            label1.Text = tree.ToString();
        }
    }
}