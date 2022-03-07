using noleggio_DLL;
using System;
using System.IO;
using System.Windows.Forms;

namespace noleggio
{
    public partial class FormCentroNoleggio : Form
    {
        CentroNoleggio cn = new CentroNoleggio("Rimini Noleggio");
        Veicolo v = new Veicolo();
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


        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            lstListaDeiClienti.Items.Clear();
            foreach (var itemC in cn.Clienti)
            {
                lstListaDeiClienti.Items.Add(itemC.GetInfo());
            }

            foreach (var itemV in cn.Veicoli)
            {
                lstListaDeiVeicoli.Items.Add(itemV.GetInfo());
            }

            foreach (var itemN in cn.Noleggi)
            {
                lstNoleggiEffettuati.Items.Add(itemN.GetInfo());
            }
        }

        private void btnEffettuaNoleggio_Click(object sender, EventArgs e)
        {
            // volevo fare che una volta che ho selezionato il veicolo mi apre la formNoleggio
            //v = cn.Veicoli[lstListaDeiVeicoli.SelectedIndex]; non funziona da errore
            FormNoleggio fn = new FormNoleggio(cn,v);

            if (lstListaDeiVeicoli.SelectedItems.Count==0)
            {
                MessageBox.Show("Non hai selezionato nessun veicolo!!");
            }
            else
            {
                fn.ShowDialog();
            }
        }

        private void btnCreaVeicolo_Click(object sender, EventArgs e)
        {
            FormVeicolo1 fa = new FormVeicolo1(cn);

            fa.ShowDialog();
        }

        private void FormCentroNoleggio_Load(object sender, EventArgs e)
        {

        }
    }
}
