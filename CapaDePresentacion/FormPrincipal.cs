using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace CapaDePresentacion
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();

            // Ese formulario no va ser el elemento que contiene a otros formulario
            formClientes.TopLevel = false;
            // Le quita los bordes al formulario
            formClientes.FormBorderStyle = FormBorderStyle.None; 
            // Le dice al formulario que ocupe todo el espacio disponible
            formClientes.Dock = DockStyle.Fill;
                                   
            // Agregamos el formulario al panel
            panelDeFormularios.Controls.Add(formClientes);
            // Utilizamos el método 'Show()' para visualizar el formulario
            formClientes.Show();
        }
    }
}
