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
    public partial class fmComandos : Form
    {
        DataRowCollection cfilas;

        public fmComandos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_telefonosDataSet.telefonos' Puede moverla o quitarla según sea necesario.
            this.telefonosTableAdapter.Fill(this.bd_telefonosDataSet.telefonos);

        }

        private void telefonosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telefonosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);

        }

        private void MostrarPosicion()
        {
            int iTotal = telefonosBindingSource.Count; // Total elementos
            int iPos; // Número (1, 2, ...) de elemento
            if (iTotal == 0)
            {
                laPosicion.Text = "0 de 0";
            }
            else
            {
                iPos = telefonosBindingSource.Position + 1;
                // Mostramos información en el label
                laPosicion.Text = iPos.ToString() + " de " + iTotal.ToString();
            }
        }

        private void btPrimero_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveFirst();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MovePrevious();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveNext();
        }

        private void btUltimo_Click(object sender, EventArgs e)
        {
            telefonosBindingSource.MoveLast();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            // DataTable representa a la tabla en memoria y le asignamos la del dataset
            DataTable miTabla = bd_telefonosDataSet.telefonos;
            cfilas = miTabla.Rows; // Definir cfilas como DataRowCollection a nivel
                                   //global que representa una colección de filas para un DataTable
            DataRow Fila; // DataRow Representa una fila de datos en un DataTable
            Fila = miTabla.Rows[miTabla.Rows.Count - 1]; // Recojo datos última fila
            int nuevoid = Convert.ToInt32(Fila[0]); //rescato id de última fila, está en
                                                    // columna 1 con índice 0
            nuevoid++; // El id para la nueva fila es el último guardado + 1
            try
            {
                Fila = miTabla.NewRow(); // Creamos Nueva fila
                Fila[0] = nuevoid; // Asignamos nuevo id en columna 1 índice 0
                cfilas.Add(Fila); // Añadimos nueva fila a la colección
                btUltimo.PerformClick();//evento clic de btUltimo para posicionarnos
                MostrarPosicion();
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            { // Actualizamos TableAdapter
                telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
                MessageBox.Show("Origen de datos actualizado");
            }
            catch (Exception errorEncontrado)
            {
                MessageBox.Show("Ha habido un error: ", errorEncontrado.Message);
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            DataRowView vistaFilaActual; // Indica una vista personalizada de un
                                         // elemento DataRow
            if (MessageBox.Show("¿Desea borrar el registro seleccionado?", "Borrar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vistaFilaActual = (DataRowView)telefonosBindingSource.Current; //fila
                                                                               // seleccionada
                vistaFilaActual.Row.Delete(); // Usamos método para eliminar
                MostrarPosicion(); // Mostramos nueva posición
                telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
            }
        }

        private void dgvTelefonos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            stEstado.Items[0].Text = Convert.ToString(dgvTelefonos.Rows[e.RowIndex].Cells[1].Value);
            MostrarPosicion();
        }

        private void fmComandos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bd_telefonosDataSet.HasChanges())//Es true si DataSet presenta cambios
            { // de filas nuevas, eliminadas o modificadas
                if (MessageBox.Show("¿Guardar cambios pendientes?", "Guardar Cambios",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { //no usar performclick porque se anula el cierre del formulario
                    telefonosTableAdapter.Update(bd_telefonosDataSet.telefonos);
                    MessageBox.Show("Origen de datos actualizado");
                }
            }
        }
    }
}
