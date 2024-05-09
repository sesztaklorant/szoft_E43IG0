using linq11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq11
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new();
        int rekordok = 0;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            var ilist = from i in context.Instructors
                        select i;

            listBox1.DataSource = ilist.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => FilterListBox();

        private void FilterListBox()
        {
            listBox1.DataSource = (from i in context.Instructors
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null) return;
            Instructor instructor = (Instructor)listBox1.SelectedItem;

            var teachers = from i in context.Instructors
                           where i.InstructorSk == instructor.InstructorSk
                           select new
                           {
                               Fokozat = i.Salutation,
                               Nev = i.Name,
                               Statusz = i.StatusFkNavigation.Name,
                               Foglalkoztatas = i.EmployementFkNavigation.Name
                           };

            var adatok = teachers.ToList();

            dataGridView1.DataSource = adatok;

            rekordok = adatok.Count();

            textBox2.Text = rekordok.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
