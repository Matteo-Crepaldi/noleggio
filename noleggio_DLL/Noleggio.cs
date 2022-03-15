using System;
using System.Linq;
using System.Collections.Generic;

namespace noleggio_DLL
{
    public class Noleggio
    {
        public int ID { get; }
        public DateTime DataInizio { get; private set; }
        public DateTime DataFine { get; private set; }
        public int NumGiorni { get; private set; }
        public double Costo { get; private set; }
        public Veicolo veicolo { get; private set; }
        public Cliente cliente { get; private set; }
        public List<Cliente> Clienti { get; private set; }
        public List<Veicolo> Veicoli { get; private set; }
        public List<Noleggio> Noleggi { get; private set; }

        public Noleggio(DateTime dataI, DateTime dataF, List<Veicolo> veicoli, List<Cliente> clienti, List<Noleggio> noleggi, string targaVeicolo, string codiceFiscale)
        {
            Clienti = clienti;
            Veicoli = veicoli;
            Noleggi = noleggi;

            cliente = Clienti.First(c => c.CodiceFiscale == codiceFiscale);
            veicolo = Veicoli.First(v => v.Targa == targaVeicolo);

            DataInizio = dataI;
            DataFine = dataF;

            ID = GeneraID(noleggi);
            Costo = CostoVeicoloNoleggiato(veicolo);
        }

        public int GeneraID(List<Noleggio> noleggi)
        {
            if (noleggi.Count == 0)
            {
                return 1;
            }
            else
            {
                Noleggio nol = noleggi[noleggi.Count - 1];

                return nol.ID + 1;
            }
        }

        public double CostoVeicoloNoleggiato(Veicolo v)
        {
            NumGiorni = Convert.ToInt32((DataFine - DataInizio).Days);

            Costo = Convert.ToDouble(NumGiorni) * v.Tariffa;

            return Costo;
        }

        public string GetInfo()
        {
            return $"{ID};{veicolo.Targa};{cliente.CodiceFiscale};{NumGiorni};{Costo}";
        }
    }
}
