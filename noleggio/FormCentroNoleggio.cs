using noleggio_DLL;
using System;
using System.Windows.Forms;

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
            lstListaDeiClienti.Items.Clear();

            foreach (var itemC in cn.Clienti) lstListaDeiClienti.Items.Add(itemC.GetInfo());
            foreach (var itemV in cn.Veicoli) lstListaDeiVeicoli.Items.Add(itemV.GetInfo());
            foreach (var itemN in cn.Noleggi) lstNoleggiEffettuati.Items.Add(itemN.GetInfo());
        }

        private void btnEffettuaNoleggio_Click(object sender, EventArgs e)
        {
            int selected_indexV, selected_indexC;
            Veicolo v;
            Cliente c;

            selected_indexV = lstListaDeiVeicoli.SelectedIndex;
            selected_indexC = lstListaDeiClienti.SelectedIndex;

            if (selected_indexV == -1 && selected_indexC == -1) MessageBox.Show("Selezionare un veicolo dalla lista veicoli");
            else
            {
                v = cn.Veicoli[selected_indexV];
                c = cn.Clienti[selected_indexC];
                FormNoleggio fn = new FormNoleggio(cn, v, c);

                fn.ShowDialog();
            }
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
                FormDettaglioNoleggio fdm = new FormDettaglioNoleggio();

                fdm.ShowDialog();
            }
        }
    }
}
