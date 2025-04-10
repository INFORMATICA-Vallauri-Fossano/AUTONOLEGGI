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
        public frmAuto()
        {
            InitializeComponent();
        }
        clsAutoController autoC;
        clsAuto auto=new clsAuto();
        public string Targa {  get=>auto.Targa=txtTarga.Text; set { 
            auto.Targa = value;
            } }
        public string Km
        {
            get => (auto.Km=Convert.ToInt32(txtTarga.Text)).ToString();
            set=>auto.Km = Convert.ToInt32(value);   
        }
        public string Colore { get => auto.Colore=txtColore.Text;set=>auto.Colore = value; }
        public string CambioAutomatico { get => (auto.CambioAutomatico = chkCambioAutomatico.Checked).ToString(); set => Convert.ToBoolean(value); }
        public string Modello { get => (auto.IdModello = Convert.ToInt32(cmbModelli.SelectedValue)).ToString(); set => auto.IdModello = Convert.ToInt32(value); }
        public string Alimentazione { get => (auto.IdAl= Convert.ToInt32(cmbAlimentazione.SelectedValue)).ToString(); set => auto.IdAl= Convert.ToInt32(value); }

        private void frmAuto_Load(object sender, EventArgs e)
        {
            try
            {
                autoC = new clsAutoController("DB_NoleggioAuto.mdf");
                dgvAuto.DataSource = autoC.GetAllAuto();
                cmbModelli.DataSource = autoC.GetAllModelli();
                cmbModelli.DisplayMember = "modello";
                cmbModelli.ValueMember = "idModello";
                cmbAlimentazione.DataSource = autoC.GetAllAlimentazione();
                cmbAlimentazione.DisplayMember = "alimentazione";
                cmbAlimentazione.ValueMember = "idAl";

                dgvAuto.AutoResizeColumns();
                if (dgvAuto.Rows.Count == 0)
                {
                    MessageBox.Show("AL MOMENTO NON CI SONO AUTO DISPONIBILI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE");
            }
        }
    }
}
