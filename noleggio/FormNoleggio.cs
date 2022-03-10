using noleggio_DLL;
using System;
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
            n = new Noleggio(Convert.ToDateTime(txtInizioNoleggio.Text), Convert.ToDateTime(txtFineNoleggio.Text), cn, v);
            cn.AddNoleggi(n);
            v.AddNolV(n);
            c.AddNolC(n);

            Close();
        }
    }
}
