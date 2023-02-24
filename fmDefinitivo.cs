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
    public partial class fmDefinitivo : Form
    {
        bool edicion = false;
        public fmDefinitivo()
        {
            InitializeComponent();
        }

        private void fmDefinitivo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_telefonosDataSet.telefonos' table. You can move, or remove it, as needed.
            this.telefonosTableAdapter.Fill(this.bd_telefonosDataSet.telefonos);

        }

        private void telefonosDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            stEstado.Items[0].Text = // Usamos matriz Rows del DataGrid con fila y celda
                    Convert.ToString(dgvTelefonos.Rows[e.RowIndex].Cells[1].Value);
        }

        private void telefonosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "") //Convertimos este campo en obligatorio
            {
                MessageBox.Show("Falta nombre");
                nombreTextBox.Focus();
            }
            else
            {
                try
                {
                    this.Validate(); //si se pone codigo en evento validated se ejecuta
                    this.telefonosBindingSource.EndEdit();//Aplica cambios al origen datos
                    this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet); //Actualiza
                                                                                  // los cambios en el DataSet
                    bindingNavigatorAddNewItem.Enabled = true;
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                edicion = false; //Variable bool definida a nivel global e iniciada a false
                                 // Usaremos para comprobar los cambios pendientes de guardar
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (bd_telefonosDataSet.HasChanges()) //HAy cambios pendiente de guardar
            {
                telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
            }
            //Código usado en el formulario fmComandos. Genera nueva clave id con la
            // última guardada + 1
            DataTable miTabla = bd_telefonosDataSet.telefonos;
            DataRowCollection cfilas = miTabla.Rows;
            DataRow Fila;
            Fila = miTabla.Rows[miTabla.Rows.Count - 1];//rescato id de última fila
            int nuevoid = Convert.ToInt32(Fila[0]);
            nuevoid++;
            try
            {
                idTextBox.Text = Convert.ToString(nuevoid);//Asignamos nuevo a textbox
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
            bindingNavigatorAddNewItem.Enabled = false; //Mientras se añade, si se
                                                        // vuelve a pulsar dará excepción, deshabilitado no se puede
            nombreTextBox.Focus(); //Focus en campo nombre
            edicion = true; //Comproueba que haya cambios pendientes o no para preguntar si los guardamos
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que deseas Borrar? "
                + nombreTextBox.Text, "Borrar Datos", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
                return;
            else
            {
                bindingNavigatorDeleteItem.PerformClick();//click boton borrar de navigator
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            edicion = false;
            telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
        }

        private void textBoxData_Click(object sender, EventArgs e)
        {
            edicion = true;
        }

        private void fmDefinitivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edicion || bd_telefonosDataSet.HasChanges())
            {
                if (MessageBox.Show("¿Desea Grabar los cambios pendientes?", "Guardar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.telefonosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);
                    // telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
                    // También se puede usar
                }
            }
        }
    }
}
