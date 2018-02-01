using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class motor : ketkerekuek
    {
        private string kuplung;
        private int tank;
        private int ccm;

        //property
        public string Kuplung
        {
            get { return kuplung; }
            set { kuplung = value == "" ? "5 sebességes" : value; }
        }

        public int Tank
        {
            get { return tank; }
            set { tank = value <= 0 ? 1 : value; }
        }

        public int Ccm
        {
            get { return ccm; }
            set { ccm = value <= 0 ? 100 : value; }
        }

        //konstruktor
        public motor(double g, int sz, int s,string k, int t, int c) : base(g, sz, s)
        {
            Kuplung = k;
            Tank = t;
            Ccm = c;
        }

        //fv haladas
        public override string halad()
        {
            return "Húzom a gázt, azt repesztek mint a hülye.";
        }

        //fv tankolas (lokalis)
        public string tankolas()
        {
            if (ccm <= 1000)
            {
                return "Gazdaságos vagyok... :)";
            }
            else
            {
                return "Nyelem a pénzt!!";
            }
        }
    }
}
