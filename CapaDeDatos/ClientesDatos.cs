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

        #region ADO .NET
        public Conexion ConexionConBD = new Conexion();

        public DataTable ListarClientes()
        {
            return ConexionConBD.EjecutarStoredProcedureDeListado("SP_ListarClientes", new SqlParameter[0]);
        }

        public string InsertarCliente(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            var parametros = new[]
            {
                new SqlParameter("@Identificacion", identificacion),
                new SqlParameter("@Nombres", nombres),
                new SqlParameter("@Apellidos", apellidos),
                new SqlParameter("@Direccion", direccion),
                new SqlParameter("@Telefono", telefono),
                new SqlParameter("@FechaDeNacimiento", fecha)  
            };
            return ConexionConBD.EjecutarStoredProcedure("SP_InsertarCliente", parametros);
        }

        public string ActualizarCliente(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            var parametros = new[]
            {
                new SqlParameter("@Identificacion", identificacion),
                new SqlParameter("@Nombres", nombres),
                new SqlParameter("@Apellidos", apellidos),
                new SqlParameter("@Direccion", direccion),
                new SqlParameter("@Telefono", telefono),
                new SqlParameter("@FechaDeNacimiento", fecha)
            };
            return ConexionConBD.EjecutarStoredProcedure("SP_ActualizarCliente", parametros);
        }

        public string EliminarCliente(string identificacion)
        {
            var parametros = new[]
            {
                new SqlParameter("@Identificacion", identificacion)
            };

            return ConexionConBD.EjecutarStoredProcedure("SP_EliminarCliente", parametros);
        }
        #endregion
       
        #region Entity Framework
        public Clientes ClienteDeEntidad = new Clientes();

        public bool InsertarClienteEF(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            return ClienteDeEntidad.InsertarClienteEF(identificacion, nombres, apellidos, direccion, telefono, fecha);
        }
        #endregion
    }
}
