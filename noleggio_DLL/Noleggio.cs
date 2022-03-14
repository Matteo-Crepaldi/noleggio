using System;
using System.Linq;

namespace noleggio_DLL
{
    public class Noleggio
    {
        public int ID { get; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public int NumGiorni { get; set; }
        public double Costo { get; set; }

        public Veicolo veicolo { get; set; }

        public Cliente cliente { get; set; }

        public Noleggio(DateTime dataI, DateTime dataF, CentroNoleggio cn, Veicolo veicolo, string codiceFiscale)
        {
            ID = GeneraID(cn);
            DataInizio = dataI;
            DataFine = dataF;
            Costo = CostoVeicoloNoleggiato(veicolo);
            this.veicolo = veicolo;

            cliente = cn.Clienti.First(c => c.CodiceFiscale == codiceFiscale);
        }

        public Noleggio(DateTime dataI, DateTime dataF, CentroNoleggio cn, Veicolo veicolo)
        {
            ID = GeneraID(cn);
            DataInizio = dataI;
            DataFine = dataF;
            Costo = CostoVeicoloNoleggiato(veicolo);
            this.veicolo = veicolo;
        }

        public int GeneraID(CentroNoleggio cn)
        {
            if (cn.Noleggi.Count == 0)
            {
                return 1;
            }
            else
            {
                Noleggio nol = cn.Noleggi[cn.Noleggi.Count - 1];

                return nol.ID + 1;
            }
        }

        public double CostoVeicoloNoleggiato(Veicolo v)
        {
            NumGiorni = Convert.ToInt32((DataFine - DataInizio).Days);

            Costo = Convert.ToDouble(NumGiorni) * v.Tariffa;

            return Costo;
        }

        public string GetInfo(Veicolo v, Cliente c)
        {
            return $"{ID};{v.Targa};{c.CodiceFiscale};{NumGiorni};{Costo}";
        }
    }
}
