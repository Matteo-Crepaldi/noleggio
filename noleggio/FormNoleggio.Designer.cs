
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
            this.btnSalvaNoleggio = new System.Windows.Forms.Button();
            this.btnAnnullaNoleggio = new System.Windows.Forms.Button();
            this.dtpDataInizioNol = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFineNol = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDataInizioNoleggio
            // 
            this.lblDataInizioNoleggio.AutoSize = true;
            this.lblDataInizioNoleggio.BackColor = System.Drawing.Color.Gray;
            this.lblDataInizioNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataInizioNoleggio.ForeColor = System.Drawing.Color.White;
            this.lblDataInizioNoleggio.Location = new System.Drawing.Point(64, 18);
            this.lblDataInizioNoleggio.Name = "lblDataInizioNoleggio";
            this.lblDataInizioNoleggio.Size = new System.Drawing.Size(213, 38);
            this.lblDataInizioNoleggio.TabIndex = 3;
            this.lblDataInizioNoleggio.Text = "Inizio noleggio";
            // 
            // lblFineNoleggio
            // 
            this.lblFineNoleggio.AutoSize = true;
            this.lblFineNoleggio.BackColor = System.Drawing.Color.Gray;
            this.lblFineNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFineNoleggio.ForeColor = System.Drawing.Color.White;
            this.lblFineNoleggio.Location = new System.Drawing.Point(60, 153);
            this.lblFineNoleggio.Name = "lblFineNoleggio";
            this.lblFineNoleggio.Size = new System.Drawing.Size(196, 38);
            this.lblFineNoleggio.TabIndex = 4;
            this.lblFineNoleggio.Text = "Fine noleggio";
            // 
            // btnSalvaNoleggio
            // 
            this.btnSalvaNoleggio.BackColor = System.Drawing.Color.White;
            this.btnSalvaNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvaNoleggio.Location = new System.Drawing.Point(32, 311);
            this.btnSalvaNoleggio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvaNoleggio.Name = "btnSalvaNoleggio";
            this.btnSalvaNoleggio.Size = new System.Drawing.Size(131, 61);
            this.btnSalvaNoleggio.TabIndex = 8;
            this.btnSalvaNoleggio.Text = "Salva";
            this.btnSalvaNoleggio.UseVisualStyleBackColor = false;
            this.btnSalvaNoleggio.Click += new System.EventHandler(this.btnSalvaNoleggio_Click);
            // 
            // btnAnnullaNoleggio
            // 
            this.btnAnnullaNoleggio.BackColor = System.Drawing.Color.White;
            this.btnAnnullaNoleggio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnnullaNoleggio.Location = new System.Drawing.Point(194, 311);
            this.btnAnnullaNoleggio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnullaNoleggio.Name = "btnAnnullaNoleggio";
            this.btnAnnullaNoleggio.Size = new System.Drawing.Size(131, 61);
            this.btnAnnullaNoleggio.TabIndex = 9;
            this.btnAnnullaNoleggio.Text = "Annulla";
            this.btnAnnullaNoleggio.UseVisualStyleBackColor = false;
            this.btnAnnullaNoleggio.Click += new System.EventHandler(this.btnAnnullaNoleggio_Click);
            // 
            // dtpDataInizioNol
            // 
            this.dtpDataInizioNol.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataInizioNol.Location = new System.Drawing.Point(64, 69);
            this.dtpDataInizioNol.Name = "dtpDataInizioNol";
            this.dtpDataInizioNol.Size = new System.Drawing.Size(265, 38);
            this.dtpDataInizioNol.TabIndex = 10;
            // 
            // dtpDataFineNol
            // 
            this.dtpDataFineNol.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataFineNol.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataFineNol.Location = new System.Drawing.Point(60, 210);
            this.dtpDataFineNol.Name = "dtpDataFineNol";
            this.dtpDataFineNol.Size = new System.Drawing.Size(265, 38);
            this.dtpDataFineNol.TabIndex = 11;
            // 
            // FormNoleggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(381, 393);
            this.Controls.Add(this.dtpDataFineNol);
            this.Controls.Add(this.dtpDataInizioNol);
            this.Controls.Add(this.btnAnnullaNoleggio);
            this.Controls.Add(this.btnSalvaNoleggio);
            this.Controls.Add(this.lblFineNoleggio);
            this.Controls.Add(this.lblDataInizioNoleggio);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNoleggio";
            this.Text = "Noleggio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataInizioNoleggio;
        private System.Windows.Forms.Label lblFineNoleggio;
        private System.Windows.Forms.Button btnSalvaNoleggio;
        private System.Windows.Forms.Button btnAnnullaNoleggio;
        private System.Windows.Forms.DateTimePicker dtpDataInizioNol;
        private System.Windows.Forms.DateTimePicker dtpDataFineNol;
    }
}