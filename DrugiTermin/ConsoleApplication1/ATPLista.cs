using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnir2;

namespace ConsoleApplication1
{
    class ATPLista
    {
        private String naziv;
        private int godina;
        private List<Teniser> listaTenisera;

        public List<String> prvihPet()
        {
            List<Teniser> prvihpet = new List<Teniser>();
            List<String> lista = new List<String>();

            foreach (Teniser t in listaTenisera)
            {
                if(t.Rang>=1 || t.Rang <= 5)
                {
                    prvihpet.Add(t);
                }
            }
            foreach (Teniser t1 in prvihpet)
            {
                String podatak = "Ime je " + t1.Ime + " , a broj: " + t1.ListaRezultata.Count;
            }
            return lista;
        }

        public int brojIzZemlje(String zemlja)
        {
            int broj = 0;

            foreach (Teniser ten in listaTenisera)
            {
                if (ten.Ime.Contains(zemlja))
                {
                    broj++;
                }
            }

            return broj;
        }

        public String zadnjiSlepac()
        {
            Teniser trenutniTeniser = listaTenisera.ElementAt(0);
            int trenutniRang = trenutniTeniser.Rang;

            foreach (Teniser teni in listaTenisera)
            {
                if(teni.Rang > trenutniRang)
                {
                    trenutniTeniser = teni;
                    trenutniRang = teni.Rang;
                }
            }

            return trenutniTeniser.Ime;

        }

        public List<Teniser> grendSlemovciIzSrbije()
        {
            List<Teniser> listaT = new List<Teniser>();

            foreach (Teniser ten in listaTenisera)
            {
                if (ten.Ime.Contains("SRB"))
                {
                    foreach (RezultatNaTurniru rez in ten.ListaRezultata)
                    {
                        if(rez.Turnir.VrstaTurnira == VrstaTurnira.GrandSlam)
                        {
                            listaT.Add(ten);
                        }
                    }
                }
            }

            return listaT;
        }

        public List<String> dvaTenisera(Teniser t1, Teniser t2)
        {
            List<String> imenaTurnira = new List<String>();

            foreach (RezultatNaTurniru rez1 in t1.ListaRezultata)
            {
                foreach (RezultatNaTurniru rez2 in t2.ListaRezultata)
                {
                    if(rez1.Turnir.Naziv == rez2.Turnir.Naziv 
                        && rez2.Turnir.MaxOstvariviBrojPoena == rez2.OstvareniBrojPoena)
                    {
                        imenaTurnira.Add(rez1.Turnir.Naziv);
                    }
                }
            }

            return imenaTurnira;
        }

        public ATPLista(String naziv, int godina)
        {
            this.naziv = naziv;
            this.godina = godina;
            listaTenisera = new List<Teniser>();
        }

        public List<Teniser> ListaTenisera
        {
            get
            {
                return listaTenisera;
            }

            set
            {
                listaTenisera = value;
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
                godina = value;
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

        static void Main(string[] args)
        {
        }
    }
}
