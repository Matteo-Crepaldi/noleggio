using noleggio_DLL;
using System.Windows.Forms;

namespace noleggio
{
    public partial class FormDettaglioNoleggio : Form
    {
        Veicolo v;
        Cliente c;
        public FormDettaglioNoleggio(Veicolo v, Cliente c)
        {
            this.v = v;
            this.c = c;
            InitializeComponent();
        }

        private void FormDettaglioNoleggio_Load(object sender, System.EventArgs e)
        {

        }

        private void btnSalvaNoleggio_Click(object sender, System.EventArgs e)
        {



            Close();
        }

        private void btnAnnullaCliente_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
