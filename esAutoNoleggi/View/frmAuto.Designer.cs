namespace ES32noleggioAuto
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
            this.cmbModelli = new System.Windows.Forms.ComboBox();
            this.cmbAlimentazione = new System.Windows.Forms.ComboBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.chkCambioAutomatico = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuto
            // 
            this.dgvAuto.AllowUserToAddRows = false;
            this.dgvAuto.AllowUserToDeleteRows = false;
            this.dgvAuto.AllowUserToResizeColumns = false;
            this.dgvAuto.AllowUserToResizeRows = false;
            this.dgvAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.Location = new System.Drawing.Point(0, 12);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.ReadOnly = true;
            this.dgvAuto.Size = new System.Drawing.Size(663, 426);
            this.dgvAuto.TabIndex = 0;
            // 
            // btnInserire
            // 
            this.btnInserire.Location = new System.Drawing.Point(873, 54);
            this.btnInserire.Name = "btnInserire";
            this.btnInserire.Size = new System.Drawing.Size(115, 23);
            this.btnInserire.TabIndex = 1;
            this.btnInserire.Text = "INSERIRE";
            this.btnInserire.UseVisualStyleBackColor = true;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(873, 95);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(115, 23);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "ELIMINARE";
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(873, 138);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(115, 23);
            this.btnModificare.TabIndex = 3;
            this.btnModificare.Text = "MODIFICARE";
            this.btnModificare.UseVisualStyleBackColor = true;
            // 
            // cmbModelli
            // 
            this.cmbModelli.FormattingEnabled = true;
            this.cmbModelli.Location = new System.Drawing.Point(873, 370);
            this.cmbModelli.Name = "cmbModelli";
            this.cmbModelli.Size = new System.Drawing.Size(121, 21);
            this.cmbModelli.TabIndex = 4;
            // 
            // cmbAlimentazione
            // 
            this.cmbAlimentazione.FormattingEnabled = true;
            this.cmbAlimentazione.Location = new System.Drawing.Point(873, 397);
            this.cmbAlimentazione.Name = "cmbAlimentazione";
            this.cmbAlimentazione.Size = new System.Drawing.Size(121, 21);
            this.cmbAlimentazione.TabIndex = 5;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(873, 292);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 6;
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(873, 318);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 20);
            this.txtColore.TabIndex = 7;
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(873, 266);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(100, 20);
            this.txtTarga.TabIndex = 9;
            // 
            // chkCambioAutomatico
            // 
            this.chkCambioAutomatico.AutoSize = true;
            this.chkCambioAutomatico.Location = new System.Drawing.Point(873, 344);
            this.chkCambioAutomatico.Name = "chkCambioAutomatico";
            this.chkCambioAutomatico.Size = new System.Drawing.Size(117, 17);
            this.chkCambioAutomatico.TabIndex = 10;
            this.chkCambioAutomatico.Text = "Cambio Automatico";
            this.chkCambioAutomatico.UseVisualStyleBackColor = true;
            // 
            // frmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.chkCambioAutomatico);
            this.Controls.Add(this.txtTarga);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.cmbAlimentazione);
            this.Controls.Add(this.cmbModelli);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnInserire);
            this.Controls.Add(this.dgvAuto);
            this.Name = "frmAuto";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuto;
        private System.Windows.Forms.Button btnInserire;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.ComboBox cmbModelli;
        private System.Windows.Forms.ComboBox cmbAlimentazione;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.CheckBox chkCambioAutomatico;
    }
}

