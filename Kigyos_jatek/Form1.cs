namespace Kigyos_jatek
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int hossz = 10;

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();

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

            foreach (K�gy�Elem item in Controls)
            {
                //Ha van m�r valami ott, ahova az �j fejet tenn�m, v�ge a j�t�knak
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
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
                Controls.RemoveAt(0);

                //
            }

            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;

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
}