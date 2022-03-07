using noleggio_DLL;
using System;
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
            Cliente c;
            c = new Cliente(txtNomeC.Text, txtCognomeC.Text, txtCodiceFiscaleC.Text);
            cn.AddCliente(c);

            if (txtNomeC.Text == "" || txtCognomeC.Text == "" || txtCodiceFiscaleC.Text == "")
            {
                MessageBox.Show("Le textBox sono vuote");
            }
            Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            txtNomeC.Text = "";
            txtCognomeC.Text = "";
            txtCodiceFiscaleC.Text = "";

            Close();
        }
    }
}
