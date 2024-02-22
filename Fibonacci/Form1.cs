namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Elem> listam = new List<Elem>();

            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Top = i * 30;
                b.Text = Fibonacci(i).ToString();
                Controls.Add(b);

                Elem ujSor = new Elem();

                ujSor.Sorszam = i + 1;
                ujSor.Ertek = Fibonacci(i);

                listam.Add(ujSor);

            }

            szurkenegyzet.DataSource = listam;

        }

        int Fibonacci(int n)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}