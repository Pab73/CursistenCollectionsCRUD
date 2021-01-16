using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17._1
{
    class Cursist
    {
        //attributen
        private string _familieNaam;
        private string _voorNaam;

        //default constructor
        public Cursist()
        {
            _familieNaam = "";
            _voorNaam = "";
        }
        public Cursist(string familieNaam, string voorNaam)
        {
            this.FamilieNaam = familieNaam;
            this.VoorNaam = voorNaam;
        }
        public string FamilieNaam
        {
            get { return _familieNaam; }
            set { _familieNaam = value; }
        }
        public string VoorNaam
        {
            get { return _voorNaam; }
            set { _voorNaam = value; }
        }
        public string Naam
        {
            get { return _voorNaam + " " + _familieNaam; }
        }
    }
}
