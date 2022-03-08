
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
            this.lblDataInizioNoleggio = new System.Windows.Forms.Label();
            this.lblFineNoleggio = new System.Windows.Forms.Label();
            this.txtInizioNoleggio = new System.Windows.Forms.TextBox();
            this.txtFineNoleggio = new System.Windows.Forms.TextBox();
            this.btnSalvaNoleggio = new System.Windows.Forms.Button();
            this.btnAnnullaNoleggio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataInizioNoleggio
            // 
            this.lblDataInizioNoleggio.AutoSize = true;
            this.lblDataInizioNoleggio.BackColor = System.Drawing.Color.Gray;
            this.lblDataInizioNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataInizioNoleggio.ForeColor = System.Drawing.Color.White;
            this.lblDataInizioNoleggio.Location = new System.Drawing.Point(136, 63);
            this.lblDataInizioNoleggio.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDataInizioNoleggio.Name = "lblDataInizioNoleggio";
            this.lblDataInizioNoleggio.Size = new System.Drawing.Size(420, 74);
            this.lblDataInizioNoleggio.TabIndex = 3;
            this.lblDataInizioNoleggio.Text = "Inizio noleggio";
            // 
            // lblFineNoleggio
            // 
            this.lblFineNoleggio.AutoSize = true;
            this.lblFineNoleggio.BackColor = System.Drawing.Color.Gray;
            this.lblFineNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFineNoleggio.ForeColor = System.Drawing.Color.White;
            this.lblFineNoleggio.Location = new System.Drawing.Point(136, 292);
            this.lblFineNoleggio.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFineNoleggio.Name = "lblFineNoleggio";
            this.lblFineNoleggio.Size = new System.Drawing.Size(386, 74);
            this.lblFineNoleggio.TabIndex = 4;
            this.lblFineNoleggio.Text = "Fine noleggio";
            // 
            // txtInizioNoleggio
            // 
            this.txtInizioNoleggio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInizioNoleggio.Location = new System.Drawing.Point(136, 150);
            this.txtInizioNoleggio.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtInizioNoleggio.Name = "txtInizioNoleggio";
            this.txtInizioNoleggio.Size = new System.Drawing.Size(417, 61);
            this.txtInizioNoleggio.TabIndex = 6;
            // 
            // txtFineNoleggio
            // 
            this.txtFineNoleggio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFineNoleggio.Location = new System.Drawing.Point(136, 380);
            this.txtFineNoleggio.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtFineNoleggio.Name = "txtFineNoleggio";
            this.txtFineNoleggio.Size = new System.Drawing.Size(417, 61);
            this.txtFineNoleggio.TabIndex = 7;
            // 
            // btnSalvaNoleggio
            // 
            this.btnSalvaNoleggio.BackColor = System.Drawing.Color.White;
            this.btnSalvaNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvaNoleggio.Location = new System.Drawing.Point(29, 579);
            this.btnSalvaNoleggio.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnSalvaNoleggio.Name = "btnSalvaNoleggio";
            this.btnSalvaNoleggio.Size = new System.Drawing.Size(279, 126);
            this.btnSalvaNoleggio.TabIndex = 8;
            this.btnSalvaNoleggio.Text = "Salva";
            this.btnSalvaNoleggio.UseVisualStyleBackColor = false;
            this.btnSalvaNoleggio.Click += new System.EventHandler(this.btnSalvaNoleggio_Click);
            // 
            // btnAnnullaNoleggio
            // 
            this.btnAnnullaNoleggio.BackColor = System.Drawing.Color.White;
            this.btnAnnullaNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnnullaNoleggio.Location = new System.Drawing.Point(413, 579);
            this.btnAnnullaNoleggio.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnAnnullaNoleggio.Name = "btnAnnullaNoleggio";
            this.btnAnnullaNoleggio.Size = new System.Drawing.Size(279, 126);
            this.btnAnnullaNoleggio.TabIndex = 9;
            this.btnAnnullaNoleggio.Text = "Annulla";
            this.btnAnnullaNoleggio.UseVisualStyleBackColor = false;
            this.btnAnnullaNoleggio.Click += new System.EventHandler(this.btnAnnullaNoleggio_Click);
            // 
            // FormNoleggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(721, 828);
            this.Controls.Add(this.btnAnnullaNoleggio);
            this.Controls.Add(this.btnSalvaNoleggio);
            this.Controls.Add(this.txtFineNoleggio);
            this.Controls.Add(this.txtInizioNoleggio);
            this.Controls.Add(this.lblFineNoleggio);
            this.Controls.Add(this.lblDataInizioNoleggio);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FormNoleggio";
            this.Text = "Noleggio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataInizioNoleggio;
        private System.Windows.Forms.Label lblFineNoleggio;
        private System.Windows.Forms.TextBox txtInizioNoleggio;
        private System.Windows.Forms.TextBox txtFineNoleggio;
        private System.Windows.Forms.Button btnSalvaNoleggio;
        private System.Windows.Forms.Button btnAnnullaNoleggio;
    }
}