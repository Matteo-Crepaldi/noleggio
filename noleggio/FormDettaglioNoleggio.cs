using noleggio_DLL;
using System.Windows.Forms;

namespace noleggio
{
    public partial class FormDettaglioNoleggio : Form
    {
        public FormDettaglioNoleggio(Noleggio n)
        {
            Cliente c = n.cliente;

            InitializeComponent();

            lblId.Text = n.ID.ToString();

            lblNomeCliente.Text = c.Nome;
            lblCognomeCliente.Text = c.Cognome;
            lblCodFiscCliente.Text = c.CodiceFiscale;

            lblTargaVeicolo.Text = n.veicolo.Targa;
            lblModelloVeicolo.Text = n.veicolo.Modello;
            lblTariffaVeicolo.Text = n.veicolo.Tariffa.ToString();
            lblTipoVeicolo.Text = n.veicolo.Tipo;
            lblImpegnatoVeicolo.Text = n.veicolo.Impegnato.ToString();
        }

        private void btnChiudiFD_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
