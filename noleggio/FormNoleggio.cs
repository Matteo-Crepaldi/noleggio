using noleggio_DLL;
using System;
using System.Windows.Forms;
using System.IO;

namespace noleggio
{
    public partial class FormNoleggio : Form
    {
        CentroNoleggio cn;
        Veicolo v;
        Cliente c;

        public FormNoleggio(CentroNoleggio cn, Veicolo v, Cliente c)
        {
            this.cn = cn;
            this.v = v;
            this.c = c;
            InitializeComponent();
        }

        private void btnAnnullaNoleggio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvaNoleggio_Click(object sender, EventArgs e)
        {
            Noleggio n;
            DateTime dI;
            DateTime dF;

            dI = Convert.ToDateTime(txtInizioNoleggio.Text);
            dF = Convert.ToDateTime(txtFineNoleggio.Text);

            if (DateTime.Now.CompareTo(dI) > 0 && DateTime.Now.CompareTo(dF) > 0)
            {
                MessageBox.Show("Targà già esistente");
            }
            else
            {
                n = new Noleggio(Convert.ToDateTime(txtInizioNoleggio.Text), Convert.ToDateTime(txtFineNoleggio.Text), cn.Veicoli, cn.Clienti, cn.Noleggi, v.Targa, c.CodiceFiscale);
                v.Impegnato = true;

                cn.AddNoleggi(n);
                v.AddNolV(n);
                c.AddNolC(n);

                SalvaDati(n);

                Close();
            }
        }

        private void SalvaDati(Noleggio n)
        {
            StreamWriter st = File.AppendText(cn.GetPath() + "\\noleggi.csv");
            st.WriteLine($"{n.DataInizio};{n.DataFine};{n.veicolo.Targa};{n.cliente.CodiceFiscale};");
            st.Close();
        }
    }
}
