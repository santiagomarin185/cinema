using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeLogica
{
    public class ClientesLogica
    {
        public ClientesDatos Cliente = new ClientesDatos();

        #region ADO .NET
        public DataTable ListarClientes()
        {
            return Cliente.ListarClientes();
        }

        public string InsertarCliente(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            return Cliente.InsertarCliente(identificacion, nombres, apellidos, direccion, telefono, fecha);
        }

        public string ActualizarCliente(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            return Cliente.ActualizarCliente(identificacion, nombres, apellidos, direccion, telefono, fecha);
        }

        public string EliminarCliente(string identificacion)
        {
            return Cliente.EliminarCliente(identificacion);
        }
        #endregion

        #region Entity Framework
        public bool InsertarClienteEF(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            return Cliente.InsertarClienteEF(identificacion, nombres, apellidos, direccion, telefono, fecha);
        }
        #endregion
    }
}
