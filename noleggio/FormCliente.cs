using noleggio_DLL;
using System;
using System.IO;
using System.Windows.Forms;

namespace noleggio
{
    public partial class FormCliente : Form
    {
        CentroNoleggio cn;

        public FormCliente(CentroNoleggio cn)
        {
            this.cn = cn;
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nome, cognome, codiceFiscale;
            bool ripetuto = false;
            Cliente c;

            nome = txtNomeC.Text;
            cognome = txtCognomeC.Text;
            codiceFiscale = txtCodiceFiscaleC.Text;

            foreach (Cliente cl in cn.Clienti)
            {
                if (cl.CodiceFiscale == codiceFiscale) ripetuto = true;
            }

            if (nome != "" && cognome != "" && codiceFiscale != "" && ripetuto == false)
            {
                c = new Cliente(nome, cognome, codiceFiscale);
                cn.Clienti.Add(c);

                MessageBox.Show("Clinte aggiunto con successo");
                Close();

                SalvaDati(c);
            }
            else if (ripetuto == true) MessageBox.Show("Codice fiscale già esistente");
            else MessageBox.Show("Compilare tutti i campi");
        }

        private void SalvaDati(Cliente c)
        {
            StreamWriter st = File.AppendText(cn.GetPath() + "\\clienti.csv");
            st.WriteLine(c.GetInfo());
            st.Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
