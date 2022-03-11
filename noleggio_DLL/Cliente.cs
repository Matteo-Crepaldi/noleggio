using System.Collections.Generic;

namespace noleggio_DLL
{
    public class Cliente
    {
        public string Nome { get; }
        public string Cognome { get; }
        public string CodiceFiscale { get; }
        public List<Noleggio> NoleggiClienti { get; set; }

        public int IndiceSel { get; set; }

        public Cliente(string nome, string cognome, string codiceFiscale)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
            NoleggiClienti = new List<Noleggio>();
        }

        public Cliente(int IndiceSel)
        {
            this.IndiceSel = IndiceSel;
        }

        public string GetInfo()
        {
            return $"{Nome};{Cognome};{CodiceFiscale}";
        }

        public void AddNolC(Noleggio n)
        {
            NoleggiClienti.Add(n);
        }
    }
}
