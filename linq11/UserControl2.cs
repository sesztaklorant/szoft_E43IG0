﻿using linq11.Models;
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
    public partial class UserControl2 : UserControl
    {
        StudiesContext context;
        int rekordok = 0;
        public UserControl2()
        {
            InitializeComponent();
            context = new StudiesContext();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from c in context.Courses
                                   where c.Name.Contains(textBox1.Text)
                                   select c).ToList();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null) return;

            Course course = listBox1.SelectedItem as Course;

            /*

            dataGridView1.DataSource = (from l in context.Lessons
                                        where l.CourseFk == course.CourseSk
                                        select new
                                        {
                                            Nap = l.DayFkNavigation.Name,
                                            Sav = l.TimeFkNavigation.Name,
                                            Oktato = l.TimeFkNavigation.Name,
                                        }
                                        ).ToList();

            */

            var kurzusok = (from l in context.Lessons
                                        where l.CourseFk == course.CourseSk
                                        select new
                                        {
                                            Nap = l.DayFkNavigation.Name,
                                            Sav = l.TimeFkNavigation.Name,
                                            Oktato = l.TimeFkNavigation.Name,
                                        }
                                        ).ToList();

            var adatok = kurzusok.ToList();

            dataGridView1.DataSource = adatok;

            rekordok = adatok.Count();

            textBox2.Text = rekordok.ToString();

        }
    }
}
