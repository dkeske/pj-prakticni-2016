using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnir2
{
    public class Osoba
    {
        protected String ime;  // Novak Djokovic (SRB)
        protected DateTime datumRodjenja;

        public Osoba(String ime, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.datumRodjenja = datumRodjenja;
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }
    }
}
