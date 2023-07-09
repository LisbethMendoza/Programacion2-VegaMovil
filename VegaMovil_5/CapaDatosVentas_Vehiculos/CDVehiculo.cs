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
    class CDVehiculo
    {
        private int idVehiculo;
        private string marca, modelo, año, color, locacion, estado;
        private decimal precio;

        public CDVehiculo()
        {
        }

        public CDVehiculo(int idVehiculo, string marca, string modelo, string año, decimal precio, string color, string locacion, string estado)
        {
            this.idVehiculo = idVehiculo;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.precio = precio;
            this.color = color;
            this.locacion = locacion;
            this.estado = estado;
        }

        #region Propiedades

        public int IdVehiculo
        {
            get { return idVehiculo; }
            set { idVehiculo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Año
        {
            get { return año; }
            set { año = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Locacion
        {
            get { return locacion; }
            set { locacion = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
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


                micomando.Parameters.AddWithValue("@pmarca", objVehiculo.Marca);
                micomando.Parameters.AddWithValue("@pmodelo", objVehiculo.Modelo);
                micomando.Parameters.AddWithValue("@paño", objVehiculo.Año);
                micomando.Parameters.AddWithValue("@pprecio", objVehiculo.Precio);
                micomando.Parameters.AddWithValue("@pcolor", objVehiculo.Color);
                micomando.Parameters.AddWithValue("@plocacion", objVehiculo.Locacion);
                micomando.Parameters.AddWithValue("@pestado", objVehiculo.Estado);

                SqlParameter paramIdVehiculo = new SqlParameter("@pidvehiculo", SqlDbType.Int);
                paramIdVehiculo.Direction = ParameterDirection.Output;
                micomando.Parameters.Add(paramIdVehiculo);

                micomando.ExecuteNonQuery();

                int nuevoIdVehiculo = Convert.ToInt32(paramIdVehiculo.Value);
                objVehiculo.IdVehiculo = nuevoIdVehiculo;

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

                micomando.Parameters.AddWithValue("@pidvehiculo", objVehiculo.IdVehiculo);
                micomando.Parameters.AddWithValue("@pmarca", objVehiculo.Marca);
                micomando.Parameters.AddWithValue("@pmodelo", objVehiculo.Modelo);
                micomando.Parameters.AddWithValue("@paño", objVehiculo.Año);
                micomando.Parameters.AddWithValue("@pprecio", objVehiculo.Precio);
                micomando.Parameters.AddWithValue("@pcolor", objVehiculo.Color);
                micomando.Parameters.AddWithValue("@plocacion", objVehiculo.Locacion);
                micomando.Parameters.AddWithValue("@pestado", objVehiculo.Estado);

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

        public DataTable ConsultarVehiculo(string miParametro)
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
