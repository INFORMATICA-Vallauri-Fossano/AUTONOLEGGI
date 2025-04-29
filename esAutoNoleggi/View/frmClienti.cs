using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using esAutoNoleggi.Model;
using esAutoNoleggi.Controller;
using esAutoNoleggi.View;

namespace esAutoNoleggi
{
    public partial class frmClienti : frmMaster
    {
        clsClientiController clientiC;
        clsClienti cliente = new clsClienti();
        public float Saldo
        {
            get => cliente.Saldo=(float)Convert.ToDecimal(ucTxtSaldo.Text);
            set
            {
                cliente.Saldo = value;
                ucTxtSaldo.Text = cliente.Saldo.ToString();
            }
        }
        public int IdCliente
        {
            get=>cliente.IdCliente;
            set=>cliente.IdCliente = value;
        }

        public string Cognome
        {
            get
            {
                    cliente.Cognome = ucTxtCognome.Text;
                    return cliente.Cognome;
            }
            set
            {
                    cliente.Cognome = value.Trim();
                    ucTxtCognome.Text = cliente.Cognome;
            }
        }

        public string Nome
        {
            get
            {
                    cliente.Nome = ucTxtNome.Text;
                    return cliente.Nome;
            }
            set
            {
                    cliente.Nome = value.Trim();
                    ucTxtNome.Text = cliente.Nome;
            }
        }

        public string Telefono
        {
            get
            {
                    cliente.Telefono = ucTxtTelefono.Text;
                    return cliente.Telefono;
            }
            set
            {
                    cliente.Telefono = value.Trim();
                    ucTxtTelefono.Text = cliente.Telefono;
            }
        }

        public string Email
        {
            get
            {
                    cliente.Email = ucTxtEmail.Text;
                    return cliente.Email;
            }
            set
            {
                    cliente.Email = value.Trim();
                    ucTxtEmail.Text = cliente.Email;
            }
        }



        public frmClienti()
        {
            InitializeComponent();
        }
        private void frmAuto_Load(object sender, EventArgs e)
        {
            try
            {
                clientiC = new clsClientiController(useful.databaseName);
                dgv.DataSource = clientiC.VisualizzaTuttiClienti();

                dgv.AutoResizeColumns();
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("AL MOMENTO NON CI SONO CLIENTI DISPONIBILI");
                }
                dgv.RowEnter += dgv_RowEnter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE");
            }
        }

        private void btnInserire_Click(object sender, EventArgs e)
        {
            try
            {
                clientiC.InserisciCliente(Cognome, Nome, Telefono, Email);
                dgv.DataSource = clientiC.VisualizzaTuttiClienti();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE");
            } 
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                clientiC.EliminaCliente(IdCliente);
                dgv.DataSource = clientiC.VisualizzaTuttiClienti();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE");
            }
        }

        override protected void setDgv(int index)
        {
            if (index >= 0)
            {
                try
                {
                DataGridViewRow selectedRow = dgv.Rows[index];
                IdCliente = Convert.ToInt32(selectedRow.Cells["IDCLIENTE"].Value);
                Cognome = selectedRow.Cells["COGNOME"].Value.ToString();
                Nome = selectedRow.Cells["NOME"].Value.ToString();
                Telefono = selectedRow.Cells["TELEFONO"].Value.ToString();
                Email = selectedRow.Cells["EMAIL"].Value.ToString();
                    Saldo = (float)Convert.ToDecimal(selectedRow.Cells["SALDO"].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                clientiC.ModificaCliente(IdCliente, Cognome, Nome, Telefono, Email, Saldo);
                dgv.DataSource = clientiC.VisualizzaTuttiClienti();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
