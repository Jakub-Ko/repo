namespace WinFormsApp2710
{
    public partial class Form1 : Form
    {
        /*List<int> lista = new List<int> {25, 83, 42, 31, 5};*/
        Random r = new Random();
        Lista lista = new();

        public Form1()
        {
            InitializeComponent();
            
            lista.Dodaj(25);
            lista.Dodaj(83);
            lista.Dodaj(42);
            lista.Dodaj(31);
            lista.Dodaj(5);
            lista.Dodaj(32);
            Element temp = lista.head;
            String txt = "To=";
            while (temp != null)
            {
                txt += temp.wartoœæ.ToString();
                txt += ", ";
                temp = temp.next;
            }
            label1.Text = txt;

            lista = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Dodaj(r.Next(1, 101));
            Element temp = lista.head;
            String txt = "To=";
            while (temp != null)
            {
                txt += temp.wartoœæ.ToString();
                txt += ", ";
                temp = temp.next;
            }
            label1.Text = txt;
        }
    }
}