namespace AiSD_2
{
    public partial class Form1 : Form
    {
        Random r = new Random((int)DateTime.Now.Ticks);
        int l = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = l.ToString();
            btn.Text = "Start";

            List<int> lista = new List<int>();
            while (lista.Count < 10)
            {
                lista.Add(r.Next(0, 100));
            }

            lbl.Text = String.Join(", ", lista);

            for(int i = 0; i<lista.Count; i++)
            {
                lbl.Text = lista.ElementAt(i);
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (btn.Text == "Start")
                return;

            if (l > 9)
            {
                btn.Text = "Koniec";
                MessageBox.Show("Koniec");
                l = 0;
                label1.Text = l.ToString();
                btn.Text = "Start";
                return;
            }

            int x = r.Next(0, this.Size.Width - btn.Size.Width - 10);
            int y = r.Next(0, this.Size.Height - btn.Size.Height - 40);
            btn.Location = new Point(x, y);
            l++;
            label1.Text = l.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(btn.Text != "Skacz")
            {
                btn.Text = "Skacz";
            }
            else
            {
                btn.Text = "Start";
            }
        }
    }
}