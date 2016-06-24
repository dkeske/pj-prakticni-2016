using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATPLista;

namespace ConsoleApplication1
{
    class ATP_Lista
    {
        private int godina;
        private String naziv;
        private List<Teniser> listaTenisera;

        public List<String> imeIBrojZaPrvihPet()
        {
            List<String> listaInfo = new List<String>();
            List<Teniser> listaPrvihPet = new List<Teniser>();
            foreach (Teniser t1 in ListaTenisera)
            {
                if(t1.Rang >=1 || t1.Rang <= 5)
                {
                    listaPrvihPet.Add(t1);
                }
            }
            foreach (Teniser t in listaPrvihPet)
            {
                int brojTurnira = t.ListaRezultata.Count();
                String info = "Ime tenisera: " + t.Ime + " ,broj turnira: " + brojTurnira;
                listaInfo.Add(info);

            }
            return listaInfo;
        }

        public List<String> imeIBrojZaPrvihPetTip2()
        {
            List<String> listaInfo = new List<String>();
            foreach (Teniser t1 in ListaTenisera)
            {
                if (t1.Rang >= 1 || t1.Rang <= 5)
                {
                    int brojTurnira = t1.ListaRezultata.Count();
                    String info = "Ime tenisera: " + t1.Ime + " ,broj turnira: " + brojTurnira;
                    listaInfo.Add(info);
                }
            }
            
            return listaInfo;
        }

        public bool DaLiJePrviPobediSveGrandSlam()
        {
            List<Turnir> listaTurnira = new List<Turnir>();
            
            foreach (Teniser t in listaTenisera)
            {
                if (t.Rang == 1)
                {
                    prvi = t;
                }
                foreach (RezultatNaTurniru rez in t.ListaRezultata)
                {
                    if (rez.Turnir.VrstaTurnira == VrstaTurnira.GrandSlam && !listaTurnira.Contains(rez.Turnir))
                    {
                        listaTurnira.Add(rez.Turnir);
                    }
                }
            }
            foreach (Turnir tur in listaTurnira)
            {
                foreach (RezultatNaTurniru rezultat in prvi.ListaRezultata)
                {

                }
            }
        }

        public String poslednjiNaListi()
        {
            String ime = "";
            int rang = 0;
            foreach (Teniser r in listaTenisera)
            {
                if(r.Rang > rang)
                {
                    rang = r.Rang;
                    ime = r.Ime;
                }
            }
            return ime;
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

        static void Main(string[] args)
        {
        }
    }
}
