using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnrangoRamosLibrary;

namespace esAutoNoleggi.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        private bool validCredentials = false;
      
        public string Utente { get => txtUtente.Text; set => txtUtente.Text = value; }
        private string Password { get => txtPassword.Text; }
        //public string Password { get => password;}
        public bool ValidCredentials { get => validCredentials; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateCredentials(Utente, Password)) {
                   validCredentials = true;
                   MessageBox.Show("Login Effettuato con Successo!");
                }
                else throw new Exception("Email e Password non Corrispondono");

            }
            catch (Exception ex)
            {
                ResetEmailPassword();
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateCredentials(string utente, string password)
        {
            ADOSQLServer2017 ado= new ADOSQLServer2017("noleggi");
            SqlCommand cmd=new SqlCommand("SELECT count(*) FROM Utenti WHERE utente = @utente AND password = @password");
            cmd.Parameters.AddWithValue("@utente", utente);
            cmd.Parameters.AddWithValue("@password", password);
            if(Convert.ToInt16(ado.EseguiScalar(cmd))==0) throw new Exception("Email e Password non Corrispondono");
            else return true;
        }

        private void ResetEmailPassword()
        {
            Utente = "";
            txtPassword.Text = "";
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock)) lblCapsLock.Visible = true;
            else lblCapsLock.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
