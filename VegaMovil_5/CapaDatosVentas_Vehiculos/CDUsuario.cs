using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace CapaDatosVentas_Vehiculos
{
    public class CDUsuario {

        private int dIdusuario;
        private string dNombre_usu, dcontrasenia, dprivilegio, destado;

        public CDUsuario()
        {

        }

        public CDUsuario(int pIDusuario, string pNombre_usu, string pcontrasenia, string pprivilegio, string pestado)
        {
            dIdusuario = pIDusuario;
            dNombre_usu = pNombre_usu;
            dcontrasenia = pcontrasenia;
            dprivilegio = pprivilegio;
            destado = pestado;
        }

        #region
        public int IDUsuario
        {
            get { return dIdusuario; }
            set { dIdusuario = value; }
        }

        public string Nombre_usu
        {
            get { return dNombre_usu; }
            set { dNombre_usu = value; }
        }

        public string contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string privilegio
        {
            get { return dprivilegio; }
            set { dprivilegio = value; }
        }

        public string estado
        {
            get { return destado; }
            set { destado = value; }
        }
        #endregion
        

        //Insertar


        public string insert(CDUsuario objusuario)
        {
            string mensaje = "";

            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Conexion.miconexion;
                SqlCommand insert = new SqlCommand("InsertUsuario", sqlCon);
                sqlCon.Open();
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("@pnombre_usu", objusuario.Nombre_usu);
                insert.Parameters.AddWithValue("@pcontraseña", objusuario.contrasenia);
                insert.Parameters.AddWithValue("@pprivilegio", objusuario.privilegio);
                insert.Parameters.AddWithValue("@estado", objusuario.estado);
                mensaje = insert.ExecuteNonQuery() == 1 ? "Insercion de datos completada correctamente!" :
                    "No se pudo insertar correctamente los nuevos datos!";
            } catch (Exception e)
            {
                mensaje = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { 
                    sqlCon.Close(); 
                }
            }

            return mensaje;

        }

        //update

        public string update(CDUsuario objusuario)
        {

            string mensaje = "";
            SqlConnection conec = new SqlConnection();
            try
            {

                conec.ConnectionString = Conexion.miconexion;
                SqlCommand update = new SqlCommand("UpdateUsuario", conec);
                conec.Open();
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("@pidusuario", objusuario.IDUsuario);
                update.Parameters.AddWithValue("@pnombre_usu", objusuario.Nombre_usu);
                update.Parameters.AddWithValue("@pcontraseña", objusuario.contrasenia);
                update.Parameters.AddWithValue("@pprivilegios", objusuario.privilegio);
                update.Parameters.AddWithValue("@pestado", objusuario.estado);

                mensaje = update.ExecuteNonQuery() == 1 ? "Actualizacion Realizada" : "Actualizacion fallida";
            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            finally
            {
                if (conec.State == ConnectionState.Open)
                {
                    conec.Close();
                }
            }
            return mensaje;
        }


        //consultation
        public static DataTable ConsultationUsuario(string nombreUsuario, string contrasenia)
        {
            DataTable tabla = new DataTable();
            SqlDataReader Lector;
            try
            {
                SqlCommand consultation = new SqlCommand();
                consultation.Connection = new Conexion().dbconexion;
                consultation.Connection.Open();
                consultation.CommandText = "ConsultationUsuario"; // The name of your stored procedure
                consultation.CommandType = CommandType.StoredProcedure;

                consultation.Parameters.AddWithValue("@pvalor", nombreUsuario);
                Lector = consultation.ExecuteReader();
                tabla.Load(Lector);
                consultation.Connection.Close();
            }
            catch (Exception e)
            {
                tabla = null;
            }
            return tabla;
        }

    }
}