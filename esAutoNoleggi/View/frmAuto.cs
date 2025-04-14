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
using ES32noleggioAuto.Model;
using ES32noleggioAuto.Controller;


namespace ES32noleggioAuto
{
    public partial class frmAuto : Form
    {
        clsAutoController autoC;
        clsAuto auto = new clsAuto();
        public string Targa
        {
            get
            {
                try
                {
                    auto.Targa = ucTxtTarga.Text;
                    return auto.Targa;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Targa");
                    return string.Empty; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    auto.Targa = value.Trim().ToUpper();
                    ucTxtTarga.Text = auto.Targa;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Targa");
                }
            }
        }

        public int Km
        {
            get
            {
                try
                {
                    auto.Km = (int)ucNudKm.Value;
                    return auto.Km;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Km");
                    return 0; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    auto.Km = value;
                    ucNudKm.Value = auto.Km;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Km");
                }
            }
        }

        public string Colore
        {
            get
            {
                try
                {
                    auto.Colore = ucTxtColore.Text;
                    return auto.Colore;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Colore");
                    return string.Empty; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    auto.Colore = value.Trim();
                    ucTxtColore.Text = auto.Colore;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Colore");
                }
            }
        }

        public bool CambioAutomatico
        {
            get
            {
                try
                {
                    auto.CambioAutomatico = chkCambioAutomatico.Checked;
                    return auto.CambioAutomatico;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in CambioAutomatico");
                    return false; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    auto.CambioAutomatico = value;
                    chkCambioAutomatico.Checked = auto.CambioAutomatico;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in CambioAutomatico");
                }
            }
        }

        public int Modello
        {
            get
            {
                try
                {
                    auto.IdModello = Convert.ToInt32(ucCmbModello.ElCmb.SelectedValue);
                    return auto.IdModello;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Modello");
                    return 0; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    auto.IdModello = value;
                    ucCmbModello.ElCmb.SelectedValue = auto.IdModello;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Modello");
                }
            }
        }

        public int Alimentazione
        {
            get
            {
                try
                {
                    auto.IdAl = Convert.ToInt32(ucCmbAlimentazione.ElCmb.SelectedValue);
                    return auto.IdAl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Alimentazione");
                    return 0; // Return a default value in case of an error
                }
            }
            set
            {
                try
                {
                    auto.IdAl = value;
                    ucCmbAlimentazione.ElCmb.SelectedValue = auto.IdAl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Alimentazione");
                }
            }
        }


        public frmAuto()
        {
            InitializeComponent();
        }
        private void frmAuto_Load(object sender, EventArgs e)
        {
            try
            {
                autoC = new clsAutoController("DB_NoleggioAuto.mdf");
                dgvAuto.DataSource = autoC.GetAllAuto();
                ucCmbModello.ElCmb.DataSource = autoC.GetAllModelli();
                ucCmbModello.ElCmb.DisplayMember = "modello";
                ucCmbModello.ElCmb.ValueMember = "idModello";
                ucCmbAlimentazione.ElCmb.DataSource = autoC.GetAllAlimentazione();
                ucCmbAlimentazione.ElCmb.DisplayMember = "alimentazione";
                ucCmbAlimentazione.ElCmb.ValueMember = "idAl";

                dgvAuto.AutoResizeColumns();
                if (dgvAuto.Rows.Count == 0)
                {
                    MessageBox.Show("AL MOMENTO NON CI SONO AUTO DISPONIBILI");
                }

                dgvAuto.RowStateChanged += dgvAuto_StateChanged;
                dgvAuto.CellStateChanged += dgvAuto_StateChanged;
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
                autoC.InsertAuto(Targa, Km, Colore, CambioAutomatico, CambioAutomatico, Modello, Alimentazione);
                dgvAuto.DataSource = autoC.GetAllAuto();
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
                autoC.DeleteAuto(Targa);
                dgvAuto.DataSource = autoC.GetAllAuto();

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
                autoC.EditAuto(Targa, Km, Colore, CambioAutomatico, CambioAutomatico, Modello, Alimentazione);
                dgvAuto.DataSource = autoC.GetAllAuto();
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
                DataGridViewRow selectedRow = dgvAuto.Rows[index];
                Targa = selectedRow.Cells["TARGA"].Value.ToString();
                Km = Convert.ToInt32(selectedRow.Cells["KM"].Value);
                Colore = selectedRow.Cells["COLORE"].Value.ToString();
                ucCmbModello.ElCmb.SelectedIndex = (ucCmbModello.ElCmb.FindString(selectedRow.Cells["MODELLO"].Value.ToString()));
                auto.IdModello = (int)ucCmbModello.ElCmb.SelectedValue;
                ucCmbAlimentazione.ElCmb.SelectedIndex = (ucCmbAlimentazione.ElCmb.FindString(selectedRow.Cells["ALIMENTAZIONE"].Value.ToString()));
                auto.IdAl = (int)ucCmbAlimentazione.ElCmb.SelectedValue;
                CambioAutomatico = Convert.ToBoolean(selectedRow.Cells["CAMBIOAUTOMATICO"].Value);
            }
        }
    }
}
