﻿
namespace noleggio
{
    partial class FormNoleggio
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblDataInizioNoleggio = new System.Windows.Forms.Label();
            this.lblFineNoleggio = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtInizioNoleggio = new System.Windows.Forms.TextBox();
            this.txtFineNoleggio = new System.Windows.Forms.TextBox();
            this.btnSalvaNoleggio = new System.Windows.Forms.Button();
            this.btnAnnullaNoleggio = new System.Windows.Forms.Button();
            this.lblCostoVeicolo = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Gray;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(57, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 30);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblDataInizioNoleggio
            // 
            this.lblDataInizioNoleggio.AutoSize = true;
            this.lblDataInizioNoleggio.BackColor = System.Drawing.Color.Gray;
            this.lblDataInizioNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataInizioNoleggio.ForeColor = System.Drawing.Color.White;
            this.lblDataInizioNoleggio.Location = new System.Drawing.Point(57, 101);
            this.lblDataInizioNoleggio.Name = "lblDataInizioNoleggio";
            this.lblDataInizioNoleggio.Size = new System.Drawing.Size(166, 30);
            this.lblDataInizioNoleggio.TabIndex = 3;
            this.lblDataInizioNoleggio.Text = "Inizio noleggio";
            // 
            // lblFineNoleggio
            // 
            this.lblFineNoleggio.AutoSize = true;
            this.lblFineNoleggio.BackColor = System.Drawing.Color.Gray;
            this.lblFineNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFineNoleggio.ForeColor = System.Drawing.Color.White;
            this.lblFineNoleggio.Location = new System.Drawing.Point(57, 185);
            this.lblFineNoleggio.Name = "lblFineNoleggio";
            this.lblFineNoleggio.Size = new System.Drawing.Size(152, 30);
            this.lblFineNoleggio.TabIndex = 4;
            this.lblFineNoleggio.Text = "Fine noleggio";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(57, 41);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 29);
            this.txtID.TabIndex = 5;
            // 
            // txtInizioNoleggio
            // 
            this.txtInizioNoleggio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInizioNoleggio.Location = new System.Drawing.Point(57, 133);
            this.txtInizioNoleggio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInizioNoleggio.Name = "txtInizioNoleggio";
            this.txtInizioNoleggio.Size = new System.Drawing.Size(174, 29);
            this.txtInizioNoleggio.TabIndex = 6;
            // 
            // txtFineNoleggio
            // 
            this.txtFineNoleggio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFineNoleggio.Location = new System.Drawing.Point(57, 217);
            this.txtFineNoleggio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFineNoleggio.Name = "txtFineNoleggio";
            this.txtFineNoleggio.Size = new System.Drawing.Size(174, 29);
            this.txtFineNoleggio.TabIndex = 7;
            // 
            // btnSalvaNoleggio
            // 
            this.btnSalvaNoleggio.BackColor = System.Drawing.Color.White;
            this.btnSalvaNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvaNoleggio.Location = new System.Drawing.Point(12, 380);
            this.btnSalvaNoleggio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvaNoleggio.Name = "btnSalvaNoleggio";
            this.btnSalvaNoleggio.Size = new System.Drawing.Size(115, 46);
            this.btnSalvaNoleggio.TabIndex = 8;
            this.btnSalvaNoleggio.Text = "Salva";
            this.btnSalvaNoleggio.UseVisualStyleBackColor = false;
            this.btnSalvaNoleggio.Click += new System.EventHandler(this.btnSalvaNoleggio_Click);
            // 
            // btnAnnullaNoleggio
            // 
            this.btnAnnullaNoleggio.BackColor = System.Drawing.Color.White;
            this.btnAnnullaNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnnullaNoleggio.Location = new System.Drawing.Point(170, 380);
            this.btnAnnullaNoleggio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnullaNoleggio.Name = "btnAnnullaNoleggio";
            this.btnAnnullaNoleggio.Size = new System.Drawing.Size(115, 46);
            this.btnAnnullaNoleggio.TabIndex = 9;
            this.btnAnnullaNoleggio.Text = "Annulla";
            this.btnAnnullaNoleggio.UseVisualStyleBackColor = false;
            this.btnAnnullaNoleggio.Click += new System.EventHandler(this.btnAnnullaNoleggio_Click);
            // 
            // lblCostoVeicolo
            // 
            this.lblCostoVeicolo.AutoSize = true;
            this.lblCostoVeicolo.BackColor = System.Drawing.Color.Gray;
            this.lblCostoVeicolo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoVeicolo.ForeColor = System.Drawing.Color.White;
            this.lblCostoVeicolo.Location = new System.Drawing.Point(57, 267);
            this.lblCostoVeicolo.Name = "lblCostoVeicolo";
            this.lblCostoVeicolo.Size = new System.Drawing.Size(72, 30);
            this.lblCostoVeicolo.TabIndex = 10;
            this.lblCostoVeicolo.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCosto.Location = new System.Drawing.Point(57, 299);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(174, 29);
            this.txtCosto.TabIndex = 11;
            // 
            // FormNoleggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(297, 437);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCostoVeicolo);
            this.Controls.Add(this.btnAnnullaNoleggio);
            this.Controls.Add(this.btnSalvaNoleggio);
            this.Controls.Add(this.txtFineNoleggio);
            this.Controls.Add(this.txtInizioNoleggio);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblFineNoleggio);
            this.Controls.Add(this.lblDataInizioNoleggio);
            this.Controls.Add(this.lblID);
            this.Name = "FormNoleggio";
            this.Text = "Noleggio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDataInizioNoleggio;
        private System.Windows.Forms.Label lblFineNoleggio;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtInizioNoleggio;
        private System.Windows.Forms.TextBox txtFineNoleggio;
        private System.Windows.Forms.Button btnSalvaNoleggio;
        private System.Windows.Forms.Button btnAnnullaNoleggio;
        private System.Windows.Forms.Label lblCostoVeicolo;
        private System.Windows.Forms.TextBox txtCosto;
    }
}