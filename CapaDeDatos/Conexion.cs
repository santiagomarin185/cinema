using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class Conexion
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaDeConexion"].ConnectionString);
        
        // Esta línea se utiliza cuando no se agrega la referencia 
        // Agregar system.Configuration en la capa de Datos.
        //SqlConnection conexion = new SqlConnection("Server=STEVEN; Database=Veterinaria; Integrated Security=True;");

        public void AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed) conexion.Open();
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open) conexion.Close();
        }

        /// <summary>
        /// Ejecuta un procedimiento almacenado  
        /// </summary>
        /// <param name="nombreDeSP">Nombre procedimiento almacenado</param>
        /// <param name="parametrosDeSP">Arreglo de parametros del tipo SqlParameter</param>
        public void EjecutarStoredProcedureSinRetorno(string nombreDeSP, SqlParameter[] parametrosDeSP)
        {
            var command = new SqlCommand(nombreDeSP, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parametrosDeSP);

            AbrirConexion();
            command.ExecuteReader();
            CerrarConexion();            
        }

        /// <summary>
        /// Ejecuta un procedimiento almacenado  
        /// </summary>
        /// <param name="nombreDeSP">Nombre procedimiento almacenado</param>
        /// <param name="parametrosDeSP">Arreglo de parametros del tipo SqlParameter</param>
        /// <returns>Retorna un string con el mensaje recpetivo de acuerdo al sp ejecutado</returns>
        public string EjecutarStoredProcedure(string nombreDeSP, SqlParameter[] parametrosDeSP)
        {
            var resultado = string.Empty;
            var command = new SqlCommand(nombreDeSP, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parametrosDeSP);

            AbrirConexion();
            var a = command.ExecuteReader();
            while (a.Read())
            {
                resultado = a[0].ToString();
            }
            CerrarConexion();
            return resultado;
        }

        /// <summary>
        /// Ejecutar un procedimiento almacenado que retorna un listado
        /// </summary>
        /// <param name="nombreDeSP">Nombre procedimiento almacenado</param>
        /// <param name="parametrosDeSP">Arreglo de parametros del tipo SqlParameter</param>
        /// <returns>Retorna un listado de elementos de una tabla sql de acuerdo al sp ejecutado</returns>
        public DataTable EjecutarStoredProcedureDeListado(string nombreDeSP, SqlParameter[] parametrosDeSP)
        {
            DataTable resultado = new DataTable();
            var command = new SqlCommand(nombreDeSP, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddRange(parametrosDeSP);
            var dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);
            return resultado;
        }
    }
}
