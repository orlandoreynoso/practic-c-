using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video1one
{
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
        }

        private void btnclic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola c# visual");
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            txtnombre.Show();
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            txtnombre.Hide();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //flatstyle cambio el stilo del boton
            lblmensaje.Text = "Hiciste clic en guardar";
        }

        private void frminicio_Load(object sender, EventArgs e)
        {
            
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            lblmostrar.Text = txtapellido.Text;
        }
    }
}
