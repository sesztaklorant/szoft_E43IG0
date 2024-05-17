using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirintus
{
    public partial class UserControl1 : UserControl
    {
        

        int counter = 0;

        bool firsttime = true;

        DateTime startTime;
        public UserControl1()
        {
            InitializeComponent();

            //this.SetStyle(ControlStyles.Selectable, true);
            //this.TabStop = true;
            //this.KeyDown += new KeyEventHandler(UserControl1_KeyDown);
        }
        /*
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.Focus();
        }
        */
        PictureBox player = new PictureBox();

        List<PictureBox> start = new List<PictureBox>();

        List<PictureBox> cel = new List<PictureBox>();

        List<PictureBox> bricks = new List<PictureBox>();

        private void UserControl1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("maze1.txt");
            int y = 0;
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                for (int x = 0; x < sor.Length; x++)
                {
                    if (sor[x] == '#')
                    {
                        PictureBox pb = new PictureBox();
                        pb.Location = new Point(x * 20, y * 20);
                        pb.Size = new Size(20, 20);
                        pb.BackColor = Color.Black;
                        this.Controls.Add(pb);
                        bricks.Add(pb);
                    }
                    if (sor[x] == 'S')
                    {
                        PictureBox pb2 = new PictureBox();
                        pb2.Location = new Point(x * 20, y * 20);
                        pb2.Size = new Size(20, 20);
                        pb2.BackColor = Color.LightCoral;
                        this.Controls.Add(pb2);
                        start.Add(pb2);
                    }
                    if (sor[x] == 'C')
                    {
                        PictureBox pb3 = new PictureBox();
                        pb3.Location = new Point(x * 20, y * 20);
                        pb3.Size = new Size(20, 20);
                        pb3.BackColor = Color.Olive;
                        this.Controls.Add(pb3);
                        cel.Add(pb3);
                    }
                }
                y++;
            }

            player.Location = new Point(20, 20);
            player.Size = new Size(20, 20);
            player.BackColor = Color.Red;
            Controls.Add(player);

            KeyDown += UserControl1_KeyDown;

            timer1.Tick += Timer1_Tick;

        }
        private void UserControl1_KeyDown(object? sender, KeyEventArgs e)
        {

            int x = player.Location.X;
            int y = player.Location.Y;

            if (e.KeyCode == Keys.D)
            {
                x += 20;
            }

            if (e.KeyCode == Keys.A)
            {
                x -= 20;
            }

            if (e.KeyCode == Keys.W)
            {
                y -= 20;
            }

            if (e.KeyCode == Keys.S)
            {
                y += 20;
            }



            var wall = bricks.FirstOrDefault(w => w.Location.X == x && w.Location.Y == y);
            var s = start.FirstOrDefault(w => w.Location.X == x && w.Location.Y == y);
            var c = cel.FirstOrDefault(w => w.Location.X == x && w.Location.Y == y);
            if (wall == null)
            {
                player.Location = new Point(x, y);
                counter++;
            }

            if (firsttime)
            {
                startTime = DateTime.Now;
                timer1.Start();
                firsttime = false;
            }

            label1.Text = counter.ToString();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime; // Calculate the elapsed time
            label2.Text = elapsed.ToString(@"hh\:mm\:ss"); // Update the label
        }
    }
}
