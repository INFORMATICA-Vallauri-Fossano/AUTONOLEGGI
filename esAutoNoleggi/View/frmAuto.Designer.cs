namespace esAutoNoleggi
{
    partial class frmAuto
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
            this.ucCmbAlimentazione = new AnrangoRamosLibrary.UCCmb();
            this.ucCmbModello = new AnrangoRamosLibrary.UCCmb();
            this.ucTxtColore = new AnrangoRamosLibrary.UCTxt();
            this.ucNudKm = new AnrangoRamosLibrary.UCNud();
            this.chkCambioAutomatico = new System.Windows.Forms.CheckBox();
            this.ucTxtTarga = new AnrangoRamosLibrary.UCTxt();
            this.grbOperazioni.SuspendLayout();
            this.grbDati.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOperazioni
            // 
            this.grbOperazioni.Location = new System.Drawing.Point(9, 366);
            this.grbOperazioni.TabIndex = 11;
            // 
            // grbDati
            // 
            this.grbDati.Controls.Add(this.ucCmbAlimentazione);
            this.grbDati.Controls.Add(this.ucCmbModello);
            this.grbDati.Controls.Add(this.ucTxtColore);
            this.grbDati.Controls.Add(this.ucNudKm);
            this.grbDati.Controls.Add(this.ucTxtTarga);
            this.grbDati.Controls.Add(this.chkCambioAutomatico);
            this.grbDati.Location = new System.Drawing.Point(144, 366);
            this.grbDati.TabIndex = 12;
            this.grbDati.Text = "DATI AUTO";
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
            this.btnModifica.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // ucCmbAlimentazione
            // 
            this.ucCmbAlimentazione.Label = "ALIMENTAZIONE";
            this.ucCmbAlimentazione.Location = new System.Drawing.Point(5, 154);
            this.ucCmbAlimentazione.Name = "ucCmbAlimentazione";
            this.ucCmbAlimentazione.Size = new System.Drawing.Size(231, 28);
            this.ucCmbAlimentazione.TabIndex = 21;
            // 
            // ucCmbModello
            // 
            this.ucCmbModello.Label = "MODELLO";
            this.ucCmbModello.Location = new System.Drawing.Point(5, 120);
            this.ucCmbModello.Name = "ucCmbModello";
            this.ucCmbModello.Size = new System.Drawing.Size(231, 28);
            this.ucCmbModello.TabIndex = 20;
            // 
            // ucTxtColore
            // 
            this.ucTxtColore.Label = "COLORE";
            this.ucTxtColore.Location = new System.Drawing.Point(5, 86);
            this.ucTxtColore.Name = "ucTxtColore";
            this.ucTxtColore.Size = new System.Drawing.Size(231, 28);
            this.ucTxtColore.TabIndex = 19;
            // 
            // ucNudKm
            // 
            this.ucNudKm.Label = "KM";
            this.ucNudKm.Location = new System.Drawing.Point(5, 52);
            this.ucNudKm.Name = "ucNudKm";
            this.ucNudKm.Size = new System.Drawing.Size(231, 28);
            this.ucNudKm.TabIndex = 18;
            this.ucNudKm.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // chkCambioAutomatico
            // 
            this.chkCambioAutomatico.AutoSize = true;
            this.chkCambioAutomatico.Location = new System.Drawing.Point(106, 188);
            this.chkCambioAutomatico.Name = "chkCambioAutomatico";
            this.chkCambioAutomatico.Size = new System.Drawing.Size(141, 17);
            this.chkCambioAutomatico.TabIndex = 10;
            this.chkCambioAutomatico.Text = "CAMBIO AUTOMATICO";
            this.chkCambioAutomatico.UseVisualStyleBackColor = true;
            // 
            // ucTxtTarga
            // 
            this.ucTxtTarga.Label = "TARGA";
            this.ucTxtTarga.Location = new System.Drawing.Point(5, 18);
            this.ucTxtTarga.Name = "ucTxtTarga";
            this.ucTxtTarga.Size = new System.Drawing.Size(231, 28);
            this.ucTxtTarga.TabIndex = 17;
            // 
            // frmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 596);
            this.Name = "frmAuto";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmAuto_Load);
            this.grbOperazioni.ResumeLayout(false);
            this.grbDati.ResumeLayout(false);
            this.grbDati.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AnrangoRamosLibrary.UCCmb ucCmbAlimentazione;
        private AnrangoRamosLibrary.UCCmb ucCmbModello;
        private AnrangoRamosLibrary.UCTxt ucTxtColore;
        private AnrangoRamosLibrary.UCNud ucNudKm;
        private AnrangoRamosLibrary.UCTxt ucTxtTarga;
        private System.Windows.Forms.CheckBox chkCambioAutomatico;
    }
}

