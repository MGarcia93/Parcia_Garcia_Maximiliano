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
    public partial class FrmHechizos : Form
    {
        int mago;
        public FrmHechizos()
        {
            InitializeComponent();
        }
        public FrmHechizos(int mago)
        {
            InitializeComponent();
            this.mago = mago;
        }

        private void FrmHechizos_Load(object sender, EventArgs e)
        {
            Grilla();
        }

        private void Grilla()
        {
            List<Hechizo> listado;
            try
            {
                listado = HechizoNegocio.listar(mago);
                dvgLista.DataSource = listado;

                for (int i = 0; i < dvgLista.Columns.Count; i++)
                {
                    dvgLista.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

    }
}
