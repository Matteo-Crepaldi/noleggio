﻿using noleggio_DLL;
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
            Close();
        }
    }
}
