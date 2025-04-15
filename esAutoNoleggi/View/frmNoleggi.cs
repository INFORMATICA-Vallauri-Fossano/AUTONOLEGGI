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
    public partial class frmNoleggi : Form
    {
        clsNoleggiController noleggiC;
        clsNoleggi noleggio = new clsNoleggi();

        public int IdNoleggio
        {
            get
            {
                try
                {
                    noleggio.IdNoleggio = Convert.ToInt32(ucTxtIdNoleggio.Text);
                    return noleggio.IdNoleggio;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in IdNoleggio");
                    return 0; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    noleggio.IdNoleggio = value;
                    ucTxtIdNoleggio.Text = noleggio.IdNoleggio.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in IdNoleggio");
                }
            }
        }
        public int IdCliente
        {
            get
            {
                try
                {
                    noleggio.IdCliente = Convert.ToInt32(ucCmbIdCliente.ElCmb.SelectedValue);
                    return noleggio.IdCliente;
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
                    noleggio.IdCliente = value;
                    ucCmbIdCliente.ElCmb.SelectedValue = noleggio.IdCliente;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in IdCliente");
                }
            }
        }
        public string IdTarga
        {
            get
            {
                try
                {
                    noleggio.Targa = ucCmbTarga.ElCmb.SelectedValue.ToString();
                    return noleggio.Targa;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in IdTarga");
                    return null; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    noleggio.Targa = value.ToString();
                    ucCmbTarga.ElCmb.SelectedValue = noleggio.Targa;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in IdTarga");
                }
            }
        }

        public DateTime DataInizio
        {
            get
            {
                try
                {
                    noleggio.DataInizio = Convert.ToDateTime(ucTxtDataInizio.Text);
                    return noleggio.DataInizio;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in DataInizio");
                    return DateTime.MinValue; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    noleggio.DataInizio = value;
                    ucTxtDataInizio.Text = noleggio.DataInizio.ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in DataInizio");
                }
            }
        }

        public DateTime? DataFine
        {
            get
            {
                try
                {
                    noleggio.DataFine = string.IsNullOrWhiteSpace(ucTxtDataFine.Text)
                        ? (DateTime?)null
                        : Convert.ToDateTime(ucTxtDataFine.Text);
                    return noleggio.DataFine;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in DataFine");
                    return null; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    noleggio.DataFine = value;
                    ucTxtDataFine.Text = noleggio.DataFine.HasValue
                        ? noleggio.DataFine.Value.ToString("yyyy-MM-dd")
                        : string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in DataFine");
                }
            }
        }

        public frmNoleggi()
        {
            InitializeComponent();
        }

        private void frmNoleggi_Load(object sender, EventArgs e)
        {
            try
            {
                noleggiC = new clsNoleggiController("DB_NoleggioAuto.mdf");

                // Load data into DataGridView
                dgvNoleggi.DataSource = noleggiC.GetAllNoleggi();

                // Load data into combo boxes
                ucCmbIdCliente.ElCmb.DataSource = noleggiC.GetAllClienti();
                ucCmbIdCliente.ElCmb.DisplayMember = "NOME";
                ucCmbIdCliente.ElCmb.ValueMember = "IDCLIENTE";

                ucCmbTarga.ElCmb.DataSource = noleggiC.GetAllAutoDisponibili();
                ucCmbTarga.ElCmb.DisplayMember = "Targa";
                ucCmbTarga.ElCmb.ValueMember = "Targa";

                dgvNoleggi.AutoResizeColumns();

                if (dgvNoleggi.Rows.Count == 0)
                {
                    MessageBox.Show("AL MOMENTO NON CI SONO NOLEGGI DISPONIBILI");
                }

                // Attach events
                dgvNoleggi.RowStateChanged += dgvNoleggi_StateChanged;
                dgvNoleggi.CellStateChanged += dgvNoleggi_StateChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE");
            }
        }

        private void dgvNoleggi_StateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int index = e.Row.Index;
            SetNoleggioFromDgv(index);
        }

        private void dgvNoleggi_StateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            int index = e.Cell.RowIndex;
            SetNoleggioFromDgv(index);
        }

        private void SetNoleggioFromDgv(int index)
        {
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvNoleggi.Rows[index];
                IdNoleggio = Convert.ToInt32(selectedRow.Cells["IdNoleggio"].Value);
                DataInizio = Convert.ToDateTime(selectedRow.Cells["DataInizio"].Value);
                DataFine = selectedRow.Cells["DataFine"].Value == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(selectedRow.Cells["DataFine"].Value);
                ucCmbIdCliente.ElCmb.SelectedValue = Convert.ToInt32(selectedRow.Cells["IdCliente"].Value);
                ucCmbTarga.ElCmb.SelectedValue = selectedRow.Cells["Targa"].Value.ToString();
            }
        }

        private void btnTermina_Click(object sender, EventArgs e)
        {
            noleggiC.TerminaNoleggio(IdNoleggio, DataFine);
            dgvNoleggi.DataSource = noleggiC.GetAllNoleggi();
        }

        private void btnInserire_Click(object sender, EventArgs e)
        {
            noleggiC.InserisciNoleggio(IdCliente,IdTarga,DataInizio,DataFine);
        }
    }

}
