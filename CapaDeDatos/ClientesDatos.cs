using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;

namespace CapaDeDatos
{
    public class ClientesDatos
    {
        public int ClienteId { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        #region Entity Framework
        public Cliente ClienteDeEntidad = new Cliente();

        public bool InsertarClienteEF(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            return ClienteDeEntidad.InsertarClienteEF(identificacion, nombres, apellidos, direccion, telefono, fecha);
        }
        #endregion

        public List<Cliente> ListarClientesEF()
        {
            return ClienteDeEntidad.ListarClientesEF();
        }
    }
}
