﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noleggio_DLL
{
    public class Veicolo
    {
        public string Targa { get; } 
        public string Modello { get; }
        public int Tariffa { get; }
        private bool Impegnato { get; set; }
        public List<Noleggio> Noleggi { get; }

        protected Veicolo(string targa, string modello, int tariffa) 
        {
            Targa = targa;
            Modello = modello;
            Tariffa = tariffa;
            Impegnato = false;
            Noleggi = new List<Noleggio>();
        }

        public bool GetStatus()
        {
            bool status = Impegnato;
            return status;
        }

        public void Noleggia()
        {
            Noleggio n = new Noleggio();
            Noleggi.Add(n);
            Impegnato = true;
        }
    }

    public class Automobile : Veicolo
    {
        public int NumPosti { get; }

        public Automobile(string targa, string modello, int tariffa, int numPosti) : base(targa, modello, tariffa)
        {
            NumPosti = numPosti;
        }
    }

    public class Furgone : Veicolo
    {
        public int CaricoMassimo { get; }

        public Furgone(string targa, string modello, int tariffa, int caricoMassimo) : base(targa, modello, tariffa)
        {
            CaricoMassimo = caricoMassimo;
        }
    }
}
