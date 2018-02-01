using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class bicikli : ketkerekuek
    {
        private string pedalmarka;

        //property
        public string Pedalmarka
        {
            get { return pedalmarka; }
            set { pedalmarka = value == "" ? "Csepel" : value; }
        }

        //konstruktor
        public bicikli(double g, int sz, int s, string p) : base(g, sz, s)
        {
            Pedalmarka = p;
        }

        //kerekpar fv
        public override string halad()
        {
            return "Jól meg kell tekerni a pedálokat.";
        }
    }
}
