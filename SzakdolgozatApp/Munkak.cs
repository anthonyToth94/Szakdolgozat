using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzakdolgozatApp
{
    public class Munkak
    {
        private int idk;
        private string ceg_nev;
        private string munkakor;
        private string kezdes;
        private string helyiseg;
        private string leiras;
        private double fizetes;
        public int Idk
        {
            get { return idk; }
            set { idk = value; }
        }
        public string Ceg_nev
        {
            get { return ceg_nev; }
            set { ceg_nev = value; }
        }

        public string Munkakor
        {
        get { return munkakor; }
        set { munkakor = value; }
        }
        public string Kezdes
        {
        get { return kezdes; }
        set { kezdes = value; }
        }
        public string Helyiseg
        {
            get { return helyiseg; }
            set { helyiseg = value; }
        }
        public string Leiras
        {
            get { return leiras; }
            set { leiras = value; }
        }
        public double Fizetes
        {
            get { return fizetes; }
            set { fizetes = value; }
        }

    }
  
}
