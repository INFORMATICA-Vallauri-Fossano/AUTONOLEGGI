namespace esAutoNoleggi
{
    partial class frmNoleggi
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucTxtDataFine = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtDataInizio = new AnrangoRamosLibrary.UCTxt();
            this.ucCmbTarga = new AnrangoRamosLibrary.UCCmb();
            this.ucCmbIdCliente = new AnrangoRamosLibrary.UCCmb();
            this.btnInizioNow = new System.Windows.Forms.Button();
            this.btnFineNow = new System.Windows.Forms.Button();
            this.lblIdNoleggio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaga = new System.Windows.Forms.Button();
            this.grbOperazioni.SuspendLayout();
            this.grbDati.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOperazioni
            // 
            this.grbOperazioni.Controls.Add(this.btnPaga);
            this.grbOperazioni.Controls.Add(this.label1);
            this.grbOperazioni.Controls.Add(this.lblIdNoleggio);
            this.grbOperazioni.Size = new System.Drawing.Size(130, 194);
            this.grbOperazioni.Controls.SetChildIndex(this.lblIdNoleggio, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.btnModifica, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.btnEliminazione, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.btnInserimento, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.label1, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.btnPaga, 0);
            // 
            // grbDati
            // 
            this.grbDati.Controls.Add(this.btnFineNow);
            this.grbDati.Controls.Add(this.btnInizioNow);
            this.grbDati.Controls.Add(this.ucTxtDataFine);
            this.grbDati.Controls.Add(this.ucTxtDataInizio);
            this.grbDati.Controls.Add(this.ucCmbTarga);
            this.grbDati.Controls.Add(this.ucCmbIdCliente);
            this.grbDati.Size = new System.Drawing.Size(329, 160);
            // 
            // btnInserimento
            // 
            this.btnInserimento.Click += new System.EventHandler(this.btnInserire_Click);
            // 
            // btnEliminazione
            // 
            this.btnEliminazione.Text = "TERMINA";
            this.btnEliminazione.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(5, 166);
            // 
            // ucTxtDataFine
            // 
            this.ucTxtDataFine.Label = "DATA FINE";
            this.ucTxtDataFine.Location = new System.Drawing.Point(5, 120);
            this.ucTxtDataFine.Name = "ucTxtDataFine";
            this.ucTxtDataFine.Size = new System.Drawing.Size(231, 28);
            this.ucTxtDataFine.TabIndex = 33;
            // 
            // ucTxtDataInizio
            // 
            this.ucTxtDataInizio.Label = "DATA INIZIO";
            this.ucTxtDataInizio.Location = new System.Drawing.Point(5, 86);
            this.ucTxtDataInizio.Name = "ucTxtDataInizio";
            this.ucTxtDataInizio.Size = new System.Drawing.Size(231, 28);
            this.ucTxtDataInizio.TabIndex = 32;
            // 
            // ucCmbTarga
            // 
            this.ucCmbTarga.Label = "TARGA";
            this.ucCmbTarga.Location = new System.Drawing.Point(5, 18);
            this.ucCmbTarga.Name = "ucCmbTarga";
            this.ucCmbTarga.Size = new System.Drawing.Size(231, 28);
            this.ucCmbTarga.TabIndex = 31;
            // 
            // ucCmbIdCliente
            // 
            this.ucCmbIdCliente.Label = "CLIENTE";
            this.ucCmbIdCliente.Location = new System.Drawing.Point(5, 52);
            this.ucCmbIdCliente.Name = "ucCmbIdCliente";
            this.ucCmbIdCliente.Size = new System.Drawing.Size(231, 28);
            this.ucCmbIdCliente.TabIndex = 30;
            // 
            // btnInizioNow
            // 
            this.btnInizioNow.Location = new System.Drawing.Point(242, 86);
            this.btnInizioNow.Name = "btnInizioNow";
            this.btnInizioNow.Size = new System.Drawing.Size(54, 23);
            this.btnInizioNow.TabIndex = 34;
            this.btnInizioNow.Text = "NOW";
            this.btnInizioNow.UseVisualStyleBackColor = true;
            this.btnInizioNow.Click += new System.EventHandler(this.btnInizioNow_Click);
            // 
            // btnFineNow
            // 
            this.btnFineNow.Location = new System.Drawing.Point(242, 120);
            this.btnFineNow.Name = "btnFineNow";
            this.btnFineNow.Size = new System.Drawing.Size(54, 23);
            this.btnFineNow.TabIndex = 35;
            this.btnFineNow.Text = "NOW";
            this.btnFineNow.UseVisualStyleBackColor = true;
            this.btnFineNow.Click += new System.EventHandler(this.btnFineNow_Click);
            // 
            // lblIdNoleggio
            // 
            this.lblIdNoleggio.Location = new System.Drawing.Point(31, 86);
            this.lblIdNoleggio.Name = "lblIdNoleggio";
            this.lblIdNoleggio.Size = new System.Drawing.Size(89, 23);
            this.lblIdNoleggio.TabIndex = 4;
            this.lblIdNoleggio.Text = "XX";
            this.lblIdNoleggio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // btnPaga
            // 
            this.btnPaga.Location = new System.Drawing.Point(5, 112);
            this.btnPaga.Name = "btnPaga";
            this.btnPaga.Size = new System.Drawing.Size(115, 23);
            this.btnPaga.TabIndex = 6;
            this.btnPaga.Text = "PAGA";
            this.btnPaga.UseVisualStyleBackColor = true;
            this.btnPaga.Click += new System.EventHandler(this.btnPaga_Click);
            // 
            // frmNoleggi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 597);
            this.Name = "frmNoleggi";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmNoleggi_Load);
            this.grbOperazioni.ResumeLayout(false);
            this.grbOperazioni.PerformLayout();
            this.grbDati.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AnrangoRamosLibrary.UCTxt ucTxtDataFine;
        private AnrangoRamosLibrary.UCTxt ucTxtDataInizio;
        private AnrangoRamosLibrary.UCCmb ucCmbTarga;
        private AnrangoRamosLibrary.UCCmb ucCmbIdCliente;
        private System.Windows.Forms.Button btnFineNow;
        private System.Windows.Forms.Button btnInizioNow;
        private System.Windows.Forms.Label lblIdNoleggio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaga;
    }
}

