using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnir2
{
    public enum VrstaTurnira
    {
        Masters,
        GrandSlam,
        Drugi
    }
    public class Turnir
    {
        private String naziv;
        private int godina;
        private VrstaTurnira vrstaTurnira;
        private int maxOstvariviBrojPoena;

        public Turnir(String naziv, int godina, VrstaTurnira vrsta, int max)
        {
            this.naziv = naziv;
            this.godina = godina;
            this.vrstaTurnira = vrsta;
            this.maxOstvariviBrojPoena = max;

        }

        public VrstaTurnira VrstaTurnira
        {
            get
            {
                return vrstaTurnira;
            }

            set
            {
                vrstaTurnira = value;
            }
        }

        public int Godina
        {
            get
            {
                return godina;
            }

            set
            {
                if (value < 1900)
                {
                    Console.WriteLine("Nije dobra godina!");
                } else
                {
                    godina = value;
                }

            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public int MaxOstvariviBrojPoena
        {
            get
            {
                return maxOstvariviBrojPoena;
            }

            set
            {
                maxOstvariviBrojPoena = value;
            }
        }
    }
}
