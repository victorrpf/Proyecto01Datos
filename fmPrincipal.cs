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
    public partial class fmPrincipal : Form
    {
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void btPorComandos_Click(object sender, EventArgs e)
        {
            this.Hide();

            fmComandos fmCom = new fmComandos();

            fmCom.ShowDialog();

            this.Show();
        }

        private void btAutomatico_Click(object sender, EventArgs e)
        {
            this.Hide();

            fmAutomatico fmAut = new fmAutomatico();

            fmAut.ShowDialog();

            this.Show();
        }

        private void btDefinitivo_Click(object sender, EventArgs e)
        {
            this.Hide();

            fmDefinitivo fmAut = new fmDefinitivo();

            fmAut.ShowDialog();

            this.Show();
        }

        private void btConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();

            fmConsultaFiltra fmConsFil = new fmConsultaFiltra();

            fmConsFil.ShowDialog();

            this.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
