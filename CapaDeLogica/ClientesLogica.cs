using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using CapaDeEntidades;

namespace CapaDeLogica
{
    public class ClientesLogica
    {
        public ClientesDatos Cliente = new ClientesDatos();


        #region Entity Framework
        public bool InsertarClienteEF(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            return Cliente.InsertarClienteEF(identificacion, nombres, apellidos, direccion, telefono, fecha);
        }

        public List<Cliente> ListarClientesEF()
        {
            return Cliente.ListarClientesEF();
        }
        #endregion

    }
}
