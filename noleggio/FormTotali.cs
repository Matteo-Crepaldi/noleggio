using noleggio_DLL;
using System;
using System.Windows.Forms;

namespace noleggio
{
    public partial class FormTotali : Form
    {
        CentroNoleggio cn;
        public FormTotali(CentroNoleggio cn)
        {
            this.cn = cn;
            InitializeComponent();

            foreach (var itemV in cn.Veicoli)
            {
                cmbTargaCF.Items.Add(itemV.Targa);
            }
        }

        private void FormTotali_Load(object sender, EventArgs e)
        {

        }

        private void rbTargheVeicoli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTargheVeicoli.Checked == true)
            {
                cmbTargaCF.Items.Clear();
                foreach (var itemV in cn.Veicoli)
                {
                    cmbTargaCF.Items.Add(itemV.Targa);
                }
            }
        }

        private void rbCodFiscClienti_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodFiscClienti.Checked == true)
            {
                cmbTargaCF.Items.Clear();
                foreach (var itemC in cn.Clienti)
                {
                    cmbTargaCF.Items.Add(itemC.CodiceFiscale);
                }
            }
        }

        private void cmbTargaCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            double costo = 0;

            Veicolo v;
            if (rbTargheVeicoli.Checked == true)
            {

                v = cn.CercaVeicolo(cmbTargaCF.Text);
                MessageBox.Show(v.NoleggiVeicoli.Count.ToString() + " " + v.Targa);
                foreach (var item in v.NoleggiVeicoli)
                {
                    costo += item.Costo;
                }

                lblTotali.Text = costo.ToString();
            }

            v = cn.CercaVeicolo(cmbTargaCF.Text);
            foreach (var item in v.NoleggiVeicoli)
            {
                lstNoleggi.Items.Add(item.GetInfo());
            }
        }
    }
}
