using AnrangoRamosLibrary;
using esAutoNoleggi.Controller;
//
using esAutoNoleggi.Model;
using esAutoNoleggi.View;
using System;
using System.Windows.Forms;


namespace esAutoNoleggi
{
    public partial class frmNoleggi : frmMaster
    {
        clsNoleggiController noleggiC;
        clsNoleggi noleggio = new clsNoleggi();

        public int IdNoleggio
        {
            get => noleggio.IdNoleggio;
            set
            {
                noleggio.IdNoleggio = value;
                lblIdNoleggio.Text = noleggio.IdNoleggio.ToString();
            }
        }
        public int IdCliente
        {
            get
            {
                    noleggio.IdCliente = Convert.ToInt32(ucCmbIdCliente.ElCmb.SelectedValue);
                    return noleggio.IdCliente;
            }
            set
            {
                    noleggio.IdCliente = value;
                    ucCmbIdCliente.ElCmb.SelectedValue = noleggio.IdCliente;
            }
        }
        public string IdTarga
        {
            get
            {
                    if (ucCmbTarga.ElCmb.Text == "")
                        throw new Exception("Scegliere una targa disponibile");
                    noleggio.Targa = ucCmbTarga.ElCmb.SelectedValue.ToString();
                    return noleggio.Targa;
            }
            set
            {
                    noleggio.Targa = value.ToString();
                    ucCmbTarga.ElCmb.SelectedValue = noleggio.Targa;
            }
        }

        public DateTime DataInizio
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ucTxtDataInizio.Text))
                    throw new Exception("Scrivere una data di inizio");
                noleggio.DataInizio = Convert.ToDateTime(ucTxtDataInizio.Text);
                    return noleggio.DataInizio;
            }
            set
            {
                    noleggio.DataInizio = value;
                    ucTxtDataInizio.Text = noleggio.DataInizio.ToString("dd/MM/yyyy");
            }
        }

        public DateTime? DataFine
        {
            get
            {
                noleggio.DataFine = (DateTime?)null;
                 if(!string.IsNullOrWhiteSpace(ucTxtDataFine.Text))
                    noleggio.DataFine=Convert.ToDateTime(ucTxtDataFine.Text);

                    return noleggio.DataFine;
            }
            set
            {
                try
                {
                    noleggio.DataFine = value;
                    ucTxtDataFine.Text = noleggio.DataFine.HasValue
                        ? noleggio.DataFine.Value.ToString("dd/MM/yyyy")
                        : string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in DataFine");
                }
            }
        }
        public string Saldo { get => noleggiC.GetScalate("SELECT SALDO FROM CLIENTI WHERE IDCLIENTe="+IdCliente); }

        public frmNoleggi()
        {
            InitializeComponent();
        }

        private void frmNoleggi_Load(object sender, EventArgs e)
        {
            try
            {
                noleggiC = new clsNoleggiController(useful.databaseName);

                // Load data into DataGridView
                dgv.DataSource = noleggiC.GetAutoDisponibili();

                // Load data into combo boxes
                ucCmbIdCliente.ElCmb.DataSource = noleggiC.GetAllClienti();
                ucCmbIdCliente.ElCmb.DisplayMember = "NOME";
                ucCmbIdCliente.ElCmb.ValueMember = "IDCLIENTE";

                caricaTargheDisponibili();

                dgv.AutoResizeColumns();

                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("AL MOMENTO NON CI SONO NOLEGGI DISPONIBILI");
                }

                // Attach events
                dgv.RowEnter += dgv_RowEnter;
                dgvNoleggiCliente.RowEnter += dgvCliente_RowEnter;
                ucCmbIdCliente.ElCmb.SelectedValueChanged += clientcomboChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE");
            }
        }

        private void dgvCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvNoleggiCliente.Rows[index];
                IdNoleggio = Convert.ToInt32(selectedRow.Cells["IdNoleggio"].Value);
                DataInizio = Convert.ToDateTime(selectedRow.Cells["DataInizio"].Value);
                DataFine = selectedRow.Cells["DataFine"].Value == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(selectedRow.Cells["DataFine"].Value);
                ucCmbTarga.ElCmb.SelectedValue = selectedRow.Cells["Targa"].Value.ToString();
            }
        }

        private void clientcomboChanged(object sender,EventArgs e)
        {
            setDgvClient();
        }
        override protected void setDgv(int index)
        {
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgv.Rows[index];
                ucCmbTarga.ElCmb.SelectedValue = selectedRow.Cells["Targa"].Value.ToString();
            }
        }
        private void setDgvClient()
        {

            dgvNoleggiCliente.DataSource = noleggiC.GetNoleggiByIdCliente(IdCliente,chkDaPagare.Checked,chkNoleggiDaTerminare.Checked);
            lblSaldo.Text = Saldo;
        }

        private void btnTermina_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucTxtDataFine.Text == "")
                    throw new Exception("Scrivere una data di fine");
                noleggiC.TerminaNoleggio(IdNoleggio, DataFine);
                dgv.DataSource = noleggiC.GetAutoDisponibili();
                dgvNoleggiCliente.DataSource = noleggiC.GetNoleggiByIdCliente(IdCliente,chkDaPagare.Checked,chkNoleggiDaTerminare.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInserire_Click(object sender, EventArgs e)
        {
            try
            {
                noleggiC.InserisciNoleggio(IdCliente, IdTarga, DataInizio, DataFine);
                dgv.DataSource = noleggiC.GetAutoDisponibili();
                dgvNoleggiCliente.DataSource = noleggiC.GetNoleggiByIdCliente(IdCliente,chkDaPagare.Checked,chkNoleggiDaTerminare.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void caricaTargheDisponibili()
        {
            ucCmbTarga.ElCmb.DataSource = noleggiC.GetAllAuto();
            ucCmbTarga.ElCmb.DisplayMember = "Targa";
            ucCmbTarga.ElCmb.ValueMember = "Targa";
        }

        private void impostaDataCorrente(object sender)
        {
            UCTxt uCTxt = (UCTxt)sender;
            uCTxt.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnInizioNow_Click(object sender, EventArgs e)
        {
            impostaDataCorrente(ucTxtDataInizio);
        }

        private void btnFineNow_Click(object sender, EventArgs e)
        {
            impostaDataCorrente(ucTxtDataFine);
        }

        private void btnPaga_Click(object sender, EventArgs e)
        {
            try
            {
                noleggiC.Paga(IdNoleggio);
                dgvNoleggiCliente.DataSource = noleggiC.GetNoleggiByIdCliente(IdCliente,chkDaPagare.Checked,chkNoleggiDaTerminare.Checked);
                lblSaldo.Text = Saldo;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void chkDaPagare_CheckedChanged(object sender, EventArgs e)
        {
            dgvNoleggiCliente.DataSource = noleggiC.GetNoleggiByIdCliente(IdCliente,chkDaPagare.Checked,chkNoleggiDaTerminare.Checked);

        }

        private void chkNoleggiDaTerminare_CheckedChanged(object sender, EventArgs e)
        {
            dgvNoleggiCliente.DataSource = noleggiC.GetNoleggiByIdCliente(IdCliente, chkDaPagare.Checked, chkNoleggiDaTerminare.Checked);
        }
    }

}
