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
    public partial class frmMaster : Form
    {
        public frmMaster()
        {
            InitializeComponent();
        }

        protected void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            setDgv(index);
        }
        virtual protected void setDgv(int index) { }
    }
}
