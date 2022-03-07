﻿using System;
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
        Veicolo v;
        public FormNoleggio(CentroNoleggio cn, Veicolo v)
        {
            this.cn = cn;
            this.v = v;
            InitializeComponent();
        }

        private void btnAnnullaNoleggio_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtInizioNoleggio.Text = "";
            txtFineNoleggio.Text = "";

            Close();
        }

        private void btnSalvaNoleggio_Click(object sender, EventArgs e)
        {
            Noleggio n;
            n = new Noleggio(Convert.ToDateTime(txtInizioNoleggio.Text),Convert.ToDateTime(txtFineNoleggio.Text));
            txtID.Text = n.GeneraID().ToString();
            txtCosto.Text = n.CostoVeicolo().ToString();
            cn.AddNoleggi(n);
            
            Close();
        }
    }
}