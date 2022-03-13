using System.Collections.Generic;
using System.IO;

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

            LoadFiles(GetPath());
        }

        private string GetPath()
        {
            string path, dirPath = "";
            string[] args;

            path = Directory.GetCurrentDirectory();
            args = path.Split('\\');

            for (int K = 0; K < args.Length - 3; K++) dirPath += $"{args[K]}\\";

            return dirPath + "files\\";
        }

        private void LoadFiles(string path)
        {
            string nome, cognome, cf, targa, modello, tipo;
            double tariffa;
            string[] veicoliArray, clientiArray, noleggiArray, args;

            veicoliArray = File.ReadAllText(path + "\\veicoli.csv").Split('\n');
            clientiArray = File.ReadAllText(path + "\\clienti.csv").Split('\n');
            noleggiArray = File.ReadAllText(path + "\\noleggi.csv").Split('\n');

            foreach (string infocliente in clientiArray)
            {
                args = infocliente.Split(';');

                nome = args[0];
                cognome = args[1];
                cf = args[2];

                Clienti.Add(new Cliente(nome, cognome, cf));
            }

            foreach(string infoVeicolo in veicoliArray)
            {
                args = infoVeicolo.Split(';');

                targa = args[0];
                modello = args[1];
                tariffa = double.Parse(args[2]);
                tipo = args[4];

                if(tipo == "Automobile")
                {
                    Automobile a;
                    int numPosti = int.Parse(args[3]);

                    a = new Automobile(targa, modello, tariffa, numPosti);
                    Veicoli.Add(a);
                }
                else
                {
                    Furgone f;
                    int capacita = int.Parse(args[3]);

                    f = new Furgone(targa, modello, tariffa, capacita);
                    Veicoli.Add(f);
                }
            }

            foreach(string infoNoleggio in noleggiArray)
            {

            }
        }

        public bool AddVeicolo(Veicolo v)
        {
            bool ripetuto = false;

            foreach (Veicolo veicolo in Veicoli)
            {
                if (veicolo.Targa == v.Targa) ripetuto = true;
            }

            if (ripetuto == false) Veicoli.Add(v);

            return ripetuto;
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
