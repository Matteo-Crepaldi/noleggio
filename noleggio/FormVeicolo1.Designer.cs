
namespace noleggio
{
    partial class FormVeicolo1
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
            this.btnSalva = new System.Windows.Forms.Button();
            this.lblTargaVeicolo = new System.Windows.Forms.Label();
            this.lblModelloVeicolo = new System.Windows.Forms.Label();
            this.txtTargaA = new System.Windows.Forms.TextBox();
            this.txtModelloA = new System.Windows.Forms.TextBox();
            this.txtnumPostiA = new System.Windows.Forms.TextBox();
            this.txtCapacitàF = new System.Windows.Forms.TextBox();
            this.lblnumPostiAutomobile = new System.Windows.Forms.Label();
            this.lblCapacitàFurgone = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTariffaAutoFurgo = new System.Windows.Forms.Label();
            this.txtTariffaAF = new System.Windows.Forms.TextBox();
            this.rbAutomobile = new System.Windows.Forms.RadioButton();
            this.rbFurgone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.White;
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(138, 495);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(198, 102);
            this.btnSalva.TabIndex = 8;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // lblTargaVeicolo
            // 
            this.lblTargaVeicolo.AutoSize = true;
            this.lblTargaVeicolo.BackColor = System.Drawing.Color.Black;
            this.lblTargaVeicolo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTargaVeicolo.ForeColor = System.Drawing.Color.White;
            this.lblTargaVeicolo.Location = new System.Drawing.Point(12, 37);
            this.lblTargaVeicolo.Name = "lblTargaVeicolo";
            this.lblTargaVeicolo.Size = new System.Drawing.Size(89, 38);
            this.lblTargaVeicolo.TabIndex = 9;
            this.lblTargaVeicolo.Text = "Targa";
            // 
            // lblModelloVeicolo
            // 
            this.lblModelloVeicolo.AutoSize = true;
            this.lblModelloVeicolo.BackColor = System.Drawing.Color.Black;
            this.lblModelloVeicolo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelloVeicolo.ForeColor = System.Drawing.Color.White;
            this.lblModelloVeicolo.Location = new System.Drawing.Point(293, 37);
            this.lblModelloVeicolo.Name = "lblModelloVeicolo";
            this.lblModelloVeicolo.Size = new System.Drawing.Size(126, 38);
            this.lblModelloVeicolo.TabIndex = 10;
            this.lblModelloVeicolo.Text = "Modello";
            // 
            // txtTargaA
            // 
            this.txtTargaA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTargaA.Location = new System.Drawing.Point(12, 78);
            this.txtTargaA.Name = "txtTargaA";
            this.txtTargaA.Size = new System.Drawing.Size(178, 34);
            this.txtTargaA.TabIndex = 11;
            // 
            // txtModelloA
            // 
            this.txtModelloA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtModelloA.Location = new System.Drawing.Point(293, 78);
            this.txtModelloA.Name = "txtModelloA";
            this.txtModelloA.Size = new System.Drawing.Size(178, 34);
            this.txtModelloA.TabIndex = 12;
            // 
            // txtnumPostiA
            // 
            this.txtnumPostiA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnumPostiA.Location = new System.Drawing.Point(12, 422);
            this.txtnumPostiA.Name = "txtnumPostiA";
            this.txtnumPostiA.Size = new System.Drawing.Size(197, 34);
            this.txtnumPostiA.TabIndex = 13;
            // 
            // txtCapacitàF
            // 
            this.txtCapacitàF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCapacitàF.Location = new System.Drawing.Point(274, 422);
            this.txtCapacitàF.Name = "txtCapacitàF";
            this.txtCapacitàF.Size = new System.Drawing.Size(178, 34);
            this.txtCapacitàF.TabIndex = 14;
            this.txtCapacitàF.Visible = false;
            // 
            // lblnumPostiAutomobile
            // 
            this.lblnumPostiAutomobile.AutoSize = true;
            this.lblnumPostiAutomobile.BackColor = System.Drawing.Color.Black;
            this.lblnumPostiAutomobile.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnumPostiAutomobile.ForeColor = System.Drawing.Color.White;
            this.lblnumPostiAutomobile.Location = new System.Drawing.Point(12, 372);
            this.lblnumPostiAutomobile.Name = "lblnumPostiAutomobile";
            this.lblnumPostiAutomobile.Size = new System.Drawing.Size(197, 38);
            this.lblnumPostiAutomobile.TabIndex = 15;
            this.lblnumPostiAutomobile.Text = "Numero Posti";
            this.lblnumPostiAutomobile.UseMnemonic = false;
            this.lblnumPostiAutomobile.UseWaitCursor = true;
            // 
            // lblCapacitàFurgone
            // 
            this.lblCapacitàFurgone.AutoSize = true;
            this.lblCapacitàFurgone.BackColor = System.Drawing.Color.Black;
            this.lblCapacitàFurgone.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapacitàFurgone.ForeColor = System.Drawing.Color.White;
            this.lblCapacitàFurgone.Location = new System.Drawing.Point(274, 372);
            this.lblCapacitàFurgone.Name = "lblCapacitàFurgone";
            this.lblCapacitàFurgone.Size = new System.Drawing.Size(128, 38);
            this.lblCapacitàFurgone.TabIndex = 16;
            this.lblCapacitàFurgone.Text = "Capacità";
            this.lblCapacitàFurgone.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Black;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(293, 192);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 38);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo";
            // 
            // lblTariffaAutoFurgo
            // 
            this.lblTariffaAutoFurgo.AutoSize = true;
            this.lblTariffaAutoFurgo.BackColor = System.Drawing.Color.Black;
            this.lblTariffaAutoFurgo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTariffaAutoFurgo.ForeColor = System.Drawing.Color.White;
            this.lblTariffaAutoFurgo.Location = new System.Drawing.Point(12, 191);
            this.lblTariffaAutoFurgo.Name = "lblTariffaAutoFurgo";
            this.lblTariffaAutoFurgo.Size = new System.Drawing.Size(102, 38);
            this.lblTariffaAutoFurgo.TabIndex = 18;
            this.lblTariffaAutoFurgo.Text = "Tariffa";
            // 
            // txtTariffaAF
            // 
            this.txtTariffaAF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTariffaAF.Location = new System.Drawing.Point(12, 241);
            this.txtTariffaAF.Name = "txtTariffaAF";
            this.txtTariffaAF.Size = new System.Drawing.Size(178, 34);
            this.txtTariffaAF.TabIndex = 19;
            // 
            // rbAutomobile
            // 
            this.rbAutomobile.AutoSize = true;
            this.rbAutomobile.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbAutomobile.ForeColor = System.Drawing.Color.White;
            this.rbAutomobile.Location = new System.Drawing.Point(293, 233);
            this.rbAutomobile.Name = "rbAutomobile";
            this.rbAutomobile.Size = new System.Drawing.Size(194, 42);
            this.rbAutomobile.TabIndex = 20;
            this.rbAutomobile.Text = "Automobile";
            this.rbAutomobile.UseVisualStyleBackColor = true;
            this.rbAutomobile.CheckedChanged += new System.EventHandler(this.rbAutomobile_CheckedChanged);
            // 
            // rbFurgone
            // 
            this.rbFurgone.AutoSize = true;
            this.rbFurgone.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFurgone.ForeColor = System.Drawing.Color.White;
            this.rbFurgone.Location = new System.Drawing.Point(293, 289);
            this.rbFurgone.Name = "rbFurgone";
            this.rbFurgone.Size = new System.Drawing.Size(147, 42);
            this.rbFurgone.TabIndex = 21;
            this.rbFurgone.Text = "Furgone";
            this.rbFurgone.UseVisualStyleBackColor = true;
            this.rbFurgone.Click += new System.EventHandler(this.rbFurgone_CheckedChanged);
            // 
            // FormVeicolo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(511, 609);
            this.Controls.Add(this.rbFurgone);
            this.Controls.Add(this.rbAutomobile);
            this.Controls.Add(this.txtTariffaAF);
            this.Controls.Add(this.lblTariffaAutoFurgo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCapacitàFurgone);
            this.Controls.Add(this.lblnumPostiAutomobile);
            this.Controls.Add(this.txtCapacitàF);
            this.Controls.Add(this.txtnumPostiA);
            this.Controls.Add(this.txtModelloA);
            this.Controls.Add(this.txtTargaA);
            this.Controls.Add(this.lblModelloVeicolo);
            this.Controls.Add(this.lblTargaVeicolo);
            this.Controls.Add(this.btnSalva);
            this.Name = "FormVeicolo1";
            this.Text = "Veicolo";
            this.Load += new System.EventHandler(this.FormVeicolo1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label lblTargaVeicolo;
        private System.Windows.Forms.Label lblModelloVeicolo;
        private System.Windows.Forms.TextBox txtTargaA;
        private System.Windows.Forms.TextBox txtModelloA;
        private System.Windows.Forms.TextBox txtnumPostiA;
        private System.Windows.Forms.TextBox txtCapacitàF;
        private System.Windows.Forms.Label lblnumPostiAutomobile;
        private System.Windows.Forms.Label lblCapacitàFurgone;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTariffaAutoFurgo;
        private System.Windows.Forms.TextBox txtTariffaAF;
        private System.Windows.Forms.RadioButton rbAutomobile;
        private System.Windows.Forms.RadioButton rbFurgone;
    }
}