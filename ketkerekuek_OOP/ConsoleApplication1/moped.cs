using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class moped : ketkerekuek
    {
        private int akkumulator;

        //property
        public int Akkumulator
        {
            get { return akkumulator; }
            set { akkumulator = value < 0 ? 0 : value; }
        }

        //konstruktor
        public moped(double g, int sz, int s, int a) : base(g, sz, s)
        {
            Akkumulator = a;
        }

        //halad fv
        public override string halad()
        {
            if (akkumulator >= 100)
            {
                return "Nagyon sokat megyek egy töltéssel.";
            }
            else
            {
                return "Keveset megyek egy töltéssel.";
            }
        }
    }
}
