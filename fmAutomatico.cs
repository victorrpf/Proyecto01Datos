using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto01Datos
{
    public partial class fmAutomatico : Form
    {
        public fmAutomatico()
        {
            InitializeComponent();
        }

        private void telefonosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telefonosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);

        }

        private void fmAutomatico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_telefonosDataSet.telefonos' table. You can move, or remove it, as needed.
            this.telefonosTableAdapter.Fill(this.bd_telefonosDataSet.telefonos);

        }
    }
}
