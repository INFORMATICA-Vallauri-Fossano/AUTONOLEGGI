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

namespace esAutoNoleggi
{
    public partial class frmClienti : Form
    {
        clsClientiController clientiC;
        clsClienti cliente = new clsClienti();

        public int IdCliente
        {
            get
            {
                try
                {
                    cliente.IdCliente = Convert.ToInt32(ucTxtIdCliente.Text);
                    return cliente.IdCliente;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in IdCliente");
                    return 0; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    cliente.IdCliente = value;
                    ucTxtIdCliente.Text = cliente.IdCliente.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in IdCliente");
                }
            }
        }

        public string Cognome
        {
            get
            {
                try
                {
                    cliente.Cognome = ucTxtCognome.Text;
                    return cliente.Cognome;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Cognome");
                    return string.Empty; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    cliente.Cognome = value.Trim();
                    ucTxtCognome.Text = cliente.Cognome;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Cognome");
                }
            }
        }

        public string Nome
        {
            get
            {
                try
                {
                    cliente.Nome = ucTxtNome.Text;
                    return cliente.Nome;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Nome");
                    return string.Empty; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    cliente.Nome = value.Trim();
                    ucTxtNome.Text = cliente.Nome;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Nome");
                }
            }
        }

        public string Telefono
        {
            get
            {
                try
                {
                    cliente.Telefono = ucTxtTelefono.Text;
                    return cliente.Telefono;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Telefono");
                    return string.Empty; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    cliente.Telefono = value.Trim();
                    ucTxtTelefono.Text = cliente.Telefono;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Telefono");
                }
            }
        }

        public string Email
        {
            get
            {
                try
                {
                    cliente.Email = ucTxtEmail.Text;
                    return cliente.Email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Email");
                    return string.Empty; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    cliente.Email = value.Trim();
                    ucTxtEmail.Text = cliente.Email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Email");
                }
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
                clientiC = new clsClientiController("DB_NoleggioAuto.mdf");
                dgvClienti.DataSource = clientiC.VisualizzaTuttiClienti();

                dgvClienti.AutoResizeColumns();
                if (dgvClienti.Rows.Count == 0)
                {
                    MessageBox.Show("AL MOMENTO NON CI SONO CLIENTI DISPONIBILI");
                }

                dgvClienti.RowStateChanged += dgvAuto_StateChanged;
                dgvClienti.CellStateChanged += dgvAuto_StateChanged;
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
                dgvClienti.DataSource = clientiC.VisualizzaTuttiClienti();

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
                dgvClienti.DataSource = clientiC.VisualizzaTuttiClienti();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE");
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            try
            {
                clientiC.ModificaCliente(IdCliente, Cognome, Nome, Telefono, Email);
                dgvClienti.DataSource = clientiC.VisualizzaTuttiClienti();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE");
            }
        }

        private void dgvAuto_StateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int index = e.Row.Index;
            setAutoFromDgv(index);
        }
        private void dgvAuto_StateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            int index = e.Cell.RowIndex;
            setAutoFromDgv(index);
        }

        private void setAutoFromDgv(int index)
        {
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvClienti.Rows[index];
                IdCliente = Convert.ToInt32(selectedRow.Cells["IDCLIENTE"].Value);
                Cognome = selectedRow.Cells["COGNOME"].Value.ToString();
                Nome = selectedRow.Cells["NOME"].Value.ToString();
                Telefono = selectedRow.Cells["TELEFONO"].Value.ToString();
                Email = selectedRow.Cells["EMAIL"].Value.ToString();
            }
        }
    }
}
