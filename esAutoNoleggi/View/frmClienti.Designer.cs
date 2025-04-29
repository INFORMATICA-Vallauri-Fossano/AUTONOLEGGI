namespace esAutoNoleggi
{
    partial class frmClienti
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
            this.ucTxtCognome = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtNome = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtTelefono = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtEmail = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtSaldo = new AnrangoRamosLibrary.UCTxt();
            this.grbOperazioni.SuspendLayout();
            this.grbDati.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOperazioni
            // 
            this.grbOperazioni.Size = new System.Drawing.Size(130, 194);
            // 
            // grbDati
            // 
            this.grbDati.Controls.Add(this.ucTxtSaldo);
            this.grbDati.Controls.Add(this.ucTxtCognome);
            this.grbDati.Controls.Add(this.ucTxtNome);
            this.grbDati.Controls.Add(this.ucTxtTelefono);
            this.grbDati.Controls.Add(this.ucTxtEmail);
            this.grbDati.Size = new System.Drawing.Size(252, 194);
            // 
            // btnInserimento
            // 
            this.btnInserimento.Click += new System.EventHandler(this.btnInserire_Click);
            // 
            // btnEliminazione
            // 
            this.btnEliminazione.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // ucTxtCognome
            // 
            this.ucTxtCognome.Label = "COGNOME";
            this.ucTxtCognome.Location = new System.Drawing.Point(5, 18);
            this.ucTxtCognome.Name = "ucTxtCognome";
            this.ucTxtCognome.Size = new System.Drawing.Size(231, 28);
            this.ucTxtCognome.TabIndex = 13;
            // 
            // ucTxtNome
            // 
            this.ucTxtNome.Label = "NOME";
            this.ucTxtNome.Location = new System.Drawing.Point(5, 52);
            this.ucTxtNome.Name = "ucTxtNome";
            this.ucTxtNome.Size = new System.Drawing.Size(231, 28);
            this.ucTxtNome.TabIndex = 12;
            // 
            // ucTxtTelefono
            // 
            this.ucTxtTelefono.Label = "TELEFONO";
            this.ucTxtTelefono.Location = new System.Drawing.Point(5, 86);
            this.ucTxtTelefono.Name = "ucTxtTelefono";
            this.ucTxtTelefono.Size = new System.Drawing.Size(231, 28);
            this.ucTxtTelefono.TabIndex = 11;
            // 
            // ucTxtEmail
            // 
            this.ucTxtEmail.Label = "EMAIL";
            this.ucTxtEmail.Location = new System.Drawing.Point(5, 120);
            this.ucTxtEmail.Name = "ucTxtEmail";
            this.ucTxtEmail.Size = new System.Drawing.Size(231, 28);
            this.ucTxtEmail.TabIndex = 10;
            // 
            // ucTxtSaldo
            // 
            this.ucTxtSaldo.Label = "SALDO";
            this.ucTxtSaldo.Location = new System.Drawing.Point(5, 154);
            this.ucTxtSaldo.Name = "ucTxtSaldo";
            this.ucTxtSaldo.Size = new System.Drawing.Size(231, 28);
            this.ucTxtSaldo.TabIndex = 15;
            // 
            // frmClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 585);
            this.Name = "frmClienti";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmAuto_Load);
            this.grbOperazioni.ResumeLayout(false);
            this.grbDati.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AnrangoRamosLibrary.UCTxt ucTxtCognome;
        private AnrangoRamosLibrary.UCTxt ucTxtNome;
        private AnrangoRamosLibrary.UCTxt ucTxtTelefono;
        private AnrangoRamosLibrary.UCTxt ucTxtEmail;
        private AnrangoRamosLibrary.UCTxt ucTxtSaldo;
    }
}

