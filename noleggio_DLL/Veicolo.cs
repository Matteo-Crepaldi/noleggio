using System;
using System.Collections.Generic;

namespace noleggio_DLL
{
    public class Veicolo
    {
        public string Targa { get; }
        public string Modello { get; }
        public string Tipo { get; }
        public double Tariffa { get; }
        public bool Impegnato { get; protected set; }
        public List<Noleggio> Noleggi { get; set; }

        protected Veicolo(string targa, string modello, double tariffa)
        {
            Targa = targa;
            Modello = modello;
            Tariffa = tariffa;
            Impegnato = false;
            Noleggi = new List<Noleggio>();
        }

        public bool GetStatus()
        {
            return Impegnato;
        }

        public void Noleggia()
        {
            Noleggio n = new Noleggio();
            Noleggi.Add(n);
            Impegnato = true;
        }

        public void Noleggia(DateTime d)
        {
            Noleggio n = new Noleggio(d);
            Noleggi.Add(n);
            Impegnato = true;
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
