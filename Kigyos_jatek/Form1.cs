namespace Kigyos_jatek
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int fej_x = 100;
        int fej_y = 100;

        int hossz = 10;

        int irány_x = 1;
        int irány_y = 0;

        List<KígyóElem> kígyó = new List<KígyóElem>();

        List<Alma> almak = new List<Alma>();

        List<Mereg> mergek = new List<Mereg>();

        int lépésszám;
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
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            /*foreach (KígyóElem item in Controls)
            {
                //Ha van már valami ott, ahova az új fejet tenném, vége a játéknak
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }*/

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;

            //alma mereg
            kígyó.Add(ke);

            Controls.Add(ke);

            if (kígyó.Count > hossz)
            {
                //KígyóElem levágandó = Controls.RemoveAt(0);
                KígyóElem levágandó = kígyó[0];
                //Controls.RemoveAt(0);

                //alma mereg
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;

            if(lépésszám % 10 == 0)
            {
                Alma alma = new Alma();
                alma.Top = (rnd.Next(ClientRectangle.Height / 20) * 20) + 5;
                alma.Left = (rnd.Next(ClientRectangle.Width / 20) * 20) + 5;
                almak.Add(alma);
                Controls.Add(alma);
                
            }

            if (lépésszám % 20 == 0)
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
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }

    class Alma : PictureBox
    {
        public static int Méret = 10;
        public Alma()
        {
            Width = Alma.Méret;
            Height = Alma.Méret;
            BackColor = Color.Red;
        }
    }

    class Mereg : PictureBox
    {
        public static int Méret = 10;
        public Mereg()
        {
            Width = Mereg.Méret;
            Height = Mereg.Méret;
            BackColor = Color.Green;
        }
    }
}