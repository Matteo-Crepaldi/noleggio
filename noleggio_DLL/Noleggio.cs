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

        public Noleggio(DateTime dataI,DateTime dataF)
        {
            ID = GeneraID();
            DataInizio = dataI;
            DataFine = dataF;
            Costo = CostoVeicolo();
        }

        public Noleggio()
        {
            ID = GeneraID();
            DataInizio = DateTime.Now;
        }

        public int GeneraID()
        {
            Random random = new Random();
            string charset = "1234567890", outString = "";

            for (int K = 0; K < 12; K++) outString += charset[random.Next(0, charset.Length)];

            return int.Parse(outString);
        }

        public double CostoVeicolo()
        {
            NumGiorni = Convert.ToInt32(DataInizio - DataFine);

            Costo = Convert.ToDouble(NumGiorni) * 10;

            return Costo;
        }

        public string GetInfo()
        {
            return $"{ID};{DataInizio};{DataFine};{Costo}";
        }
    }
}
