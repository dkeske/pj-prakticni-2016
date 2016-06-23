using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATPLista
{
    public class RezultatNaTurniru
    {
        private int brojOsvojenihPoena;
        private Turnir turnir;

        public RezultatNaTurniru(int brojP, Turnir turnir)
        {
            this.brojOsvojenihPoena = brojP;
            this.turnir = turnir;
        }

        public int BrojOsvojenihPoena
        {
            get
            {
                return brojOsvojenihPoena;
            }

            set
            {
                brojOsvojenihPoena = value;
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
