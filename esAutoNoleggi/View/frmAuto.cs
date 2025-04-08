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

        private void frmAuto_Load(object sender, EventArgs e)
        {
            try
            {
                autoC = new clsAutoController("DB_NoleggioAuto.mdf");
                dgvAuto.DataSource = autoC.GetAllAuto();
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
