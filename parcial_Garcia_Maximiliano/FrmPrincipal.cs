using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_Garcia_Maximiliano
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            frmListar lista = new frmListar();
            lista.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar agregar = new FrmAgregar();
            agregar.ShowDialog();
        }
    }
}
