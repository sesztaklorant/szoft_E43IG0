namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop <= 10; oszlop++)
                {
                    /*
                    int eltol = sor * 30;
                    Button b = new Button();
                    b.Top = sor * 60;
                    if (sor == 0)
                    {
                        b.Left = ClientRectangle.Width / 2 - 30;
                    }
                    else b.Left = ClientRectangle.Width / 2 - 30 - oszlop * 60 + sor * 30;
                    b.Left = oszlop * 60; - eltol;
                    b.Height = 60;
                    b.Width = 60;
                    this.Controls.Add(b);
                    int p = Faktorialis(sor) / (Faktorialis(oszlop) * (Faktorialis(sor - oszlop)));
                    if (oszlop <= sor)
                    {
                        b.Text = p.ToString();
                    }
                    */


                    int p = Faktorialis(sor) / (Faktorialis(oszlop) * (Faktorialis(sor - oszlop)));
                    if (p != 0)
                    {
                        Button b = new Button();
                        b.Top = sor * 60;
                        if (sor == 0)
                        {
                            b.Left = ClientRectangle.Width / 2 - 30;
                        }
                        else b.Left = ClientRectangle.Width / 2 - 30 - oszlop * 60 + sor * 30;
                        b.Height = 60;
                        b.Width = 60;
                        this.Controls.Add(b);
                        b.Text = p.ToString();
                    }


                }

            }
        }

        int Faktorialis(int n)
        {
            int eredm�ny = 1;
            for (int i = 1; i <= n; i++) eredm�ny *= i;

            return eredm�ny;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}