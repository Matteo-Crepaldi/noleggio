using noleggio_DLL;
using System;
using System.Windows.Forms;
using System.Linq;

namespace noleggio
{
    public partial class FormCentroNoleggio : Form
    {
        CentroNoleggio cn = new CentroNoleggio("Rimini Noleggio");

        public FormCentroNoleggio()
        {
            InitializeComponent();
            AggiornaLists();
        }

        private void btnLogInCliente_Click(object sender, EventArgs e)
        {
            FormCliente fc = new FormCliente(cn);
            fc.ShowDialog();

            AggiornaLists();
        }

        private void AggiornaLists()
        {
            bool noleggiato;

            lstListaDeiClienti.Items.Clear();
            lstListaDeiVeicoli.Items.Clear();
            lstNoleggiEffettuati.Items.Clear();

            foreach (Cliente c in cn.Clienti) lstListaDeiClienti.Items.Add(c.GetInfo());

            foreach (Veicolo v in cn.Veicoli)
            {
                noleggiato = true;

                try { cn.Noleggi.First(n => n.veicolo.Targa == v.Targa); }
                catch { noleggiato = false; }

                if(noleggiato == false) lstListaDeiVeicoli.Items.Add(v.GetInfo());
            }

            foreach (Noleggio n in cn.Noleggi) lstNoleggiEffettuati.Items.Add(n.GetInfo());
        }

        private void btnEffettuaNoleggio_Click(object sender, EventArgs e)
        {
            int selected_indexV, selected_indexC;
            Veicolo v;
            Cliente c;

            selected_indexV = lstListaDeiVeicoli.SelectedIndex;
            selected_indexC = lstListaDeiClienti.SelectedIndex;

            c = new Cliente(selected_indexC);
            v = new Veicolo(selected_indexV);

            if (selected_indexV == -1 || selected_indexC == -1) MessageBox.Show("Selezionare un veicolo dalla lista veicoli");
            else
            {
                v = cn.Veicoli[selected_indexV];
                c = cn.Clienti[selected_indexC];
                FormNoleggio fn = new FormNoleggio(cn, v, c);

                fn.ShowDialog();
            }

            AggiornaLists();
        }

        private void btnCreaVeicolo_Click(object sender, EventArgs e)
        {
            FormVeicolo1 fa = new FormVeicolo1(cn);
            fa.ShowDialog();

            AggiornaLists();
        }

        private void btnDetNol_Click(object sender, EventArgs e)
        {
            int selezionaNol;
            Noleggio n;

            selezionaNol = lstNoleggiEffettuati.SelectedIndex;

            if (selezionaNol == -1) MessageBox.Show("Selezionare un noleggio dalla lista noleggi");
            else
            {
                n = cn.Noleggi[selezionaNol];
                FormDettaglioNoleggio fdm = new FormDettaglioNoleggio(n);

                fdm.ShowDialog();
            }
        }
    }
}
