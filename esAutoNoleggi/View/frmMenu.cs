using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esAutoNoleggi.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            frmAuto auto = new frmAuto();
            auto.ShowDialog();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            frmClienti clienti = new frmClienti();
            clienti.ShowDialog();
        }

        private void btnNoleggi_Click(object sender, EventArgs e)
        {
            frmNoleggi noleggi = new frmNoleggi();
            noleggi.ShowDialog();
        }
    }
}
