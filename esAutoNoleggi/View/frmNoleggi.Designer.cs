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
            this.dgvNoleggiCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chkNoleggiDaTerminare = new System.Windows.Forms.CheckBox();
            this.chkDaPagare = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grbOperazioni.SuspendLayout();
            this.grbDati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoleggiCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOperazioni
            // 
            this.grbOperazioni.Controls.Add(this.label3);
            this.grbOperazioni.Controls.Add(this.lblSaldo);
            this.grbOperazioni.Controls.Add(this.btnPaga);
            this.grbOperazioni.Controls.Add(this.label1);
            this.grbOperazioni.Controls.Add(this.lblIdNoleggio);
            this.grbOperazioni.Location = new System.Drawing.Point(525, 365);
            this.grbOperazioni.Size = new System.Drawing.Size(263, 160);
            this.grbOperazioni.Controls.SetChildIndex(this.lblIdNoleggio, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.btnModifica, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.btnEliminazione, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.btnInserimento, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.label1, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.btnPaga, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.lblSaldo, 0);
            this.grbOperazioni.Controls.SetChildIndex(this.label3, 0);
            // 
            // grbDati
            // 
            this.grbDati.Controls.Add(this.btnFineNow);
            this.grbDati.Controls.Add(this.btnInizioNow);
            this.grbDati.Controls.Add(this.ucTxtDataFine);
            this.grbDati.Controls.Add(this.ucTxtDataInizio);
            this.grbDati.Controls.Add(this.ucCmbTarga);
            this.grbDati.Controls.Add(this.ucCmbIdCliente);
            this.grbDati.Location = new System.Drawing.Point(17, 365);
            this.grbDati.Size = new System.Drawing.Size(329, 160);
            // 
            // btnInserimento
            // 
            this.btnInserimento.Location = new System.Drawing.Point(5, 103);
            this.btnInserimento.Click += new System.EventHandler(this.btnInserire_Click);
            // 
            // btnEliminazione
            // 
            this.btnEliminazione.Location = new System.Drawing.Point(143, 57);
            this.btnEliminazione.Text = "TERMINA";
            this.btnEliminazione.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(148, 132);
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
            this.lblIdNoleggio.Location = new System.Drawing.Point(29, 13);
            this.lblIdNoleggio.Name = "lblIdNoleggio";
            this.lblIdNoleggio.Size = new System.Drawing.Size(89, 23);
            this.lblIdNoleggio.TabIndex = 4;
            this.lblIdNoleggio.Text = "XX";
            this.lblIdNoleggio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // btnPaga
            // 
            this.btnPaga.Location = new System.Drawing.Point(8, 57);
            this.btnPaga.Name = "btnPaga";
            this.btnPaga.Size = new System.Drawing.Size(115, 23);
            this.btnPaga.TabIndex = 6;
            this.btnPaga.Text = "PAGA";
            this.btnPaga.UseVisualStyleBackColor = true;
            this.btnPaga.Click += new System.EventHandler(this.btnPaga_Click);
            // 
            // dgvNoleggiCliente
            // 
            this.dgvNoleggiCliente.AllowUserToAddRows = false;
            this.dgvNoleggiCliente.AllowUserToDeleteRows = false;
            this.dgvNoleggiCliente.AllowUserToResizeColumns = false;
            this.dgvNoleggiCliente.AllowUserToResizeRows = false;
            this.dgvNoleggiCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoleggiCliente.Location = new System.Drawing.Point(12, 562);
            this.dgvNoleggiCliente.Name = "dgvNoleggiCliente";
            this.dgvNoleggiCliente.ReadOnly = true;
            this.dgvNoleggiCliente.Size = new System.Drawing.Size(776, 187);
            this.dgvNoleggiCliente.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "AUTO NOLEGGIATE DAL CLIENTE";
            // 
            // chkNoleggiDaTerminare
            // 
            this.chkNoleggiDaTerminare.AutoSize = true;
            this.chkNoleggiDaTerminare.Location = new System.Drawing.Point(493, 542);
            this.chkNoleggiDaTerminare.Name = "chkNoleggiDaTerminare";
            this.chkNoleggiDaTerminare.Size = new System.Drawing.Size(108, 17);
            this.chkNoleggiDaTerminare.TabIndex = 25;
            this.chkNoleggiDaTerminare.Text = "DA TERMINARE";
            this.chkNoleggiDaTerminare.UseVisualStyleBackColor = true;
            this.chkNoleggiDaTerminare.CheckedChanged += new System.EventHandler(this.chkNoleggiDaTerminare_CheckedChanged);
            // 
            // chkDaPagare
            // 
            this.chkDaPagare.AutoSize = true;
            this.chkDaPagare.Location = new System.Drawing.Point(399, 542);
            this.chkDaPagare.Name = "chkDaPagare";
            this.chkDaPagare.Size = new System.Drawing.Size(88, 17);
            this.chkDaPagare.TabIndex = 26;
            this.chkDaPagare.Text = "DA PAGARE";
            this.chkDaPagare.UseVisualStyleBackColor = true;
            this.chkDaPagare.CheckedChanged += new System.EventHandler(this.chkDaPagare_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SALDO";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Location = new System.Drawing.Point(56, 31);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(62, 23);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "XXXX";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmNoleggi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 764);
            this.Controls.Add(this.chkDaPagare);
            this.Controls.Add(this.chkNoleggiDaTerminare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNoleggiCliente);
            this.Name = "frmNoleggi";
            this.Text = "GESTIONE AUTOMOBILI DEL NOLEGGIO";
            this.Load += new System.EventHandler(this.frmNoleggi_Load);
            this.Controls.SetChildIndex(this.grbOperazioni, 0);
            this.Controls.SetChildIndex(this.grbDati, 0);
            this.Controls.SetChildIndex(this.dgvNoleggiCliente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.chkNoleggiDaTerminare, 0);
            this.Controls.SetChildIndex(this.chkDaPagare, 0);
            this.grbOperazioni.ResumeLayout(false);
            this.grbOperazioni.PerformLayout();
            this.grbDati.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoleggiCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvNoleggiCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkNoleggiDaTerminare;
        private System.Windows.Forms.CheckBox chkDaPagare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSaldo;
    }
}

