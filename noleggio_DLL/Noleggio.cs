using System;

namespace noleggio_DLL
{
    public class Noleggio
    {
        public int ID { get; }
        public DateTime DataInizio { get; }
        public DateTime DataFine { get; }

        public int NumGiorni { get; set; }
        public double Costo { get; set; }

        public Noleggio(DateTime dataI, DateTime dataF, CentroNoleggio cn, Veicolo v)
        {
            ID = GeneraID(cn);
            DataInizio = dataI;
            DataFine = dataF;
            Costo = CostoVeicoloNoleggiato(v);
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
            return $"{ID};{v.Targa};{c.CodiceFiscale};{DataInizio};{DataFine};{Costo}";
        }
    }
}
