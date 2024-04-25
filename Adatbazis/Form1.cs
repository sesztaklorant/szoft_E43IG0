using Adatbazis.Models;

namespace Adatbazis
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();

        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Models.StudentContext studentContext = new Models.StudentContext();

            //dataGridView1.DataSource = studentContext.Students.ToList();

            students = studentContext.Students.ToList();

            studentBindingSource.DataSource = studentContext.Students.ToList();

            dataGridView1.DataSource = studentBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kivétel)
            {
                MessageBox.Show(kivétel.InnerException.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;

            var eredmeny = from student in students
                           where student.Name.Contains(text)
                           select student;

            var eredmeny2 = students.Where(x => x.Name.Contains(text)); //jobb megoldása az elõbbinek

            eredmeny2 = eredmeny2.OrderBy(student => student.Name);

            /*
            List<Student> eredmeny3 = new List<Student>();

            foreach (var item in students)
            {
                if(item.Name.Contains(text))
                {
                    eredmeny3.Add(item);
                }
            }

            ez is egy megoldás az elõzõre

            */

            studentBindingSource.DataSource = eredmeny2.ToList();
        }
    }
}