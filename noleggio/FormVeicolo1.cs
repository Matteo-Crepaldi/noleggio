using noleggio_DLL;
using System;
using System.Windows.Forms;

namespace noleggio
{
    public partial class FormVeicolo1 : Form
    {
        CentroNoleggio cn;
        public FormVeicolo1(CentroNoleggio cn)
        {
            this.cn = cn;
            InitializeComponent();
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (rbAutomobile.Checked != false && true) { MessageBox.Show("Error,Seleziona un radioButton"); }

            if (rbFurgone.Checked != false && true) { MessageBox.Show("Error,Seleziona un radioButton"); }

            if (txtTargaA.Text == "" || txtTariffaAF.Text == "" || txtModelloA.Text == "" || txtnumPostiA.Text == "" || txtCapacitàF.Text == "")
            {
                MessageBox.Show("le textBox sono vuote");
            }

            if (rbAutomobile.Checked == true)
            {
                Automobile a = new Automobile(txtTargaA.Text, txtModelloA.Text, Convert.ToInt32(txtTariffaAF.Text), Convert.ToInt32(txtnumPostiA.Text));
                cn.AddVeicolo(a);
            }
            else
            {
                Furgone f = new Furgone(txtTargaA.Text, txtModelloA.Text, Convert.ToInt32(txtTariffaAF.Text), Convert.ToInt32(txtCapacitàF.Text));
                cn.AddVeicolo(f);
            }
            Close();
        }

        private void rbAutomobile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutomobile.Checked == true)
            {
                lblnumPostiAutomobile.Visible = true;
                txtnumPostiA.Visible = true;
                lblCapacitàFurgone.Visible = false;
                txtCapacitàF.Visible = false;
            }
        }

        private void rbFurgone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFurgone.Checked == true)
            {
                lblnumPostiAutomobile.Visible = false;
                txtnumPostiA.Visible = false;
                lblCapacitàFurgone.Visible = true;
                txtCapacitàF.Visible = true;
            }
        }

        private void FormVeicolo1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
