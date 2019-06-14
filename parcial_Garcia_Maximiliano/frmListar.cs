using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace parcial_Garcia_Maximiliano
{
    public partial class frmListar : Form
    {
        List<Mago> listado;
        public frmListar()
        {
            InitializeComponent();
            
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {
            Grilla();
        }
        private void Grilla()
        {

            try
            {
                listado = MagoNegocio.lista();
                dgvLista.DataSource = listado;

                for (int i = 0; i < dgvLista.Columns.Count; i++)
                {
                    dgvLista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHechizos_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                FrmHechizos hechizos = new FrmHechizos(((Mago)dgvLista.CurrentRow.DataBoundItem).id);
                hechizos.ShowDialog();
            }
        }
    }
}
