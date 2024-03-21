namespace Kigyos_jatek
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int fej_x = 100;
        int fej_y = 100;

        int hossz = 10;

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();

        List<Alma> almak = new List<Alma>();

        List<Mereg> mergek = new List<Mereg>();

        int l�p�ssz�m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*List<string> list = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                //list[i] =

            }
            foreach (string item in list)
            {

            }
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            //Fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            /*foreach (K�gy�Elem item in Controls)
            {
                //Ha van m�r valami ott, ahova az �j fejet tenn�m, v�ge a j�t�knak
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }*/

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;

            //alma mereg
            k�gy�.Add(ke);

            Controls.Add(ke);

            if (k�gy�.Count > hossz)
            {
                //K�gy�Elem lev�gand� = Controls.RemoveAt(0);
                K�gy�Elem lev�gand� = k�gy�[0];
                //Controls.RemoveAt(0);

                //alma mereg
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;

            if(l�p�ssz�m % 10 == 0)
            {
                Alma alma = new Alma();
                alma.Top = (rnd.Next(ClientRectangle.Height / 20) * 20) + 5;
                alma.Left = (rnd.Next(ClientRectangle.Width / 20) * 20) + 5;
                almak.Add(alma);
                Controls.Add(alma);
                
            }

            if (l�p�ssz�m % 20 == 0)
            {
                Mereg mereg = new Mereg();
                mereg.Top = (rnd.Next(ClientRectangle.Height / 20) * 20) + 5;
                mereg.Left = (rnd.Next(ClientRectangle.Width / 20) * 20) + 5;
                mergek.Add(mereg);
                Controls.Add(mereg);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }

    class Alma : PictureBox
    {
        public static int M�ret = 10;
        public Alma()
        {
            Width = Alma.M�ret;
            Height = Alma.M�ret;
            BackColor = Color.Red;
        }
    }

    class Mereg : PictureBox
    {
        public static int M�ret = 10;
        public Mereg()
        {
            Width = Mereg.M�ret;
            Height = Mereg.M�ret;
            BackColor = Color.Green;
        }
    }
}