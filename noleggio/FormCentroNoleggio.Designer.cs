﻿
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
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.btnCreaVeicolo = new System.Windows.Forms.Button();
            this.lstListaDeiVeicoli = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLogInCliente
            // 
            this.btnLogInCliente.BackColor = System.Drawing.Color.White;
            this.btnLogInCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogInCliente.Location = new System.Drawing.Point(12, 12);
            this.btnLogInCliente.Name = "btnLogInCliente";
            this.btnLogInCliente.Size = new System.Drawing.Size(186, 54);
            this.btnLogInCliente.TabIndex = 1;
            this.btnLogInCliente.Text = "Crea il Cliente";
            this.btnLogInCliente.UseVisualStyleBackColor = false;
            this.btnLogInCliente.Click += new System.EventHandler(this.btnLogInCliente_Click);
            // 
            // btnEffettuaNoleggio
            // 
            this.btnEffettuaNoleggio.BackColor = System.Drawing.Color.White;
            this.btnEffettuaNoleggio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEffettuaNoleggio.Location = new System.Drawing.Point(12, 238);
            this.btnEffettuaNoleggio.Name = "btnEffettuaNoleggio";
            this.btnEffettuaNoleggio.Size = new System.Drawing.Size(186, 70);
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
            this.lstListaDeiClienti.Location = new System.Drawing.Point(332, 12);
            this.lstListaDeiClienti.Name = "lstListaDeiClienti";
            this.lstListaDeiClienti.Size = new System.Drawing.Size(273, 256);
            this.lstListaDeiClienti.TabIndex = 3;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.BackColor = System.Drawing.Color.White;
            this.btnAggiorna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAggiorna.Location = new System.Drawing.Point(548, 288);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(137, 47);
            this.btnAggiorna.TabIndex = 4;
            this.btnAggiorna.Text = "Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = false;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // btnCreaVeicolo
            // 
            this.btnCreaVeicolo.BackColor = System.Drawing.Color.White;
            this.btnCreaVeicolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreaVeicolo.Location = new System.Drawing.Point(12, 114);
            this.btnCreaVeicolo.Name = "btnCreaVeicolo";
            this.btnCreaVeicolo.Size = new System.Drawing.Size(186, 70);
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
            this.lstListaDeiVeicoli.Location = new System.Drawing.Point(635, 12);
            this.lstListaDeiVeicoli.Name = "lstListaDeiVeicoli";
            this.lstListaDeiVeicoli.Size = new System.Drawing.Size(267, 256);
            this.lstListaDeiVeicoli.TabIndex = 6;
            // 
            // FormCentroNoleggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(914, 396);
            this.Controls.Add(this.lstListaDeiVeicoli);
            this.Controls.Add(this.btnCreaVeicolo);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.lstListaDeiClienti);
            this.Controls.Add(this.btnEffettuaNoleggio);
            this.Controls.Add(this.btnLogInCliente);
            this.Name = "FormCentroNoleggio";
            this.Text = "Centro Noleggio";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogInCliente;
        private System.Windows.Forms.Button btnEffettuaNoleggio;
        private System.Windows.Forms.ListBox lstListaDeiClienti;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Button btnCreaVeicolo;
        private System.Windows.Forms.ListBox lstListaDeiVeicoli;
    }
}
