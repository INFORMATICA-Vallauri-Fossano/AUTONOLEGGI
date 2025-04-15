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
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.btnInserire = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.grbOperazioni = new System.Windows.Forms.GroupBox();
            this.grbDati = new System.Windows.Forms.GroupBox();
            this.ucTxtCognome = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtNome = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtTelefono = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtEmail = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtIdCliente = new AnrangoRamosLibrary.UCTxt();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.grbOperazioni.SuspendLayout();
            this.grbDati.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClienti
            // 
            this.dgvClienti.AllowUserToAddRows = false;
            this.dgvClienti.AllowUserToDeleteRows = false;
            this.dgvClienti.AllowUserToResizeColumns = false;
            this.dgvClienti.AllowUserToResizeRows = false;
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(9, 11);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.ReadOnly = true;
            this.dgvClienti.RowHeadersWidth = 51;
            this.dgvClienti.Size = new System.Drawing.Size(647, 348);
            this.dgvClienti.TabIndex = 0;
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
            this.btnElimina.Enabled = false;
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
            // grbOperazioni
            // 
            this.grbOperazioni.Controls.Add(this.btnInserire);
            this.grbOperazioni.Controls.Add(this.btnElimina);
            this.grbOperazioni.Controls.Add(this.btnModificare);
            this.grbOperazioni.Location = new System.Drawing.Point(9, 366);
            this.grbOperazioni.Margin = new System.Windows.Forms.Padding(2);
            this.grbOperazioni.Name = "grbOperazioni";
            this.grbOperazioni.Padding = new System.Windows.Forms.Padding(2);
            this.grbOperazioni.Size = new System.Drawing.Size(130, 194);
            this.grbOperazioni.TabIndex = 11;
            this.grbOperazioni.TabStop = false;
            this.grbOperazioni.Text = "OPERAZIONI";
            // 
            // grbDati
            // 
            this.grbDati.Controls.Add(this.ucTxtIdCliente);
            this.grbDati.Controls.Add(this.ucTxtCognome);
            this.grbDati.Controls.Add(this.ucTxtNome);
            this.grbDati.Controls.Add(this.ucTxtTelefono);
            this.grbDati.Controls.Add(this.ucTxtEmail);
            this.grbDati.Location = new System.Drawing.Point(144, 366);
            this.grbDati.Margin = new System.Windows.Forms.Padding(2);
            this.grbDati.Name = "grbDati";
            this.grbDati.Padding = new System.Windows.Forms.Padding(2);
            this.grbDati.Size = new System.Drawing.Size(252, 194);
            this.grbDati.TabIndex = 12;
            this.grbDati.TabStop = false;
            this.grbDati.Text = "DATI CLIENTE";
            // 
            // ucTxtCognome
            // 
            this.ucTxtCognome.Label = "COGNOME";
            this.ucTxtCognome.Location = new System.Drawing.Point(5, 52);
            this.ucTxtCognome.Name = "ucTxtCognome";
            this.ucTxtCognome.Size = new System.Drawing.Size(231, 28);
            this.ucTxtCognome.TabIndex = 3;
            // 
            // ucTxtNome
            // 
            this.ucTxtNome.Label = "NOME";
            this.ucTxtNome.Location = new System.Drawing.Point(5, 86);
            this.ucTxtNome.Name = "ucTxtNome";
            this.ucTxtNome.Size = new System.Drawing.Size(231, 28);
            this.ucTxtNome.TabIndex = 2;
            // 
            // ucTxtTelefono
            // 
            this.ucTxtTelefono.Label = "TELEFONO";
            this.ucTxtTelefono.Location = new System.Drawing.Point(5, 120);
            this.ucTxtTelefono.Name = "ucTxtTelefono";
            this.ucTxtTelefono.Size = new System.Drawing.Size(231, 28);
            this.ucTxtTelefono.TabIndex = 1;
            // 
            // ucTxtEmail
            // 
            this.ucTxtEmail.Label = "EMAIL";
            this.ucTxtEmail.Location = new System.Drawing.Point(5, 154);
            this.ucTxtEmail.Name = "ucTxtEmail";
            this.ucTxtEmail.Size = new System.Drawing.Size(231, 28);
            this.ucTxtEmail.TabIndex = 0;
            // 
            // ucTxtIdCliente
            // 
            this.ucTxtIdCliente.Label = "CLIENTE";
            this.ucTxtIdCliente.Location = new System.Drawing.Point(5, 18);
            this.ucTxtIdCliente.Name = "ucTxtIdCliente";
            this.ucTxtIdCliente.Size = new System.Drawing.Size(231, 28);
            this.ucTxtIdCliente.TabIndex = 4;
            // 
            // frmClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 569);
            this.Controls.Add(this.grbDati);
            this.Controls.Add(this.grbOperazioni);
            this.Controls.Add(this.dgvClienti);
            this.Name = "frmClienti";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.grbOperazioni.ResumeLayout(false);
            this.grbDati.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.Button btnInserire;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.GroupBox grbOperazioni;
        private System.Windows.Forms.GroupBox grbDati;
        private AnrangoRamosLibrary.UCTxt ucTxtCognome;
        private AnrangoRamosLibrary.UCTxt ucTxtNome;
        private AnrangoRamosLibrary.UCTxt ucTxtTelefono;
        private AnrangoRamosLibrary.UCTxt ucTxtEmail;
        private AnrangoRamosLibrary.UCTxt ucTxtIdCliente;
    }
}

