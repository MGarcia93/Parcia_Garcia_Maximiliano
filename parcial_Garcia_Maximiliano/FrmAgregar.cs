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
    public partial class FrmAgregar : Form
    {
        List<Hechizo> listadoHechizo = new List<Hechizo>();
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            
            Grilla();
            cbxCasa.DataSource= CasaNegocio.lista();
            cbxCasa.ValueMember = "id";
            cbxCasa.DisplayMember = "descripcion";
            inicializar();
        }

        private void Grilla()
        {

            try
            {
                dgvHechizos.DataSource = HechizoNegocio.listar();

                for (int i = 0; i < dgvHechizos.Columns.Count; i++)
                {
                    dgvHechizos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvHechizos.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                if (listadoHechizo.IndexOf((Hechizo)dgvHechizos.CurrentRow.DataBoundItem) == -1)
                {
                    listadoHechizo.Add((Hechizo)dgvHechizos.CurrentRow.DataBoundItem);
                    lblHechizos.Text += ((Hechizo)dgvHechizos.CurrentRow.DataBoundItem).nombre + "    ";
                }
                else
                {
                    MessageBox.Show("ya esta Agregado");
                }

            }
            else
            {
                MessageBox.Show("Seleccion un valor");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && listadoHechizo.Count > 0)
            {
                Mago mago = new Mago();
                mago.nombre = txtNombre.Text.Trim();
                mago.casa.id = ((Casa)cbxCasa.SelectedItem).id;
                int idMago = MagoNegocio.Agregar(mago);

                if (idMago!=0)
                {
                    string error = "";
                    foreach (Hechizo item in listadoHechizo)
                    {
                        if (!MagoNegocio.agregarHechizo(idMago,item.id)){
                            error += item.nombre + " - ";
                        }
                    }
                    if (error != "")
                    {
                        MessageBox.Show("error en el guardado de los siguiente hechizos: " + error);
                    }
                    else
                    {
                        MessageBox.Show("se agrego correctamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los datos");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicializar()
        {
            listadoHechizo = new List<Hechizo>();
            lblHechizos.Text = "Hechizos elegidos: ";
            txtNombre.Text = "";
            cbxCasa.SelectedIndex = 0;

        }
     
    }
}
