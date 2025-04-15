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
            this.dgvNoleggi = new System.Windows.Forms.DataGridView();
            this.btnInserire = new System.Windows.Forms.Button();
            this.btnTermina = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.grbOperazioni = new System.Windows.Forms.GroupBox();
            this.grbDati = new System.Windows.Forms.GroupBox();
            this.ucTxtDataFine = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtDataInizio = new AnrangoRamosLibrary.UCTxt();
            this.ucCmbTarga = new AnrangoRamosLibrary.UCCmb();
            this.ucCmbIdCliente = new AnrangoRamosLibrary.UCCmb();
            this.ucTxtIdNoleggio = new AnrangoRamosLibrary.UCTxt();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoleggi)).BeginInit();
            this.grbOperazioni.SuspendLayout();
            this.grbDati.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNoleggi
            // 
            this.dgvNoleggi.AllowUserToAddRows = false;
            this.dgvNoleggi.AllowUserToDeleteRows = false;
            this.dgvNoleggi.AllowUserToResizeColumns = false;
            this.dgvNoleggi.AllowUserToResizeRows = false;
            this.dgvNoleggi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoleggi.Location = new System.Drawing.Point(9, 11);
            this.dgvNoleggi.Name = "dgvNoleggi";
            this.dgvNoleggi.ReadOnly = true;
            this.dgvNoleggi.RowHeadersWidth = 51;
            this.dgvNoleggi.Size = new System.Drawing.Size(647, 348);
            this.dgvNoleggi.TabIndex = 0;
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
            // btnTermina
            // 
            this.btnTermina.Location = new System.Drawing.Point(5, 59);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(115, 23);
            this.btnTermina.TabIndex = 2;
            this.btnTermina.Text = "TERMINARE";
            this.btnTermina.UseVisualStyleBackColor = true;
            this.btnTermina.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Enabled = false;
            this.btnModificare.Location = new System.Drawing.Point(5, 102);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(115, 23);
            this.btnModificare.TabIndex = 3;
            this.btnModificare.Text = "MODIFICARE";
            this.btnModificare.UseVisualStyleBackColor = true;
            // 
            // grbOperazioni
            // 
            this.grbOperazioni.Controls.Add(this.btnInserire);
            this.grbOperazioni.Controls.Add(this.btnTermina);
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
            this.grbDati.Controls.Add(this.ucTxtDataFine);
            this.grbDati.Controls.Add(this.ucTxtDataInizio);
            this.grbDati.Controls.Add(this.ucCmbTarga);
            this.grbDati.Controls.Add(this.ucCmbIdCliente);
            this.grbDati.Controls.Add(this.ucTxtIdNoleggio);
            this.grbDati.Location = new System.Drawing.Point(144, 366);
            this.grbDati.Margin = new System.Windows.Forms.Padding(2);
            this.grbDati.Name = "grbDati";
            this.grbDati.Padding = new System.Windows.Forms.Padding(2);
            this.grbDati.Size = new System.Drawing.Size(252, 222);
            this.grbDati.TabIndex = 12;
            this.grbDati.TabStop = false;
            this.grbDati.Text = "OPERAZIONI";
            // 
            // ucTxtDataFine
            // 
            this.ucTxtDataFine.Label = "DATA FINE";
            this.ucTxtDataFine.Location = new System.Drawing.Point(5, 154);
            this.ucTxtDataFine.Name = "ucTxtDataFine";
            this.ucTxtDataFine.Size = new System.Drawing.Size(231, 28);
            this.ucTxtDataFine.TabIndex = 23;
            // 
            // ucTxtDataInizio
            // 
            this.ucTxtDataInizio.Label = "DATA INIZIO";
            this.ucTxtDataInizio.Location = new System.Drawing.Point(5, 120);
            this.ucTxtDataInizio.Name = "ucTxtDataInizio";
            this.ucTxtDataInizio.Size = new System.Drawing.Size(231, 28);
            this.ucTxtDataInizio.TabIndex = 22;
            // 
            // ucCmbTarga
            // 
            this.ucCmbTarga.Label = "TARGA";
            this.ucCmbTarga.Location = new System.Drawing.Point(5, 52);
            this.ucCmbTarga.Name = "ucCmbTarga";
            this.ucCmbTarga.Size = new System.Drawing.Size(231, 28);
            this.ucCmbTarga.TabIndex = 21;
            // 
            // ucCmbIdCliente
            // 
            this.ucCmbIdCliente.Label = "CLIENTE";
            this.ucCmbIdCliente.Location = new System.Drawing.Point(5, 86);
            this.ucCmbIdCliente.Name = "ucCmbIdCliente";
            this.ucCmbIdCliente.Size = new System.Drawing.Size(231, 28);
            this.ucCmbIdCliente.TabIndex = 20;
            // 
            // ucTxtIdNoleggio
            // 
            this.ucTxtIdNoleggio.Label = "ID";
            this.ucTxtIdNoleggio.Location = new System.Drawing.Point(5, 18);
            this.ucTxtIdNoleggio.Name = "ucTxtIdNoleggio";
            this.ucTxtIdNoleggio.Size = new System.Drawing.Size(231, 28);
            this.ucTxtIdNoleggio.TabIndex = 17;
            // 
            // frmNoleggi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 596);
            this.Controls.Add(this.grbDati);
            this.Controls.Add(this.grbOperazioni);
            this.Controls.Add(this.dgvNoleggi);
            this.Name = "frmNoleggi";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmNoleggi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoleggi)).EndInit();
            this.grbOperazioni.ResumeLayout(false);
            this.grbDati.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNoleggi;
        private System.Windows.Forms.Button btnInserire;
        private System.Windows.Forms.Button btnTermina;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.GroupBox grbOperazioni;
        private System.Windows.Forms.GroupBox grbDati;
        private AnrangoRamosLibrary.UCCmb ucCmbIdCliente;
        private AnrangoRamosLibrary.UCTxt ucTxtIdNoleggio;
        private AnrangoRamosLibrary.UCCmb ucCmbTarga;
        private AnrangoRamosLibrary.UCTxt ucTxtDataFine;
        private AnrangoRamosLibrary.UCTxt ucTxtDataInizio;
    }
}

