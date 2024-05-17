using System.Diagnostics.Metrics;

namespace Labirintus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load_1);

        }





        private void Form1_Load_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
            userControl1.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
            userControl1.Focus();
        }
    }
}
