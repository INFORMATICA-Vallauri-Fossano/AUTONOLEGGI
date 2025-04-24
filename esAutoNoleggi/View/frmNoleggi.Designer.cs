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
            this.grbOperazioni.SuspendLayout();
            this.grbDati.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOperazioni
            // 
            this.grbOperazioni.Size = new System.Drawing.Size(130, 160);
            // 
            // grbDati
            // 
            this.grbDati.Controls.Add(this.ucTxtDataFine);
            this.grbDati.Controls.Add(this.ucTxtDataInizio);
            this.grbDati.Controls.Add(this.ucCmbTarga);
            this.grbDati.Controls.Add(this.ucCmbIdCliente);
            this.grbDati.Size = new System.Drawing.Size(252, 160);
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
            // frmNoleggi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 557);
            this.Name = "frmNoleggi";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmNoleggi_Load);
            this.grbOperazioni.ResumeLayout(false);
            this.grbDati.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AnrangoRamosLibrary.UCTxt ucTxtDataFine;
        private AnrangoRamosLibrary.UCTxt ucTxtDataInizio;
        private AnrangoRamosLibrary.UCCmb ucCmbTarga;
        private AnrangoRamosLibrary.UCCmb ucCmbIdCliente;
    }
}

