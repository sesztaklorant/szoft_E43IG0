namespace _3ora1feladat
{
    public partial class Form1 : Form
    {
        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 1000; i++)
            {
                int width = rng.Next(20, 51);
                int height = rng.Next(20, 51);
                int left = rng.Next(this.ClientSize.Width - width);
                int top = rng.Next(this.ClientSize.Height - height);
                int r = rng.Next(256);
                int g = rng.Next(256);
                int b = rng.Next(256);
                Button gomb = new Button();
                gomb.Width = width;
                gomb.Height = height;
                gomb.Left = left;
                gomb.Top = top;
                gomb.BackColor = Color.FromArgb(r, g, b);
                this.Controls.Add(gomb);
            }
        }
        /*public Form1()
        {
            InitializeComponent();
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            /*for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {

                    SzamoloGomb uj = new SzamoloGomb();
                    uj.Width = 100;
                    uj.Height = 50;

                    uj.Left = i * 110;
                    uj.Top = j * 55;

                    //uj.Text = (i * j).ToString();

                    //uj.Left = ClientRectangle.Width / 2 - 50;
                    //uj.Top = ClientRectangle.Height / 2 - 25;

                    Controls.Add(uj);
                }
            }*/

        }
    }
}