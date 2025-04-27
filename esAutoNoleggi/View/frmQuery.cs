using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using esAutoNoleggi.Controller;

namespace esAutoNoleggi.View
{
    public partial class frmQuery : Form
    {
        clsNoleggiController noleggiC;
        public frmQuery()
        {
            InitializeComponent();
            noleggiC=new clsNoleggiController("noleggi.mdf");
        }

        private void btnElencoAutoNoleggio_Click(object sender, EventArgs e)
        {
            dgv.DataSource = noleggiC.GetQuery("SELECT * FROM NOLEGGI WHERE DATAFINE is NULL",null);
        }

        private void btnElencoAutoMaiNoleggiate_Click(object sender, EventArgs e)
        {
            dgv.DataSource = noleggiC.GetQuery("SELECT * FROM AUTOMOBILI WHERE TARGA NOT IN (SELECT TARGA FROM NOLEGGI)", null);
        }

        private void btnNoleggiInRangeDate_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> args= new Dictionary<string,string>();
            args.Add("@DATAINIZIO", dtpInizio.Value.ToString("yyyy-MM-dd"));
            args.Add("@DATAFINE", dtpFine.Value.ToString("yyyy-MM-dd"));
            dgv.DataSource = noleggiC.GetQuery("SELECT * FROM NOLEGGI WHERE DATAINIZIO BETWEEN @DATAINIZIO AND @DATAFINE",args);
        }

        private void btnNoleggioTerminatoNonPagato_Click(object sender, EventArgs e)
        {
            dgv.DataSource = noleggiC.GetQuery("SELECT * FROM NOLEGGI WHERE PAGATO=0 AND DATAFINE IS NOT NULL", null);
        }
    }
}
