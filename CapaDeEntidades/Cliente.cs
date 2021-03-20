//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDeEntidades
{

    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Data;
    public partial class Cliente
    {
        public int ClienteId { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public System.DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Inserta un cliente en la tabla 'Cliente' con el método 'Add' de Entity Framework
        /// </summary>
        /// <param name="identificacion"></param>
        /// <param name="nombres"></param>
        /// <param name="apellidos"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public bool InsertarClienteEF(string identificacion, string nombres, string apellidos, string direccion, string telefono, DateTime fecha)
        {
            // Creamos un objeto de la clase de contexto llamada 'VeterinariaEntities'
            // Representa la conexión con la base de datos
            var baseDeDatos = new Cine3DEntities1();

            var nuevoCliente = new Cliente();
            nuevoCliente.Identificacion = identificacion;
            nuevoCliente.Nombre = nombres;
            nuevoCliente.Apellido = apellidos;
            nuevoCliente.Direccion = direccion;
            nuevoCliente.Telefono = telefono;
            nuevoCliente.FechaNacimiento = fecha;

            baseDeDatos.Cliente.Add(nuevoCliente);
            baseDeDatos.SaveChanges();

            return true;
        }

        public List<Cliente> ListarClientesEF()
        {
            // Creamos un objeto de la clase de contexto llamada 'VeterinariaEntities'
            // Representa la conexión con la base de datos
            var baseDeDatos = new Cine3DEntities1();

            var listadoDeCliente = baseDeDatos.Cliente.ToList(); //SIN RELACION 

            return listadoDeCliente;
        }

    }
}
