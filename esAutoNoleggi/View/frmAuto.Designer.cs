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
            this.dgvAuto = new System.Windows.Forms.DataGridView();
            this.btnInserire = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.chkCambioAutomatico = new System.Windows.Forms.CheckBox();
            this.grbOperazioni = new System.Windows.Forms.GroupBox();
            this.grbDati = new System.Windows.Forms.GroupBox();
            this.ucCmbAlimentazione = new AnrangoRamosLibrary.UCCmb();
            this.ucCmbModello = new AnrangoRamosLibrary.UCCmb();
            this.ucTxtColore = new AnrangoRamosLibrary.UCTxt();
            this.ucNudKm = new AnrangoRamosLibrary.UCNud();
            this.ucTxtTarga = new AnrangoRamosLibrary.UCTxt();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            this.grbOperazioni.SuspendLayout();
            this.grbDati.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuto
            // 
            this.dgvAuto.AllowUserToAddRows = false;
            this.dgvAuto.AllowUserToDeleteRows = false;
            this.dgvAuto.AllowUserToResizeColumns = false;
            this.dgvAuto.AllowUserToResizeRows = false;
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.Location = new System.Drawing.Point(9, 11);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.ReadOnly = true;
            this.dgvAuto.RowHeadersWidth = 51;
            this.dgvAuto.Size = new System.Drawing.Size(647, 348);
            this.dgvAuto.TabIndex = 0;
            // 
            // btnInserire
            // 
            this.btnInserire.Location = new System.Drawing.Point(5, 18);
            this.btnInserire.Name = "btnInserire";
            this.btnInserire.Size = new System.Drawing.Size(115, 23);
            this.btnInserire.TabIndex = 1;
            this.btnInserire.Text = "INSERIRE";
            this.btnInserire.UseVisualStyleBackColor = true;
            this.btnInserire.Click += new System.EventHandler(this.btnInserire_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(5, 59);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(115, 23);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "ELIMINARE";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(5, 102);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(115, 23);
            this.btnModificare.TabIndex = 3;
            this.btnModificare.Text = "MODIFICARE";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
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
            // grbOperazioni
            // 
            this.grbOperazioni.Controls.Add(this.btnInserire);
            this.grbOperazioni.Controls.Add(this.btnElimina);
            this.grbOperazioni.Controls.Add(this.btnModificare);
            this.grbOperazioni.Location = new System.Drawing.Point(9, 366);
            this.grbOperazioni.Margin = new System.Windows.Forms.Padding(2);
            this.grbOperazioni.Name = "grbOperazioni";
            this.grbOperazioni.Padding = new System.Windows.Forms.Padding(2);
            this.grbOperazioni.Size = new System.Drawing.Size(130, 222);
            this.grbOperazioni.TabIndex = 11;
            this.grbOperazioni.TabStop = false;
            this.grbOperazioni.Text = "OPERAZIONI";
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
            this.grbDati.Margin = new System.Windows.Forms.Padding(2);
            this.grbDati.Name = "grbDati";
            this.grbDati.Padding = new System.Windows.Forms.Padding(2);
            this.grbDati.Size = new System.Drawing.Size(252, 222);
            this.grbDati.TabIndex = 12;
            this.grbDati.TabStop = false;
            this.grbDati.Text = "DATI AUTO";
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
            this.ClientSize = new System.Drawing.Size(667, 596);
            this.Controls.Add(this.grbDati);
            this.Controls.Add(this.grbOperazioni);
            this.Controls.Add(this.dgvAuto);
            this.Name = "frmAuto";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            this.grbOperazioni.ResumeLayout(false);
            this.grbDati.ResumeLayout(false);
            this.grbDati.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuto;
        private System.Windows.Forms.Button btnInserire;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.CheckBox chkCambioAutomatico;
        private System.Windows.Forms.GroupBox grbOperazioni;
        private System.Windows.Forms.GroupBox grbDati;
        private AnrangoRamosLibrary.UCCmb ucCmbAlimentazione;
        private AnrangoRamosLibrary.UCCmb ucCmbModello;
        private AnrangoRamosLibrary.UCTxt ucTxtColore;
        private AnrangoRamosLibrary.UCNud ucNudKm;
        private AnrangoRamosLibrary.UCTxt ucTxtTarga;
    }
}

