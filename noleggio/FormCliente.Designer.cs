
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
            this.btnSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Silver;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCliente.Location = new System.Drawing.Point(82, 31);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(97, 38);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Nome";
            // 
            // lblCognomeUtente
            // 
            this.lblCognomeUtente.AutoSize = true;
            this.lblCognomeUtente.BackColor = System.Drawing.Color.Silver;
            this.lblCognomeUtente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCognomeUtente.Location = new System.Drawing.Point(82, 168);
            this.lblCognomeUtente.Name = "lblCognomeUtente";
            this.lblCognomeUtente.Size = new System.Drawing.Size(143, 38);
            this.lblCognomeUtente.TabIndex = 2;
            this.lblCognomeUtente.Text = "Cognome";
            // 
            // lblCodiceFiscaleUtente
            // 
            this.lblCodiceFiscaleUtente.AutoSize = true;
            this.lblCodiceFiscaleUtente.BackColor = System.Drawing.Color.Silver;
            this.lblCodiceFiscaleUtente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodiceFiscaleUtente.Location = new System.Drawing.Point(82, 317);
            this.lblCodiceFiscaleUtente.Name = "lblCodiceFiscaleUtente";
            this.lblCodiceFiscaleUtente.Size = new System.Drawing.Size(198, 38);
            this.lblCodiceFiscaleUtente.TabIndex = 3;
            this.lblCodiceFiscaleUtente.Text = "Codice Fiscale";
            // 
            // txtNomeC
            // 
            this.txtNomeC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeC.Location = new System.Drawing.Point(82, 84);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(198, 34);
            this.txtNomeC.TabIndex = 4;
            // 
            // txtCognomeC
            // 
            this.txtCognomeC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCognomeC.Location = new System.Drawing.Point(82, 221);
            this.txtCognomeC.Name = "txtCognomeC";
            this.txtCognomeC.Size = new System.Drawing.Size(198, 34);
            this.txtCognomeC.TabIndex = 5;
            // 
            // txtCodiceFiscaleC
            // 
            this.txtCodiceFiscaleC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCodiceFiscaleC.Location = new System.Drawing.Point(82, 373);
            this.txtCodiceFiscaleC.Name = "txtCodiceFiscaleC";
            this.txtCodiceFiscaleC.Size = new System.Drawing.Size(198, 34);
            this.txtCodiceFiscaleC.TabIndex = 6;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.White;
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(82, 469);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(198, 102);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(339, 583);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtCodiceFiscaleC);
            this.Controls.Add(this.txtCognomeC);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.lblCodiceFiscaleUtente);
            this.Controls.Add(this.lblCognomeUtente);
            this.Controls.Add(this.lblNomeCliente);
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
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
        private System.Windows.Forms.Button btnSalva;
    }
}