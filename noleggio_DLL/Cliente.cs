using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noleggio_DLL
{
    public class Cliente
    {
        public string Nome { get; }
        public string Cognome { get; }
        public string CodiceFiscale { get; }

        public Cliente(string nome, string cognome, string codiceFiscale)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
        }
    }
}
