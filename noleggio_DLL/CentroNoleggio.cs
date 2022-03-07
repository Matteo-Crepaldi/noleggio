﻿using System.Collections.Generic;

namespace noleggio_DLL
{
    public class CentroNoleggio
    {
        public string Nome { get; }
        public List<Veicolo> Veicoli { get; }
        public List<Cliente> Clienti { get; }
        public List<Noleggio> Noleggi { get; }

        public CentroNoleggio(string nome)
        {
            Nome = nome;

            Veicoli = new List<Veicolo>();
            Clienti = new List<Cliente>();
            Noleggi = new List<Noleggio>();
        }

        public void AddVeicolo(Veicolo v)
        {
            Veicoli.Add(v);
        }

        public void AddCliente(Cliente c)
        {
            Clienti.Add(c);
        }

        public void AddNoleggi(Noleggio n)
        {
            Noleggi.Add(n);
        }
    }
}
