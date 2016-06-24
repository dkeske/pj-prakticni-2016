using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnir2
{
    public class Teniser : Osoba
    {
        private int rang;
        private List<RezultatNaTurniru> listaRezultata;

        public Teniser(String ime, DateTime datum, int rang, List<RezultatNaTurniru> lista):base(ime, datum)
        {
            this.rang = rang;
            this.listaRezultata = lista;
        }

        public Teniser(String ime, DateTime datum, int rang) : base(ime, datum)
        {
            this.rang = rang;
            this.listaRezultata = new List<RezultatNaTurniru>();
        }

        public String daLiJePobedio(String imeTurnira)
        { //Prodjem kroz listu rezultata i gledam da li je rezultat pobednicki (max=osvojen) i 
          // gledam da li je turnir odgovarajuci (= parametru)
            String odgovor = "";
            foreach (RezultatNaTurniru rez in listaRezultata)
            {
                if(rez.Turnir.Naziv == imeTurnira)
                {
                    if(rez.OstvareniBrojPoena == rez.Turnir.MaxOstvariviBrojPoena)
                    {
                        odgovor += "Pobedio je , a tip je :" + rez.Turnir.VrstaTurnira;
                        break;
                    } else
                    {
                        odgovor += "Nije pobedio , a tip je :" + rez.Turnir.VrstaTurnira;
                        break;
                    }
                }
            }
            

            return odgovor;

        }

        public int vratiBrojTurnira()
        {
            // prodjem kroz listu, proverim da li je osvojio vise od pola max poena
            int broj = 0;

            for (int i = 0; i < listaRezultata.Count; i++)
            {
                RezultatNaTurniru rez = listaRezultata.ElementAt(i);
                if(rez.OstvareniBrojPoena > (rez.Turnir.MaxOstvariviBrojPoena / 2))
                {
                    broj++;
                }
            }

            return broj;
        }

        public List<String> igraoTokom2016()
        {
            List<String> lista = new List<String>();

            foreach (RezultatNaTurniru rez in listaRezultata)
            {
                if(rez.Turnir.Godina == 2016)
                {
                    lista.Add(rez.Turnir.Naziv);
                }
            }

            return lista;
        }

        public double prosekPoena(VrstaTurnira vrsta)
        {
            int sumaPoena = 0;
            int brojTurnira = 0;

            foreach (RezultatNaTurniru rez in listaRezultata)
            {
                if(rez.Turnir.VrstaTurnira == vrsta)
                {
                    sumaPoena += rez.OstvareniBrojPoena;
                    brojTurnira++;
                }
            }

            return sumaPoena / brojTurnira;
        }

        public bool daLiJeIzZemlje(String zemlja)
        {
            return ime.Contains(zemlja);
        }

        public bool daLiJeIzZemlje2(String zemlja)
        {
            String[] reci = ime.Split(' '); // Novak Djkokovic (SRB)  [Novak], [Djokovic], [(SRB)]
            String zem = reci[2]; // (SRB)
            String samoZem = zem.Substring(1, 3); // SRB
            return samoZem == zemlja; 
        }

        public List<RezultatNaTurniru> ListaRezultata
        {
            get
            {
                return listaRezultata;
            }

            set
            {
                listaRezultata = value;
            }
        }

        public int Rang
        {
            get
            {
                return rang;
            }

            set
            {
                rang = value;
            }
        }
    }
}
