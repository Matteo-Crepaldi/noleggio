using System;
using System.Collections.Generic;

namespace noleggio_DLL
{
    public class Veicolo
    {
        public string Targa { get; }
        public string Modello { get; }
        public string Tipo { get; set; }
        public double Tariffa { get; }
        public bool Impegnato { get; protected set; }
        public List<Noleggio> NoleggiVeicoli { get; set; }
        public int IndiceSel { get; set; }

        protected Veicolo(string targa, string modello, double tariffa)
        {
            Targa = targa;
            Modello = modello;
            Tariffa = tariffa;
            Impegnato = false;
            NoleggiVeicoli = new List<Noleggio>();
        }

        public Veicolo(int IndiceSel)
        {
            this.IndiceSel = IndiceSel;
        }

        public bool GetStatus()
        {
            return Impegnato;
        }

        public void Noleggia(DateTime dI, DateTime dF, CentroNoleggio cn, Veicolo v)
        {
            Noleggio n = new Noleggio(dI, dF, cn, v);
            NoleggiVeicoli.Add(n);
            Impegnato = true;
        }

        public void AddNolV(Noleggio n)
        {
            NoleggiVeicoli.Add(n);
        }

        public virtual string GetInfo() { return ""; }
    }

    public class Automobile : Veicolo
    {
        public int NumPosti { get; }

        public Automobile(string targa, string modello, double tariffa, int numPosti) : base(targa, modello, tariffa)
        {
            NumPosti = numPosti;
        }

        public override string GetInfo()
        {
            return $"{Targa};{Modello};{Tariffa};{NumPosti}";
        }
    }

    public class Furgone : Veicolo
    {
        public int Capacita { get; }

        public Furgone(string targa, string modello, double tariffa, int capacita) : base(targa, modello, tariffa)
        {
            Capacita = capacita;
        }

        public override string GetInfo()
        {
            return $"{Targa};{Modello};{Tariffa};{Capacita}";
        }
    }
}
