
namespace noleggio
{
    partial class FormTotali
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTargaCF = new System.Windows.Forms.ComboBox();
            this.rbTargheVeicoli = new System.Windows.Forms.RadioButton();
            this.rbCodFiscClienti = new System.Windows.Forms.RadioButton();
            this.lstNoleggi = new System.Windows.Forms.ListBox();
            this.lblTotali = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblListaNoleggioCalcolato = new System.Windows.Forms.Label();
            this.lblCostoNoleggio = new System.Windows.Forms.Label();
            this.lblSelezionaTargaOrCodFisc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTargaCF
            // 
            this.cmbTargaCF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbTargaCF.FormattingEnabled = true;
            this.cmbTargaCF.Location = new System.Drawing.Point(25, 151);
            this.cmbTargaCF.Name = "cmbTargaCF";
            this.cmbTargaCF.Size = new System.Drawing.Size(291, 36);
            this.cmbTargaCF.TabIndex = 0;
            this.cmbTargaCF.SelectedIndexChanged += new System.EventHandler(this.cmbTargaCF_SelectedIndexChanged);
            // 
            // rbTargheVeicoli
            // 
            this.rbTargheVeicoli.AutoSize = true;
            this.rbTargheVeicoli.BackColor = System.Drawing.Color.Gray;
            this.rbTargheVeicoli.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbTargheVeicoli.ForeColor = System.Drawing.Color.White;
            this.rbTargheVeicoli.Location = new System.Drawing.Point(25, 81);
            this.rbTargheVeicoli.Name = "rbTargheVeicoli";
            this.rbTargheVeicoli.Size = new System.Drawing.Size(185, 35);
            this.rbTargheVeicoli.TabIndex = 1;
            this.rbTargheVeicoli.Text = "Targhe Veicoli";
            this.rbTargheVeicoli.UseVisualStyleBackColor = false;
            this.rbTargheVeicoli.CheckedChanged += new System.EventHandler(this.rbTargheVeicoli_CheckedChanged);
            // 
            // rbCodFiscClienti
            // 
            this.rbCodFiscClienti.AutoSize = true;
            this.rbCodFiscClienti.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCodFiscClienti.ForeColor = System.Drawing.Color.White;
            this.rbCodFiscClienti.Location = new System.Drawing.Point(260, 81);
            this.rbCodFiscClienti.Name = "rbCodFiscClienti";
            this.rbCodFiscClienti.Size = new System.Drawing.Size(193, 35);
            this.rbCodFiscClienti.TabIndex = 2;
            this.rbCodFiscClienti.Text = "CodFisc Clienti";
            this.rbCodFiscClienti.UseVisualStyleBackColor = true;
            this.rbCodFiscClienti.CheckedChanged += new System.EventHandler(this.rbCodFiscClienti_CheckedChanged);
            // 
            // lstNoleggi
            // 
            this.lstNoleggi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstNoleggi.FormattingEnabled = true;
            this.lstNoleggi.ItemHeight = 31;
            this.lstNoleggi.Location = new System.Drawing.Point(0, 0);
            this.lstNoleggi.Name = "lstNoleggi";
            this.lstNoleggi.Size = new System.Drawing.Size(353, 314);
            this.lstNoleggi.TabIndex = 3;
            // 
            // lblTotali
            // 
            this.lblTotali.BackColor = System.Drawing.Color.White;
            this.lblTotali.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotali.Location = new System.Drawing.Point(0, 381);
            this.lblTotali.Name = "lblTotali";
            this.lblTotali.Size = new System.Drawing.Size(113, 71);
            this.lblTotali.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCostoNoleggio);
            this.panel1.Controls.Add(this.lblTotali);
            this.panel1.Controls.Add(this.lstNoleggi);
            this.panel1.Location = new System.Drawing.Point(22, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 457);
            this.panel1.TabIndex = 5;
            // 
            // lblListaNoleggioCalcolato
            // 
            this.lblListaNoleggioCalcolato.AutoSize = true;
            this.lblListaNoleggioCalcolato.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaNoleggioCalcolato.ForeColor = System.Drawing.Color.White;
            this.lblListaNoleggioCalcolato.Location = new System.Drawing.Point(22, 216);
            this.lblListaNoleggioCalcolato.Name = "lblListaNoleggioCalcolato";
            this.lblListaNoleggioCalcolato.Size = new System.Drawing.Size(370, 50);
            this.lblListaNoleggioCalcolato.TabIndex = 14;
            this.lblListaNoleggioCalcolato.Text = "Noleggio effettuato";
            // 
            // lblCostoNoleggio
            // 
            this.lblCostoNoleggio.AutoSize = true;
            this.lblCostoNoleggio.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoNoleggio.ForeColor = System.Drawing.Color.White;
            this.lblCostoNoleggio.Location = new System.Drawing.Point(3, 317);
            this.lblCostoNoleggio.Name = "lblCostoNoleggio";
            this.lblCostoNoleggio.Size = new System.Drawing.Size(238, 50);
            this.lblCostoNoleggio.TabIndex = 15;
            this.lblCostoNoleggio.Text = "Costo Totale";
            // 
            // lblSelezionaTargaOrCodFisc
            // 
            this.lblSelezionaTargaOrCodFisc.AutoSize = true;
            this.lblSelezionaTargaOrCodFisc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelezionaTargaOrCodFisc.ForeColor = System.Drawing.Color.White;
            this.lblSelezionaTargaOrCodFisc.Location = new System.Drawing.Point(12, 25);
            this.lblSelezionaTargaOrCodFisc.Name = "lblSelezionaTargaOrCodFisc";
            this.lblSelezionaTargaOrCodFisc.Size = new System.Drawing.Size(493, 41);
            this.lblSelezionaTargaOrCodFisc.TabIndex = 15;
            this.lblSelezionaTargaOrCodFisc.Text = "Seleziona Targa o il Codice Fiscale";
            // 
            // FormTotali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(516, 760);
            this.Controls.Add(this.lblSelezionaTargaOrCodFisc);
            this.Controls.Add(this.lblListaNoleggioCalcolato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbCodFiscClienti);
            this.Controls.Add(this.rbTargheVeicoli);
            this.Controls.Add(this.cmbTargaCF);
            this.Name = "FormTotali";
            this.Text = "Totali";
            this.Load += new System.EventHandler(this.FormTotali_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTargaCF;
        private System.Windows.Forms.RadioButton rbTargheVeicoli;
        private System.Windows.Forms.RadioButton rbCodFiscClienti;
        private System.Windows.Forms.ListBox lstNoleggi;
        private System.Windows.Forms.Label lblTotali;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCostoNoleggio;
        private System.Windows.Forms.Label lblListaNoleggioCalcolato;
        private System.Windows.Forms.Label lblSelezionaTargaOrCodFisc;
    }
}