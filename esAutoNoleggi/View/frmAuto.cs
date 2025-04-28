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
    
    public partial class frmAuto : frmMaster
    {
        clsAutoController autoC;
        clsAuto auto = new clsAuto();
        public string Targa
        {
            get
            {
                    auto.Targa = ucTxtTarga.Text;
                    return auto.Targa;
            }
            set
            {
                    auto.Targa = value.Trim().ToUpper();
                    ucTxtTarga.Text = auto.Targa;
            }
        }

        public int Km
        {
            get
            {
                    auto.Km = (int)ucNudKm.Value;
                    return auto.Km;
            }
            set
            {
                    auto.Km = value;
                    ucNudKm.Value = auto.Km;
            }
        }

        public string Colore
        {
            get
            {
                    auto.Colore = ucTxtColore.Text;
                    return auto.Colore;
            }
            set
            {
                    auto.Colore = value.Trim();
                    ucTxtColore.Text = auto.Colore;
            }
        }

        public bool CambioAutomatico
        {
            get
            {
                    auto.CambioAutomatico = chkCambioAutomatico.Checked;
                    return auto.CambioAutomatico;
            }
            set
            {
                    auto.CambioAutomatico = value;
                    chkCambioAutomatico.Checked = auto.CambioAutomatico;
            }
        }

        public int Modello
        {
            get
            {
                    auto.IdModello = Convert.ToInt32(ucCmbModello.ElCmb.SelectedValue);
                    return auto.IdModello;
            }
            set
            {
                    auto.IdModello = value;
                    ucCmbModello.ElCmb.SelectedValue = auto.IdModello;
            }
        }

        public int Alimentazione
        {
            get
            {
                    auto.IdAl = Convert.ToInt32(ucCmbAlimentazione.ElCmb.SelectedValue);
                    return auto.IdAl;
            }
            set
            {
                    auto.IdAl = value;
                    ucCmbAlimentazione.ElCmb.SelectedValue = auto.IdAl;
            }
        }
        public float Prezzo
        {
            get
            {
                auto.Prezzo = (float)ucNudPrezzo.Value;
                return auto.Prezzo;
            }
            set
            {
                auto.Prezzo = value;
                ucNudPrezzo.Value = (decimal)auto.Prezzo;
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
                autoC = new clsAutoController(useful.databaseName);
                dgv.DataSource = autoC.GetAllAuto();
                ucCmbModello.ElCmb.DataSource = autoC.GetAllModelli();
                ucCmbModello.ElCmb.DisplayMember = "modello";
                ucCmbModello.ElCmb.ValueMember = "idModello";
                ucCmbAlimentazione.ElCmb.DataSource = autoC.GetAllAlimentazione();
                ucCmbAlimentazione.ElCmb.DisplayMember = "alimentazione";
                ucCmbAlimentazione.ElCmb.ValueMember = "idAl";

                dgv.AutoResizeColumns();
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("AL MOMENTO NON CI SONO AUTO DISPONIBILI");
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
                autoC.InsertAuto(Targa, Km, Colore, CambioAutomatico, true, Modello, Alimentazione,Prezzo);
                dgv.DataSource = autoC.GetAllAuto();
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
                dgv.DataSource = autoC.GetAllAuto();

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
                autoC.EditAuto(Targa, Km, Colore, CambioAutomatico, CambioAutomatico, Modello, Alimentazione,Prezzo);
                dgv.DataSource = autoC.GetAllAuto();
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
                DataGridViewRow selectedRow = dgv.Rows[index];
                Targa = selectedRow.Cells["TARGA"].Value.ToString();
                Km = Convert.ToInt32(selectedRow.Cells["KM"].Value);
                Colore = selectedRow.Cells["COLORE"].Value.ToString();
                ucCmbModello.ElCmb.SelectedIndex = (ucCmbModello.ElCmb.FindString(selectedRow.Cells["MODELLO"].Value.ToString()));
                auto.IdModello = (int)ucCmbModello.ElCmb.SelectedValue;
                ucCmbAlimentazione.ElCmb.SelectedIndex = (ucCmbAlimentazione.ElCmb.FindString(selectedRow.Cells["ALIMENTAZIONE"].Value.ToString()));
                auto.IdAl = (int)ucCmbAlimentazione.ElCmb.SelectedValue;
                CambioAutomatico = Convert.ToBoolean(selectedRow.Cells["CAMBIOAUTOMATICO"].Value);
                Prezzo = (float)Convert.ToDecimal(selectedRow.Cells["PREZZO"].Value);
            }
        }
    }
}
