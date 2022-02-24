using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noleggio_DLL
{
    public class CentroNoleggio
    {
        public string Nome { get; }
        public List<Veicolo> Veicoli { get; }

        public CentroNoleggio(string nome)
        {
            Nome = nome;
        }
    }
}
