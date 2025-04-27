namespace esAutoNoleggi.View
{
    partial class frmQuery
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnElencoAutoNoleggio = new System.Windows.Forms.Button();
            this.btnElencoAutoMaiNoleggiate = new System.Windows.Forms.Button();
            this.btnNoleggiInRangeDate = new System.Windows.Forms.Button();
            this.btnNoleggioTerminatoNonPagato = new System.Windows.Forms.Button();
            this.dtpInizio = new System.Windows.Forms.DateTimePicker();
            this.dtpFine = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 253);
            this.dgv.TabIndex = 0;
            // 
            // btnElencoAutoNoleggio
            // 
            this.btnElencoAutoNoleggio.Location = new System.Drawing.Point(12, 271);
            this.btnElencoAutoNoleggio.Name = "btnElencoAutoNoleggio";
            this.btnElencoAutoNoleggio.Size = new System.Drawing.Size(334, 23);
            this.btnElencoAutoNoleggio.TabIndex = 1;
            this.btnElencoAutoNoleggio.Text = "elenco delle auto in noleggio";
            this.btnElencoAutoNoleggio.UseVisualStyleBackColor = true;
            this.btnElencoAutoNoleggio.Click += new System.EventHandler(this.btnElencoAutoNoleggio_Click);
            // 
            // btnElencoAutoMaiNoleggiate
            // 
            this.btnElencoAutoMaiNoleggiate.Location = new System.Drawing.Point(12, 300);
            this.btnElencoAutoMaiNoleggiate.Name = "btnElencoAutoMaiNoleggiate";
            this.btnElencoAutoMaiNoleggiate.Size = new System.Drawing.Size(334, 23);
            this.btnElencoAutoMaiNoleggiate.TabIndex = 2;
            this.btnElencoAutoMaiNoleggiate.Text = "elenco auto mai noleggiate";
            this.btnElencoAutoMaiNoleggiate.UseVisualStyleBackColor = true;
            this.btnElencoAutoMaiNoleggiate.Click += new System.EventHandler(this.btnElencoAutoMaiNoleggiate_Click);
            // 
            // btnNoleggiInRangeDate
            // 
            this.btnNoleggiInRangeDate.Location = new System.Drawing.Point(12, 329);
            this.btnNoleggiInRangeDate.Name = "btnNoleggiInRangeDate";
            this.btnNoleggiInRangeDate.Size = new System.Drawing.Size(334, 23);
            this.btnNoleggiInRangeDate.TabIndex = 3;
            this.btnNoleggiInRangeDate.Text = "elenco dei noleggi effettuati tra 2 date";
            this.btnNoleggiInRangeDate.UseVisualStyleBackColor = true;
            this.btnNoleggiInRangeDate.Click += new System.EventHandler(this.btnNoleggiInRangeDate_Click);
            // 
            // btnNoleggioTerminatoNonPagato
            // 
            this.btnNoleggioTerminatoNonPagato.Location = new System.Drawing.Point(12, 358);
            this.btnNoleggioTerminatoNonPagato.Name = "btnNoleggioTerminatoNonPagato";
            this.btnNoleggioTerminatoNonPagato.Size = new System.Drawing.Size(334, 23);
            this.btnNoleggioTerminatoNonPagato.TabIndex = 4;
            this.btnNoleggioTerminatoNonPagato.Text = "elenco noleggi di auto già restituite ed ancora da pagare";
            this.btnNoleggioTerminatoNonPagato.UseVisualStyleBackColor = true;
            this.btnNoleggioTerminatoNonPagato.Click += new System.EventHandler(this.btnNoleggioTerminatoNonPagato_Click);
            // 
            // dtpInizio
            // 
            this.dtpInizio.Location = new System.Drawing.Point(352, 332);
            this.dtpInizio.Name = "dtpInizio";
            this.dtpInizio.Size = new System.Drawing.Size(200, 20);
            this.dtpInizio.TabIndex = 5;
            // 
            // dtpFine
            // 
            this.dtpFine.Location = new System.Drawing.Point(558, 332);
            this.dtpFine.Name = "dtpFine";
            this.dtpFine.Size = new System.Drawing.Size(200, 20);
            this.dtpFine.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFine);
            this.Controls.Add(this.dtpInizio);
            this.Controls.Add(this.btnNoleggioTerminatoNonPagato);
            this.Controls.Add(this.btnNoleggiInRangeDate);
            this.Controls.Add(this.btnElencoAutoMaiNoleggiate);
            this.Controls.Add(this.btnElencoAutoNoleggio);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "frmQueryCompito";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnElencoAutoNoleggio;
        private System.Windows.Forms.Button btnElencoAutoMaiNoleggiate;
        private System.Windows.Forms.Button btnNoleggiInRangeDate;
        private System.Windows.Forms.Button btnNoleggioTerminatoNonPagato;
        private System.Windows.Forms.DateTimePicker dtpInizio;
        private System.Windows.Forms.DateTimePicker dtpFine;
    }
}