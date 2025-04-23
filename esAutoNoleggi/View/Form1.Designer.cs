namespace esAutoNoleggi.View
{
    partial class Form1
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
            this.ucTxtCognome = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtNome = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtTelefono = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtEmail = new AnrangoRamosLibrary.UCTxt();
            this.ucTxtIdCliente = new AnrangoRamosLibrary.UCTxt();
            this.SuspendLayout();
            // 
            // ucTxtCognome
            // 
            this.ucTxtCognome.Label = "COGNOME";
            this.ucTxtCognome.Location = new System.Drawing.Point(285, 177);
            this.ucTxtCognome.Name = "ucTxtCognome";
            this.ucTxtCognome.Size = new System.Drawing.Size(231, 28);
            this.ucTxtCognome.TabIndex = 8;
            // 
            // ucTxtNome
            // 
            this.ucTxtNome.Label = "NOME";
            this.ucTxtNome.Location = new System.Drawing.Point(285, 211);
            this.ucTxtNome.Name = "ucTxtNome";
            this.ucTxtNome.Size = new System.Drawing.Size(231, 28);
            this.ucTxtNome.TabIndex = 7;
            // 
            // ucTxtTelefono
            // 
            this.ucTxtTelefono.Label = "TELEFONO";
            this.ucTxtTelefono.Location = new System.Drawing.Point(285, 245);
            this.ucTxtTelefono.Name = "ucTxtTelefono";
            this.ucTxtTelefono.Size = new System.Drawing.Size(231, 28);
            this.ucTxtTelefono.TabIndex = 6;
            // 
            // ucTxtEmail
            // 
            this.ucTxtEmail.Label = "EMAIL";
            this.ucTxtEmail.Location = new System.Drawing.Point(285, 279);
            this.ucTxtEmail.Name = "ucTxtEmail";
            this.ucTxtEmail.Size = new System.Drawing.Size(231, 28);
            this.ucTxtEmail.TabIndex = 5;
            // 
            // ucTxtIdCliente
            // 
            this.ucTxtIdCliente.Label = "CLIENTE";
            this.ucTxtIdCliente.Location = new System.Drawing.Point(285, 143);
            this.ucTxtIdCliente.Name = "ucTxtIdCliente";
            this.ucTxtIdCliente.Size = new System.Drawing.Size(231, 28);
            this.ucTxtIdCliente.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucTxtIdCliente);
            this.Controls.Add(this.ucTxtCognome);
            this.Controls.Add(this.ucTxtNome);
            this.Controls.Add(this.ucTxtTelefono);
            this.Controls.Add(this.ucTxtEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AnrangoRamosLibrary.UCTxt ucTxtCognome;
        private AnrangoRamosLibrary.UCTxt ucTxtNome;
        private AnrangoRamosLibrary.UCTxt ucTxtTelefono;
        private AnrangoRamosLibrary.UCTxt ucTxtEmail;
        private AnrangoRamosLibrary.UCTxt ucTxtIdCliente;
    }
}