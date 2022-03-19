using noleggio_DLL;
using System;
using System.IO;
using System.Windows.Forms;

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

            dI = dtpDataInizioNol.Value;
            dF = dtpDataFineNol.Value;

            if (DateTime.Now.CompareTo(dI) > 0 && DateTime.Now.CompareTo(dF) > 0)
            {
                MessageBox.Show("La data è passata");
            }
            else if (dI.CompareTo(dF) >= 0) MessageBox.Show("La seconda data deve essere successiva alla prima");
            else
            {
                n = new Noleggio(dtpDataInizioNol.Value, dtpDataFineNol.Value, cn.Veicoli, cn.Clienti, cn.Noleggi, v.Targa, c.CodiceFiscale);

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
