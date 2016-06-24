using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnir2
{
    public class RezultatNaTurniru
    {
        private Turnir turnir;
        private int ostvareniBrojPoena;

        public RezultatNaTurniru(Turnir turnir, int poeni)
        {
            this.turnir = turnir;
            this.ostvareniBrojPoena = poeni;
        }

        public int OstvareniBrojPoena
        {
            get
            {
                return ostvareniBrojPoena;
            }

            set
            {
                ostvareniBrojPoena = value;
            }
        }

        public Turnir Turnir
        {
            get
            {
                return turnir;
            }

            set
            {
                turnir = value;
            }
        }
    }
}
