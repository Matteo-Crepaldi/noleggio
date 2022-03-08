using noleggio_DLL;
using System;
using System.IO;
using System.Windows.Forms;

namespace noleggio
{
    public partial class FormCentroNoleggio : Form
    {
        CentroNoleggio cn = new CentroNoleggio("Rimini Noleggio");

        public FormCentroNoleggio()
        {
            InitializeComponent();
        }

        string GetDirPath()
        {
            string path, dirPath = "";
            string[] args;

            path = Directory.GetCurrentDirectory();
            args = path.Split('\\');

            for (int K = 0; K < args.Length - 3; K++) dirPath += $"{args[K]}\\";

            return dirPath + "files\\";
        }

        private void btnLogInCliente_Click(object sender, EventArgs e)
        {
            FormCliente fc = new FormCliente(cn);
            fc.ShowDialog();

            AggiornaLists();
        }

        private void AggiornaLists()
        {
            lstListaDeiClienti.Items.Clear();

            foreach (var itemC in cn.Clienti) lstListaDeiClienti.Items.Add(itemC.GetInfo());
            foreach (var itemV in cn.Veicoli) lstListaDeiVeicoli.Items.Add(itemV.GetInfo());
            foreach (var itemN in cn.Noleggi) lstNoleggiEffettuati.Items.Add(itemN.GetInfo());
        }

        private void btnEffettuaNoleggio_Click(object sender, EventArgs e)
        {
            int selected_index;
            Veicolo v;

            selected_index = lstListaDeiVeicoli.SelectedIndex;

            if (selected_index == -1) MessageBox.Show("Selezionare un veicolo dalla lista veicoli");
            else
            {
                v = cn.Veicoli[selected_index];
            }
        }

        private void btnCreaVeicolo_Click(object sender, EventArgs e)
        {
            FormVeicolo1 fa = new FormVeicolo1(cn);
            fa.ShowDialog();

            AggiornaLists();
        }
    }
}
