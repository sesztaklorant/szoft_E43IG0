using System.Diagnostics.Metrics;

namespace Labirintus
{
    public partial class Form1 : Form
    {
        public string filePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Form1_Load_1);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            userControl1.utvonal = filePath;
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
            userControl1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\"; // You can specify the initial directory
            openFileDialog.Filter = "Text files (*.txt)|*.txt"; // Filter files for specific types
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                filePath = openFileDialog.FileName;
                StreamReader sr = new StreamReader(filePath);
                string sor = sr.ReadLine();
                string ellenor = string.Empty;
                for (int i = 0; i < 6; i++)
                {
                    ellenor += sor[i];
                }
                if (ellenor == "SSS###")
                {
                    panel1.Controls.Clear();
                    UserControl1 userControl1 = new UserControl1();
                    userControl1.utvonal = filePath;
                    panel1.Controls.Add(userControl1);
                    userControl1.Dock = DockStyle.Fill;
                    userControl1.Focus();
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("A megadott szöveges fájl nem megfelelõ!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Read the contents of the file into a stream
                //var fileStream = openFileDialog.OpenFile();
                //MessageBox.Show(filePath);
            }
        }
    }
}
