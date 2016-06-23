using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATPLista
{
    public class Teniser : Osoba
    {
        private int rang;
        private List<RezultatNaTurniru> listaRezultata;

        public Teniser(String ime, DateTime datum, int rang, List<RezultatNaTurniru> listaR):base(ime, datum)
        {
            this.rang = rang;
            this.listaRezultata = listaR;
        }

        public Teniser(String ime, DateTime datum, int rang) : base(ime, datum)
        {
            this.rang = rang;
            this.listaRezultata = new List<RezultatNaTurniru>();
        }

        public bool daLiJeIzZemlje(String zemlja) // "GER"
        { // Novak Djokovic (SRB)
            // String ime = this.ime;
            // return ime.Contains(zemlja);
            if (ime.Contains(zemlja))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool daLiJeIgraoNaSvim(String grupa)
        {

        }

        public bool daLiJePobedio(Turnir param)
        {
            // Prodjem kroz rezultate, poredimo broj poena koji je ostvario, i max poene na turniru
            //takodje, moramo da utvrdimo ta je to stvarno prosledjeni turnir
            foreach (RezultatNaTurniru rezultat in listaRezultata)
            {
                if(rezultat.BrojOsvojenihPoena == rezultat.Turnir.MaxOstvariviBrojPoena && rezultat.Turnir == param)
                {
                    //if(rezultat.Turnir == param)
                    //{
                        return true;
                    //}
                }
            }

            return false;
        }

        public int naKolikoViseOdPola()
        {
            //prodjemo kroz rezultate i poredimo da li je broj poena veci od polovine max broja
            int i = 0;
            foreach (RezultatNaTurniru rez in listaRezultata)
            {
                if(rez.BrojOsvojenihPoena > rez.Turnir.MaxOstvariviBrojPoena / 2)
                {
                    i++;
                }
            }
            return i;

        }

        public List<String> imenaTurniraTokom2016()
        {
            // prazna lista stringova. prolazim kroz rezultate. 
            // ako je turnir u 2016toj godini, onda ubacim u listu. vratim listu
            List<String> imenaTurnira = new List<String>();
            foreach (RezultatNaTurniru rez in listaRezultata)
            {
                if (rez.Turnir.Godina == 2016)
                {
                    imenaTurnira.Add(rez.Turnir.Naziv);
                }
            }
            return imenaTurnira;
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
