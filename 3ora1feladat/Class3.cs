using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ora1feladat
{
    internal class SzamoloGomb : Button
    {
        int szam;
        public SzamoloGomb() 
        {
            Width = 20;
            Height = 20;
            szam = 1;
            Click += SzamoloGomb_Click;
            Text = szam.ToString();
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            szam++;
            if (szam == 6)
            {
                szam = 1;
            }
            Text = szam.ToString();
        }
    }
}
