
namespace noleggio
{
    partial class FormCliente
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
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCognomeUtente = new System.Windows.Forms.Label();
            this.lblCodiceFiscaleUtente = new System.Windows.Forms.Label();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.txtCognomeC = new System.Windows.Forms.TextBox();
            this.txtCodiceFiscaleC = new System.Windows.Forms.TextBox();
            this.btnSalvaCliente = new System.Windows.Forms.Button();
            this.btnAnnullaCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Gray;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(73, 31);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(97, 38);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Nome";
            // 
            // lblCognomeUtente
            // 
            this.lblCognomeUtente.AutoSize = true;
            this.lblCognomeUtente.BackColor = System.Drawing.Color.Gray;
            this.lblCognomeUtente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCognomeUtente.ForeColor = System.Drawing.Color.White;
            this.lblCognomeUtente.Location = new System.Drawing.Point(73, 167);
            this.lblCognomeUtente.Name = "lblCognomeUtente";
            this.lblCognomeUtente.Size = new System.Drawing.Size(143, 38);
            this.lblCognomeUtente.TabIndex = 2;
            this.lblCognomeUtente.Text = "Cognome";
            // 
            // lblCodiceFiscaleUtente
            // 
            this.lblCodiceFiscaleUtente.AutoSize = true;
            this.lblCodiceFiscaleUtente.BackColor = System.Drawing.Color.Gray;
            this.lblCodiceFiscaleUtente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodiceFiscaleUtente.ForeColor = System.Drawing.Color.White;
            this.lblCodiceFiscaleUtente.Location = new System.Drawing.Point(73, 311);
            this.lblCodiceFiscaleUtente.Name = "lblCodiceFiscaleUtente";
            this.lblCodiceFiscaleUtente.Size = new System.Drawing.Size(198, 38);
            this.lblCodiceFiscaleUtente.TabIndex = 3;
            this.lblCodiceFiscaleUtente.Text = "Codice Fiscale";
            // 
            // txtNomeC
            // 
            this.txtNomeC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeC.Location = new System.Drawing.Point(73, 82);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(198, 34);
            this.txtNomeC.TabIndex = 4;
            // 
            // txtCognomeC
            // 
            this.txtCognomeC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCognomeC.Location = new System.Drawing.Point(73, 220);
            this.txtCognomeC.Name = "txtCognomeC";
            this.txtCognomeC.Size = new System.Drawing.Size(198, 34);
            this.txtCognomeC.TabIndex = 5;
            // 
            // txtCodiceFiscaleC
            // 
            this.txtCodiceFiscaleC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCodiceFiscaleC.Location = new System.Drawing.Point(73, 371);
            this.txtCodiceFiscaleC.Name = "txtCodiceFiscaleC";
            this.txtCodiceFiscaleC.Size = new System.Drawing.Size(198, 34);
            this.txtCodiceFiscaleC.TabIndex = 6;
            // 
            // btnSalvaCliente
            // 
            this.btnSalvaCliente.BackColor = System.Drawing.Color.White;
            this.btnSalvaCliente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvaCliente.Location = new System.Drawing.Point(14, 488);
            this.btnSalvaCliente.Name = "btnSalvaCliente";
            this.btnSalvaCliente.Size = new System.Drawing.Size(131, 61);
            this.btnSalvaCliente.TabIndex = 7;
            this.btnSalvaCliente.Text = "Salva";
            this.btnSalvaCliente.UseVisualStyleBackColor = false;
            this.btnSalvaCliente.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnAnnullaCliente
            // 
            this.btnAnnullaCliente.BackColor = System.Drawing.Color.White;
            this.btnAnnullaCliente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnnullaCliente.Location = new System.Drawing.Point(194, 488);
            this.btnAnnullaCliente.Name = "btnAnnullaCliente";
            this.btnAnnullaCliente.Size = new System.Drawing.Size(131, 61);
            this.btnAnnullaCliente.TabIndex = 8;
            this.btnAnnullaCliente.Text = "Annulla";
            this.btnAnnullaCliente.UseVisualStyleBackColor = false;
            this.btnAnnullaCliente.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(339, 583);
            this.Controls.Add(this.btnAnnullaCliente);
            this.Controls.Add(this.btnSalvaCliente);
            this.Controls.Add(this.txtCodiceFiscaleC);
            this.Controls.Add(this.txtCognomeC);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.lblCodiceFiscaleUtente);
            this.Controls.Add(this.lblCognomeUtente);
            this.Controls.Add(this.lblNomeCliente);
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCognomeUtente;
        private System.Windows.Forms.Label lblCodiceFiscaleUtente;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.TextBox txtCognomeC;
        private System.Windows.Forms.TextBox txtCodiceFiscaleC;
        private System.Windows.Forms.Button btnSalvaCliente;
        private System.Windows.Forms.Button btnAnnullaCliente;
    }
}