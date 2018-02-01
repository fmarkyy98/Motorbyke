using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     abstract class ketkerekuek //abstract --> mainbe nem tudok belőle létrehozni példányt
    {
        private double guminyomas;
        private int szemelyek;
        private int suly;

        //propertyk
        public double Guminyomas { get { return guminyomas; } set { guminyomas = value > 0 ? value : 0; } }
        public int Szemelyek { get { return szemelyek; } set { szemelyek = value > 0 ? value : 1; } }
        public int Suly { get { return suly; } set { suly = value > 0 ? value : 20; } }

        //konstruktor
        public ketkerekuek(double g, int sz, int s)
        {
            Guminyomas = g;
            Szemelyek = sz;
            Suly = s;
        }

        //fv halad
        public abstract string halad();
        
    }
}
