using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeLogica;

namespace CapaDePresentacion
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            ListarClientesEF();
        }

        public ClientesLogica Cliente = new ClientesLogica();


        #region Entity Framework
        public void ListarClientesEF()
        {
            dataGridViewClientes.DataSource = Cliente.ListarClientesEF();
        }

        private void buttonInsertarClienteEF_Click(object sender, EventArgs e)
        {
            var identificacion = textBoxIdentificacion.Text;
            var nombres = textBoxNombre.Text;
            var apellidos = textBoxApellidos.Text;
            var direccion = textBoxDireccion.Text;
            var telefono = textBoxTelefono.Text;
            var fecha = dateTimePickerFecha.Value;

            var clienteInsertado = Cliente.InsertarClienteEF(identificacion, nombres, apellidos, direccion, telefono, fecha);

            // Condición Ternaria
            //var mensaje = clienteInsertado == true ? "Cliente creado correctamente" : "No se pudo crear el cliente";

            var mensaje = string.Empty;

            if (clienteInsertado == true)
            {
                mensaje = "Cliente creado correctamente";
            }
            else
            {
                mensaje = "No se pudo crear el cliente";
            }

            MessageBox.Show(mensaje);
            ListarClientesEF();
        }

        private void buttonActualizarClienteEF_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarClienteEF_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
