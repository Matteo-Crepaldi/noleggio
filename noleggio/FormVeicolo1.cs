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
        string targa, tariffa_string, modello;
        double tariffa = 0;
        bool errore;

        targa = txtTargaA.Text;
        tariffa_string = txtTariffaAF.Text;
        modello = txtModelloA.Text;

        if (targa != "" || tariffa_string != "" || modello != "")
        {
            bool esito;

            errore = false;

            try { tariffa = Convert.ToDouble(tariffa_string); }
            catch { errore = true; }

            if (errore == false)
            {
                if (rbAutomobile.Checked == true)
                {
                    errore = false;

                    string numPosti_string;
                    int numPosti = 0;
                    Automobile a;

                    numPosti_string = txtnumPostiA.Text;

                    try { numPosti = Convert.ToInt32(numPosti_string); }
                    catch { errore = true; }

                    if (errore == false && numPosti > 0)
                    {
                        a = new Automobile(targa, modello, tariffa, numPosti);
                        esito = cn.AddVeicolo(a);

                        if (esito == true) MessageBox.Show("Targa già esistente");
                        else
                        {
                            MessageBox.Show("Automobile creata con successo");
                            this.Close();
                        }
                    }
                    else MessageBox.Show("Inserire un numero di posti valido");
                }
                else if (rbFurgone.Checked == true)
                {
                    errore = false;

                    string capacita_string;
                    int capacita = 0;
                    Furgone f;

                    capacita_string = txtCapacitàF.Text;

                    try { capacita = Convert.ToInt32(capacita_string); }
                    catch { errore = true; }

                    if (errore == false && tariffa > 0)
                    {
                        f = new Furgone(targa, modello, tariffa, capacita);
                        esito = cn.AddVeicolo(f);

                        if (esito == true) MessageBox.Show("Targa già esistente");
                        else
                        {
                            MessageBox.Show("Furgone creato con successo");
                            this.Close();
                        }
                    }
                    else MessageBox.Show("Inserire una capacità valida");
                }
                else MessageBox.Show("Compilare tutti i campi");
            }
            else MessageBox.Show("Inserire una tariffa valida");
        }
        else MessageBox.Show("Compilare tutti i campi");
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

        private void btnAnnullaVeicolo_Click(object sender, EventArgs e)
        {
            txtTargaA.Text = "";
            txtModelloA.Text = "";
            txtTariffaAF.Text = "";
            rbAutomobile.Checked = false;
            rbFurgone.Checked = false;
            txtnumPostiA.Text = "";
            txtCapacitàF.Text = "";

            Close();
        }
    }
}   