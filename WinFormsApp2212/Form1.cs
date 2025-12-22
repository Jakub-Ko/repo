namespace WinFormsApp2212
{
    public partial class Form1 : Form
    {
        //cw
        List<Krawedz> listaCW = new List<Krawedz> {
            new Krawedz(4, 6, 1),
            new Krawedz(4, 5, 2),
            new Krawedz(2, 7, 3),
            new Krawedz(0, 6, 3),
            new Krawedz(2, 4, 4),
            new Krawedz(0, 1, 5),
            new Krawedz(2, 6, 5),
            new Krawedz(1, 5, 6),
            new Krawedz(5, 6, 6),
            new Krawedz(1, 7, 7),
            new Krawedz(1, 4, 8),
            new Krawedz(3, 6, 8),
            new Krawedz(0, 3, 9),
            new Krawedz(1, 2, 9),
            new Krawedz(2, 3, 9),
            new Krawedz(6, 7, 9)
        };
        // Wynik to ?
       
        //wiki
        List<Krawedz> lista = new List<Krawedz> {
            new Krawedz(1, 5, 1),
            new Krawedz(3, 4, 2),
            new Krawedz(1, 2, 3),
            new Krawedz(2, 5, 4),
            new Krawedz(2, 3, 5),
            new Krawedz(5, 3, 6),
            new Krawedz(5, 4, 7)
        };
        // Wynik to 51234

        public Form1()
        {
            InitializeComponent();
            String txt = "";
            lista.ForEach(k => txt = txt + k.waga.ToString());
            label1.Text = txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graf gr = new Graf(lista);
            label1.Text = gr.ToString();
        }
    }
}