using System.Collections.Generic;

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

        public bool AddVeicolo(Veicolo v)
        {
            bool ripetuto = false;

            foreach(Veicolo veicolo in Veicoli)
            {
                if(veicolo.Targa == v.Targa) ripetuto = true;
            }

            if (ripetuto == false) Veicoli.Add(v);

            return ripetuto;
        }   

        public void AddCliente(Cliente c)
        {
            Clienti.Add(c);
        }
    }
}
