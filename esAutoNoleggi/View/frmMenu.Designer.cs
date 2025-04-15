namespace esAutoNoleggi.View
{
    partial class frmMenu
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
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnNoleggi = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(12, 12);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(196, 40);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.Text = "GESTISCI AUTO";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnNoleggi
            // 
            this.btnNoleggi.Location = new System.Drawing.Point(12, 104);
            this.btnNoleggi.Name = "btnNoleggi";
            this.btnNoleggi.Size = new System.Drawing.Size(196, 40);
            this.btnNoleggi.TabIndex = 1;
            this.btnNoleggi.Text = "GESTISCI NOLEGGI";
            this.btnNoleggi.UseVisualStyleBackColor = true;
            this.btnNoleggi.Click += new System.EventHandler(this.btnNoleggi_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(12, 58);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(196, 40);
            this.btnClienti.TabIndex = 2;
            this.btnClienti.Text = "GESTISCI CLIENTI";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 164);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnNoleggi);
            this.Controls.Add(this.btnAuto);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnNoleggi;
        private System.Windows.Forms.Button btnClienti;
    }
}