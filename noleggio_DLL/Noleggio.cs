using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noleggio_DLL
{
    public class Noleggio
    {
        public int ID { get; }
        public DateTime DataInizio { get; }
        public int NumGiorni { get; }
        public double Costo { get; }

        public Noleggio(DateTime data)
        {
            ID = GeneraID();
            DataInizio = data;
        }

        public Noleggio()
        {
            ID = GeneraID();
            DataInizio = DateTime.Now;
        }

        private int GeneraID()
        {
            Random random = new Random();
            string charset = "1234567890", outString = "";

            for (int K = 0; K < 12; K++) outString += charset[random.Next(0, charset.Length)];

            return int.Parse(outString);
        }
    }
}
