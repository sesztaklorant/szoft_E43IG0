using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ora1feladat
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb()
        {
            //ctor tab tab gyors
            MouseEnter += OnMouseEnter;
            MouseLeave += OnMouseLeave;
        }

        private void OnMouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void OnMouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
