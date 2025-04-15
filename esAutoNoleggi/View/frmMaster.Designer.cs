namespace esAutoNoleggi.View
{
    partial class frmMaster
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
            this.btnInserimento = new System.Windows.Forms.Button();
            this.btnEliminazione = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.grbOperazioni = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.grbDati = new System.Windows.Forms.GroupBox();
            this.grbOperazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserimento
            // 
            this.btnInserimento.Location = new System.Drawing.Point(5, 18);
            this.btnInserimento.Name = "btnInserimento";
            this.btnInserimento.Size = new System.Drawing.Size(115, 23);
            this.btnInserimento.TabIndex = 1;
            this.btnInserimento.Text = "INSERIRE";
            this.btnInserimento.UseVisualStyleBackColor = true;
            // 
            // btnEliminazione
            // 
            this.btnEliminazione.Location = new System.Drawing.Point(5, 59);
            this.btnEliminazione.Name = "btnEliminazione";
            this.btnEliminazione.Size = new System.Drawing.Size(115, 23);
            this.btnEliminazione.TabIndex = 2;
            this.btnEliminazione.Text = "ELIMINARE";
            this.btnEliminazione.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(5, 102);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(115, 23);
            this.btnModifica.TabIndex = 3;
            this.btnModifica.Text = "MODIFICARE";
            this.btnModifica.UseVisualStyleBackColor = true;
            // 
            // grbOperazioni
            // 
            this.grbOperazioni.Controls.Add(this.btnInserimento);
            this.grbOperazioni.Controls.Add(this.btnEliminazione);
            this.grbOperazioni.Controls.Add(this.btnModifica);
            this.grbOperazioni.Location = new System.Drawing.Point(12, 380);
            this.grbOperazioni.Margin = new System.Windows.Forms.Padding(2);
            this.grbOperazioni.Name = "grbOperazioni";
            this.grbOperazioni.Padding = new System.Windows.Forms.Padding(2);
            this.grbOperazioni.Size = new System.Drawing.Size(130, 222);
            this.grbOperazioni.TabIndex = 12;
            this.grbOperazioni.TabStop = false;
            this.grbOperazioni.Text = "OPERAZIONI";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(647, 348);
            this.dgv.TabIndex = 13;
            // 
            // grbDati
            // 
            this.grbDati.Location = new System.Drawing.Point(146, 380);
            this.grbDati.Margin = new System.Windows.Forms.Padding(2);
            this.grbDati.Name = "grbDati";
            this.grbDati.Padding = new System.Windows.Forms.Padding(2);
            this.grbDati.Size = new System.Drawing.Size(252, 222);
            this.grbDati.TabIndex = 22;
            this.grbDati.TabStop = false;
            this.grbDati.Text = "DATI";
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.grbDati);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.grbOperazioni);
            this.Name = "frmMaster";
            this.Text = "frmMaster";
            this.grbOperazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserimento;
        private System.Windows.Forms.Button btnEliminazione;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.GroupBox grbOperazioni;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox grbDati;
    }
}