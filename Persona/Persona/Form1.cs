using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (txtCiCliente.Text != "" && txtNombreCliente.Text != "" && txtApellidoCliente.Text != "" && txtNitCliente.Text != "" && txtProcedenciaCliente.Text != "")
            {
                cliente.MostrarCliente(txtCiCliente.Text,
                                       txtNombreCliente.Text,
                                       txtApellidoCliente.Text,
                                       txtNitCliente.Text,
                                       txtProcedenciaCliente.Text);
                MessageBox.Show("Bien", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Faltan Datos", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarEncargado_Click(object sender, EventArgs e)
        {
            EncargadoDeAlmacen cliente = new EncargadoDeAlmacen();
            if (txtCiEncargado.Text != "" && txtNombreEncargado.Text != "" && txtApellidoEncargado.Text != "" && txtCodEncarado.Text != "" && txtDireccionEncargado.Text != "")
            {
                cliente.MostrarEncargado(txtCiEncargado.Text,
                                         txtNombreEncargado.Text,
                                         txtApellidoEncargado.Text,
                                         txtCodEncarado.Text,
                                         txtDireccionEncargado.Text);
                MessageBox.Show("Bien", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Faltan Datos", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
