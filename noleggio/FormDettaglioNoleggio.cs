using noleggio_DLL;
using System.Windows.Forms;

namespace noleggio
{
    public partial class FormDettaglioNoleggio : Form
    {
        Noleggio n;
        public FormDettaglioNoleggio(Noleggio n)
        {
            this.n = n;
            InitializeComponent();

            lblId.Text = n.ID.ToString();

            //lblNomeCliente.Text = n.cliente.Nome;
            //lblNomeCliente.Text = n.cliente.Cognome;
            //lblNomeCliente.Text = n.cliente.CodiceFiscale;

            lblTargaVeicolo.Text = n.veicolo.Targa;
            lblModelloVeicolo.Text = n.veicolo.Modello;
            lblTariffaVeicolo.Text = n.veicolo.Tariffa.ToString();
            lblTipoVeicolo.Text = n.veicolo.Tipo;
            lblImpegnatoVeicolo.Text = n.veicolo.Impegnato.ToString();
        }

        private void FormDettaglioNoleggio_Load(object sender, System.EventArgs e)
        {

        }

        private void btnChiudiFD_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
