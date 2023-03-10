using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Proyecto01Datos
{
    public partial class fmConsultaFiltra : Form
    {
        public fmConsultaFiltra()
        {
            InitializeComponent();
            telefonosBindingSource.Sort = "nombre ASC";
            cbCiudad.SelectedIndex= 0;
            cbLetra.SelectedIndex= 0;
            cbProvincias.SelectedIndex= 0;
        }

        private void fmConsultaFiltra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_telefonosDataSet.telefonos' table. You can move, or remove it, as needed.
            this.telefonosTableAdapter.Fill(this.bd_telefonosDataSet.telefonos);

        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            string clasifica = "";
            if (rbNombre.Checked)
            {
                clasifica += "nombre "; //Campo de la tabla
            }
            if (rbId.Checked)
            {
                clasifica += "id ";
            }
            if (ckAscendente.Checked)
            {//Propiedad del Binding y forma de clasificación
                telefonosBindingSource.Sort = clasifica + " ASC";
            }
            else
            {
                telefonosBindingSource.Sort = clasifica + " DESC";
            }//telefonosBindingSource.RemoveSort();//Se puede anular no aquí
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != "")
            {
                telefonosBindingSource.Position = telefonosBindingSource.Find("id",
                tbBuscar.Text);
            }
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btBuscar_Click(sender, e);
            }
        }

        private void filtrosCk_CheckedChanged(object sender, EventArgs e)
        {
            if (ckProvincia.Checked)
            {
                habilita(gbProvincias, false);
                telefonosBindingSource.Filter = "provincia ='" + cbProvincias.Text + "'";
            }
            else if(ckLetra.Checked)
            {
                habilita(gbLetras, false);
                telefonosBindingSource.Filter = "nombre like'" + cbLetra.Text + "%'";
            }
            else if(ckCiudad.Checked)
            {
                habilita(gbCiudad, false);
                telefonosBindingSource.Filter = "ciudad ='" + cbCiudad.Text + "'";
            }
            else
            {
                habilita(gbProvincias, true);
                telefonosBindingSource.RemoveFilter();
            }
        }

        private void habilita(GroupBox boxEnabled, bool habilitarGroupBox)

        {
            gbCiudad.Enabled = gbLetras.Enabled = gbProvincias.Enabled = habilitarGroupBox;
            boxEnabled.Enabled = true;
        }
    }
}
