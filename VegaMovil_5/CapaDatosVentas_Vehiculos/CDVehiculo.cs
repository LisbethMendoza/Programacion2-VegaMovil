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
       public class CDVehiculo
    {
        private int didVehiculo;
        private string dmarca, dmodelo, daño, dcolor, dlocacion, destado;
        private decimal dprecio;

        public CDVehiculo()
        {
        }

        public CDVehiculo(int pidVehiculo, string pmarca, string pmodelo, string paño, decimal pprecio, string pcolor, string plocacion, string pestado)
        {
            this.didVehiculo = pidVehiculo;
            this.dmarca = pmarca;
            this.dmodelo = pmodelo;
            this.daño = paño;
            this.dprecio = pprecio;
            this.dcolor = pcolor;
            this.dlocacion = plocacion;
            this.destado = pestado;
        }

        #region Propiedades

        public int Idvehiculo
        {
            get { return didVehiculo; }
            set { didVehiculo = value; }
        }

        public string marca
        {
            get { return dmarca; }
            set { dmarca = value; }
        }

        public string modelo
        {
            get { return dmodelo; }
            set { dmodelo = value; }
        }

        public string año
        {
            get { return daño; }
            set { daño = value; }
        }

        public decimal precio
        {
            get { return dprecio; }
            set { dprecio = value; }
        }

        public string color
        {
            get { return dcolor; }
            set { dcolor = value; }
        }

        public string locacion
        {
            get { return dlocacion; }
            set { dlocacion = value; }
        }

        public string estado
        {
            get { return destado; }
            set { destado = value; }
        }

        #endregion

        public string Insertar(CDVehiculo objVehiculo)
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
                SqlCommand micomando = new SqlCommand("InsertarVehiculo", sqlCon);
                sqlCon.Open(); //Abro la conexión
                               //indico que se ejecutara un procedimiento almacenado
                micomando.CommandType = CommandType.StoredProcedure;


                micomando.Parameters.AddWithValue("@pmarca", objVehiculo.marca);
                micomando.Parameters.AddWithValue("@pmodelo", objVehiculo.modelo);
                micomando.Parameters.AddWithValue("@paño", objVehiculo.año);
                micomando.Parameters.AddWithValue("@pprecio", objVehiculo.precio);
                micomando.Parameters.AddWithValue("@pcolor", objVehiculo.color);
                micomando.Parameters.AddWithValue("@plocacion", objVehiculo.locacion);
                micomando.Parameters.AddWithValue("@pestado", objVehiculo.estado);

                SqlParameter paramIdVehiculo = new SqlParameter("@pidvehiculo", SqlDbType.Int);
                paramIdVehiculo.Direction = ParameterDirection.Output;
                micomando.Parameters.Add(paramIdVehiculo);

                micomando.ExecuteNonQuery();

                int nuevoIdVehiculo = Convert.ToInt32(paramIdVehiculo.Value);
                objVehiculo.Idvehiculo = nuevoIdVehiculo;

                mensaje = "Inserción de datos completada correctamente! Nuevo ID de vehículo: " + nuevoIdVehiculo;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return mensaje;
        }

        public string Actualizar(CDVehiculo objVehiculo)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("UpdateVehiculo", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pidvehiculo", objVehiculo.Idvehiculo);
                micomando.Parameters.AddWithValue("@pmarca", objVehiculo.marca);
                micomando.Parameters.AddWithValue("@pmodelo", objVehiculo.modelo);
                micomando.Parameters.AddWithValue("@paño", objVehiculo.año);
                micomando.Parameters.AddWithValue("@pprecio", objVehiculo.precio);
                micomando.Parameters.AddWithValue("@pcolor", objVehiculo.color);
                micomando.Parameters.AddWithValue("@plocacion", objVehiculo.locacion);
                micomando.Parameters.AddWithValue("@pestado", objVehiculo.estado);

                micomando.ExecuteNonQuery();

                mensaje = "Actualización de datos completada correctamente!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return mensaje;
        }

        public DataTable ConsultationVehiculo(string miParametro)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new Conexion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "ConsultationVehiculo";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@buscar", miParametro);
                leerDatos = sqlCmd.ExecuteReader();
                dt.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception v)
            {
                dt = null;
            }

            return dt;
        }
      }
    }
