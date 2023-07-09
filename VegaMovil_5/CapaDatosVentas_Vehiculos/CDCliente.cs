using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace CapaDatosVentas_Vehiculos
{
    public class CDCliente
    {
        private int didcliente;
        private string dnombre_cliente, dtipo_documento, ddocumento, ddireccion, dtelefono, dmovil, destado;
        //par estado

        public CDCliente()
        {
        }



        public CDCliente(int pidcliente,string pnombre_cliente ,string ptipo_documento, string pdocumento, string pdireccion, string ptelefono, string pmovil, string pestado)
        {
            this.dnombre_cliente = pnombre_cliente;
            this.didcliente = pidcliente;
            this.dtipo_documento = ptipo_documento;
            this.ddocumento = pdocumento;
            this.ddireccion = pdireccion;
            this.dtelefono = ptelefono;
            this.dmovil = pmovil;
            this.destado = pestado;
        }
        #region
        public int idcliente
        {
            get { return didcliente; }
            set { didcliente = value; }
        }
        public string nombre_cliente
        {
            get { return dnombre_cliente; }
            set { dnombre_cliente = value; }
        }
        public string tipo_documento
        {

            get { return dtipo_documento; }
            set { dtipo_documento = value; }
        }
        public string documento
        {
            get { return ddocumento; }
            set { ddocumento = value; }
        }

        public string direccion
        {
            get { return ddireccion; }
            set { ddireccion = value; }
        }

        public string telefono
           {
            get { return dtelefono; }
            set{ dtelefono = value; }
            
             }
        public string movil
          {
            get { return dmovil; }
            set{ dmovil = value; }

          }
        public string estado
        {
            get { return destado; }
            set{ destado = value; }

        }
        #endregion

        public string Insertar(CDCliente objCliente)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = Conexion.miconexion;
                //Escribo el nombre del procedimiento almacenado que utilizaré, en este caso SuplidorInsertar
                SqlCommand micomando = new SqlCommand("InsertarCliente", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

               
                micomando.Parameters.AddWithValue("@pnombre_cliente", objCliente.nombre_cliente);
                micomando.Parameters.AddWithValue("@ptipo_cliente", objCliente.tipo_documento);
                micomando.Parameters.AddWithValue("@pdocumentoid", objCliente.documento);
                micomando.Parameters.AddWithValue("@pdireccion", objCliente.direccion);
                micomando.Parameters.AddWithValue("@ptelefono", objCliente.direccion);
                micomando.Parameters.AddWithValue("@pmovil", objCliente.movil);
                micomando.Parameters.AddWithValue("@pestado", objCliente.estado);

                /*Ejecuto la instrucción. Si se devuelve el valor 1 significa que todo funcionó correctamente de lo
             * contrario se devuelve el mensaje indicando que fue incorrecto.
            */
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente!" :
                "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex) //Si ocurre algún error se captura y se muestra el mensaje
            {
                mensaje = ex.Message;
            }
            finally //Luego de realizar el proceso de forma correcta o no 
             {
                //Cierro la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            //Devuelvo el mensaje correspondiente de acuerdo a lo que haya resultado del comando
            return mensaje;
        }

        public string Actualizar(CDCliente objCliente)
        {
            string mensaje = "";
            //creamos un nuevo objeto de tipo SqlConnection
            SqlConnection sqlCon = new SqlConnection();
            //trataremos de hacer algunas operaciones con la tabla
            try
            {
                //asignamos a sqlCon la conexión con las base de datos a traves de la clase que creamos
                sqlCon.ConnectionString = Conexion.miconexion;
                //Escribo el nombre del procedimiento almacenado que utilizaré, en este caso SuplidorInsertar
                SqlCommand micomando = new SqlCommand("UpdateCliente", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pidcli", objCliente.idcliente);
                micomando.Parameters.AddWithValue("@pnombre_cliente", objCliente.nombre_cliente);
                micomando.Parameters.AddWithValue("@ptipo_cliente", objCliente.tipo_documento);
                micomando.Parameters.AddWithValue("@pdocumentoid", objCliente.documento);
                micomando.Parameters.AddWithValue("@pdireccion", objCliente.direccion);
                micomando.Parameters.AddWithValue("@ptelefono", objCliente.direccion);
                micomando.Parameters.AddWithValue("@pmovil", objCliente.movil);
                micomando.Parameters.AddWithValue("@pestado", objCliente.estado);

                /*Ejecuto la instrucción. Si se devuelve el valor 1 significa que todo funcionó correctamente de lo
             * contrario se devuelve el mensaje indicando que fue incorrecto.
            */
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Actualizacion de datos completada correctamente!" :
                "No se pudo insertar correctamente los nuevos datos!";
            }
            catch (Exception ex) //Si ocurre algún error se captura y se muestra el mensaje
            {
                mensaje = ex.Message;
            }
            finally //Luego de realizar el proceso de forma correcta o no 
            {
                //Cierro la conexión si está abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            //Devuelvo el mensaje correspondiente de acuerdo a lo que haya resultado del comando
            return mensaje;
        }
        //Método para consultar datos filtrados de la tabla. Se recibe el valor del parámetro
        public DataTable ConsultationCliente(String miparametro)
        {
            DataTable dt = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Conexion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "ConsultationCliente"; //Nombre del Proc. Almacenado a usar
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                sqlCmd.Parameters.AddWithValue("@buscar", miparametro); //Se pasa el valor a buscar
                leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                dt.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception ex)
            {
                dt = null; //Si ocurre algun error se anula el DataTable
            }
            return dt; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método MostrarConFiltro
    }


}
