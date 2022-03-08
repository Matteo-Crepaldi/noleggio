using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noleggio_DLL;

namespace noleggio
{
    public partial class FormNoleggio : Form
    {
        CentroNoleggio cn;
        public FormNoleggio(CentroNoleggio cn)
        {
            this.cn = cn;
            InitializeComponent();
        }

        private void btnAnnullaNoleggio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvaNoleggio_Click(object sender, EventArgs e)
        {
            Noleggio n;
            n = new Noleggio(Convert.ToDateTime(txtInizioNoleggio.Text),Convert.ToDateTime(txtFineNoleggio.Text));
            cn.AddNoleggi(n);
            
            Close();
        }
    }
}
