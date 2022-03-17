
namespace noleggio
{
    partial class FormCentroNoleggio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogInCliente = new System.Windows.Forms.Button();
            this.btnEffettuaNoleggio = new System.Windows.Forms.Button();
            this.lstListaDeiClienti = new System.Windows.Forms.ListBox();
            this.btnCreaVeicolo = new System.Windows.Forms.Button();
            this.lstListaDeiVeicoli = new System.Windows.Forms.ListBox();
            this.lstNoleggiEffettuati = new System.Windows.Forms.ListBox();
            this.btnDetNol = new System.Windows.Forms.Button();
            this.btnCalcolaTotali = new System.Windows.Forms.Button();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.lblListaNoleggiEffettuati = new System.Windows.Forms.Label();
            this.lblListaVeicoli = new System.Windows.Forms.Label();
            this.lblListaClienti = new System.Windows.Forms.Label();
            this.lblNomeCentroNoleggio = new System.Windows.Forms.Label();
            this.pnlGenerale = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnRimuoviNoleggio = new System.Windows.Forms.Button();
            this.pnlListe.SuspendLayout();
            this.pnlGenerale.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogInCliente
            // 
            this.btnLogInCliente.BackColor = System.Drawing.Color.White;
            this.btnLogInCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogInCliente.Location = new System.Drawing.Point(0, 46);
            this.btnLogInCliente.Name = "btnLogInCliente";
            this.btnLogInCliente.Size = new System.Drawing.Size(167, 40);
            this.btnLogInCliente.TabIndex = 1;
            this.btnLogInCliente.Text = "Crea il Cliente";
            this.btnLogInCliente.UseVisualStyleBackColor = false;
            this.btnLogInCliente.Click += new System.EventHandler(this.btnLogInCliente_Click);
            // 
            // btnEffettuaNoleggio
            // 
            this.btnEffettuaNoleggio.BackColor = System.Drawing.Color.White;
            this.btnEffettuaNoleggio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEffettuaNoleggio.Location = new System.Drawing.Point(0, 92);
            this.btnEffettuaNoleggio.Name = "btnEffettuaNoleggio";
            this.btnEffettuaNoleggio.Size = new System.Drawing.Size(186, 40);
            this.btnEffettuaNoleggio.TabIndex = 2;
            this.btnEffettuaNoleggio.Text = "Effettua Noleggio";
            this.btnEffettuaNoleggio.UseVisualStyleBackColor = false;
            this.btnEffettuaNoleggio.Click += new System.EventHandler(this.btnEffettuaNoleggio_Click);
            // 
            // lstListaDeiClienti
            // 
            this.lstListaDeiClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstListaDeiClienti.FormattingEnabled = true;
            this.lstListaDeiClienti.ItemHeight = 28;
            this.lstListaDeiClienti.Location = new System.Drawing.Point(0, 79);
            this.lstListaDeiClienti.Name = "lstListaDeiClienti";
            this.lstListaDeiClienti.Size = new System.Drawing.Size(280, 508);
            this.lstListaDeiClienti.TabIndex = 3;
            // 
            // btnCreaVeicolo
            // 
            this.btnCreaVeicolo.BackColor = System.Drawing.Color.White;
            this.btnCreaVeicolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreaVeicolo.Location = new System.Drawing.Point(0, 0);
            this.btnCreaVeicolo.Name = "btnCreaVeicolo";
            this.btnCreaVeicolo.Size = new System.Drawing.Size(143, 40);
            this.btnCreaVeicolo.TabIndex = 5;
            this.btnCreaVeicolo.Text = "Crea Veicolo";
            this.btnCreaVeicolo.UseVisualStyleBackColor = false;
            this.btnCreaVeicolo.Click += new System.EventHandler(this.btnCreaVeicolo_Click);
            // 
            // lstListaDeiVeicoli
            // 
            this.lstListaDeiVeicoli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstListaDeiVeicoli.FormattingEnabled = true;
            this.lstListaDeiVeicoli.ItemHeight = 28;
            this.lstListaDeiVeicoli.Location = new System.Drawing.Point(303, 79);
            this.lstListaDeiVeicoli.Name = "lstListaDeiVeicoli";
            this.lstListaDeiVeicoli.Size = new System.Drawing.Size(286, 508);
            this.lstListaDeiVeicoli.TabIndex = 6;
            // 
            // lstNoleggiEffettuati
            // 
            this.lstNoleggiEffettuati.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstNoleggiEffettuati.FormattingEnabled = true;
            this.lstNoleggiEffettuati.ItemHeight = 28;
            this.lstNoleggiEffettuati.Location = new System.Drawing.Point(607, 79);
            this.lstNoleggiEffettuati.Name = "lstNoleggiEffettuati";
            this.lstNoleggiEffettuati.Size = new System.Drawing.Size(311, 508);
            this.lstNoleggiEffettuati.TabIndex = 7;
            // 
            // btnDetNol
            // 
            this.btnDetNol.BackColor = System.Drawing.Color.White;
            this.btnDetNol.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetNol.Location = new System.Drawing.Point(0, 138);
            this.btnDetNol.Name = "btnDetNol";
            this.btnDetNol.Size = new System.Drawing.Size(186, 40);
            this.btnDetNol.TabIndex = 8;
            this.btnDetNol.Text = "Dettaglio Noleggio";
            this.btnDetNol.UseVisualStyleBackColor = false;
            this.btnDetNol.Click += new System.EventHandler(this.btnDetNol_Click);
            // 
            // btnCalcolaTotali
            // 
            this.btnCalcolaTotali.BackColor = System.Drawing.Color.White;
            this.btnCalcolaTotali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcolaTotali.Location = new System.Drawing.Point(0, 184);
            this.btnCalcolaTotali.Name = "btnCalcolaTotali";
            this.btnCalcolaTotali.Size = new System.Drawing.Size(247, 46);
            this.btnCalcolaTotali.TabIndex = 9;
            this.btnCalcolaTotali.Text = "Calcoli Targhe e CodFisc";
            this.btnCalcolaTotali.UseVisualStyleBackColor = false;
            this.btnCalcolaTotali.Click += new System.EventHandler(this.btnCalcolaTotali_Click);
            // 
            // pnlListe
            // 
            this.pnlListe.Controls.Add(this.lblListaNoleggiEffettuati);
            this.pnlListe.Controls.Add(this.lblListaVeicoli);
            this.pnlListe.Controls.Add(this.lblListaClienti);
            this.pnlListe.Controls.Add(this.lstNoleggiEffettuati);
            this.pnlListe.Controls.Add(this.lstListaDeiVeicoli);
            this.pnlListe.Controls.Add(this.lstListaDeiClienti);
            this.pnlListe.Location = new System.Drawing.Point(16, 91);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(918, 553);
            this.pnlListe.TabIndex = 10;
            // 
            // lblListaNoleggiEffettuati
            // 
            this.lblListaNoleggiEffettuati.AutoSize = true;
            this.lblListaNoleggiEffettuati.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaNoleggiEffettuati.ForeColor = System.Drawing.Color.White;
            this.lblListaNoleggiEffettuati.Location = new System.Drawing.Point(605, 9);
            this.lblListaNoleggiEffettuati.Name = "lblListaNoleggiEffettuati";
            this.lblListaNoleggiEffettuati.Size = new System.Drawing.Size(310, 50);
            this.lblListaNoleggiEffettuati.TabIndex = 15;
            this.lblListaNoleggiEffettuati.Text = "Noleggi in corso";
            // 
            // lblListaVeicoli
            // 
            this.lblListaVeicoli.AutoSize = true;
            this.lblListaVeicoli.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaVeicoli.ForeColor = System.Drawing.Color.White;
            this.lblListaVeicoli.Location = new System.Drawing.Point(303, 9);
            this.lblListaVeicoli.Name = "lblListaVeicoli";
            this.lblListaVeicoli.Size = new System.Drawing.Size(139, 50);
            this.lblListaVeicoli.TabIndex = 14;
            this.lblListaVeicoli.Text = "Veicoli";
            // 
            // lblListaClienti
            // 
            this.lblListaClienti.AutoSize = true;
            this.lblListaClienti.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaClienti.ForeColor = System.Drawing.Color.White;
            this.lblListaClienti.Location = new System.Drawing.Point(3, 9);
            this.lblListaClienti.Name = "lblListaClienti";
            this.lblListaClienti.Size = new System.Drawing.Size(134, 50);
            this.lblListaClienti.TabIndex = 13;
            this.lblListaClienti.Text = "Clienti";
            // 
            // lblNomeCentroNoleggio
            // 
            this.lblNomeCentroNoleggio.AutoSize = true;
            this.lblNomeCentroNoleggio.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCentroNoleggio.ForeColor = System.Drawing.Color.White;
            this.lblNomeCentroNoleggio.Location = new System.Drawing.Point(16, 18);
            this.lblNomeCentroNoleggio.Name = "lblNomeCentroNoleggio";
            this.lblNomeCentroNoleggio.Size = new System.Drawing.Size(517, 60);
            this.lblNomeCentroNoleggio.TabIndex = 11;
            this.lblNomeCentroNoleggio.Text = "Rimini Centro Noleggio";
            // 
            // pnlGenerale
            // 
            this.pnlGenerale.Controls.Add(this.pnlButton);
            this.pnlGenerale.Controls.Add(this.lblNomeCentroNoleggio);
            this.pnlGenerale.Controls.Add(this.pnlListe);
            this.pnlGenerale.Location = new System.Drawing.Point(15, 12);
            this.pnlGenerale.Name = "pnlGenerale";
            this.pnlGenerale.Size = new System.Drawing.Size(1205, 660);
            this.pnlGenerale.TabIndex = 12;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnRimuoviNoleggio);
            this.pnlButton.Controls.Add(this.btnCreaVeicolo);
            this.pnlButton.Controls.Add(this.btnLogInCliente);
            this.pnlButton.Controls.Add(this.btnDetNol);
            this.pnlButton.Controls.Add(this.btnCalcolaTotali);
            this.pnlButton.Controls.Add(this.btnEffettuaNoleggio);
            this.pnlButton.Location = new System.Drawing.Point(940, 170);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(250, 285);
            this.pnlButton.TabIndex = 12;
            // 
            // btnRimuoviNoleggio
            // 
            this.btnRimuoviNoleggio.BackColor = System.Drawing.Color.White;
            this.btnRimuoviNoleggio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRimuoviNoleggio.Location = new System.Drawing.Point(0, 236);
            this.btnRimuoviNoleggio.Name = "btnRimuoviNoleggio";
            this.btnRimuoviNoleggio.Size = new System.Drawing.Size(143, 48);
            this.btnRimuoviNoleggio.TabIndex = 9;
            this.btnRimuoviNoleggio.Text = "Rimuovi";
            this.btnRimuoviNoleggio.UseVisualStyleBackColor = false;
            this.btnRimuoviNoleggio.Click += new System.EventHandler(this.btnRimuoviNoleggio_Click);
            // 
            // FormCentroNoleggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1232, 684);
            this.Controls.Add(this.pnlGenerale);
            this.Name = "FormCentroNoleggio";
            this.Text = "Centro Noleggio";
            this.Load += new System.EventHandler(this.FormCentroNoleggio_Load);
            this.pnlListe.ResumeLayout(false);
            this.pnlListe.PerformLayout();
            this.pnlGenerale.ResumeLayout(false);
            this.pnlGenerale.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogInCliente;
        private System.Windows.Forms.Button btnEffettuaNoleggio;
        private System.Windows.Forms.ListBox lstListaDeiClienti;
        private System.Windows.Forms.Button btnCreaVeicolo;
        private System.Windows.Forms.ListBox lstListaDeiVeicoli;
        private System.Windows.Forms.ListBox lstNoleggiEffettuati;
        private System.Windows.Forms.Button btnDetNol;
        private System.Windows.Forms.Button btnCalcolaTotali;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Label lblNomeCentroNoleggio;
        private System.Windows.Forms.Panel pnlGenerale;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnRimuoviNoleggio;
        private System.Windows.Forms.Label lblListaNoleggiEffettuati;
        private System.Windows.Forms.Label lblListaVeicoli;
        private System.Windows.Forms.Label lblListaClienti;
    }
}

