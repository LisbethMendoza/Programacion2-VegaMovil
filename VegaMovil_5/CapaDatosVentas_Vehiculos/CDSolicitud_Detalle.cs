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
    public class CDSolicitud_Detalle
    {

        private int didsolicituddetalle, didsolicitud, didcliente, didusuario, didvehiculo, dcantidad;
        private string dchasis, ddetalles;

        public CDSolicitud_Detalle()
        {

        }

        public CDSolicitud_Detalle(int pidsolicituddetalle, int pidsolicitud, int pidcliente, int pidusuario, int pidvehiculo, int pcantidad, string pchasis, string pdetalles)
        {
            didsolicituddetalle = pidsolicituddetalle;
            didsolicitud = pidsolicitud;
            didcliente = pidcliente;
            didusuario = pidusuario;
            didvehiculo = pidvehiculo;
            dcantidad = pcantidad;
            dchasis = pchasis;
            ddetalles = pdetalles;
        }

        #region
        public int idsolicituddetalle
        {
            get { return didsolicituddetalle; }
            set { idsolicituddetalle = value; }
        }

        public int idsolicitud
        {
            get { return didsolicitud; }
            set { didsolicitud = value; }
        }

        public int idcliente
        {
            get { return didcliente; }
            set { didcliente = value; }
        }

        public int idusuario
        {
            get { return didusuario; }
            set { didusuario = value; }
        }

        public int idvehiculo
        {
            get { return didvehiculo; }
            set { didvehiculo = value; }
        }

        public int cantidad
        {
            get { return dcantidad; }
            set { dcantidad = value; }
        }

        public string chasis
        {
            get { return dchasis; }
            set { dchasis = value; }
        }

        public string detalles
        {
            get { return ddetalles; }
            set { ddetalles = value; }
        }
        #endregion


        //insert

        public string insert(CDSolicitud_Detalle objCDSD)
        {
            string mensaje = "";
            SqlConnection conec = new SqlConnection();

            try
            {
                conec.ConnectionString = Conexion.miconexion;
                SqlCommand insert = new SqlCommand("InsertSolicitud_Detalle");
                conec.Open();
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("@pidsolicitud", objCDSD.idsolicitud);
                insert.Parameters.AddWithValue("@pidcliente", objCDSD.idcliente);
                insert.Parameters.AddWithValue("@pidusuario", objCDSD.idusuario);
                insert.Parameters.AddWithValue("@pidvehiculo", objCDSD.idvehiculo);
                insert.Parameters.AddWithValue("@pchasis", objCDSD.chasis);
                insert.Parameters.AddWithValue("@pcantidad", objCDSD.cantidad);
                insert.Parameters.AddWithValue("@pdetalles", objCDSD.detalles);
                mensaje = insert.ExecuteNonQuery() == 1 ? "Detalle diitado correctamente" : "Hubo un fallo al dijitar el detalle";
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

        //update

        public string update(CDSolicitud_Detalle objCDSD)
        {
            string mensaje = "";
            SqlConnection conec = new SqlConnection();

            try
            {
                conec.ConnectionString = Conexion.miconexion;
                SqlCommand update = new SqlCommand("InsertSolicitud_Detalle");
                conec.Open();
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("@pidsolicituddetalle", objCDSD.idsolicituddetalle);
                update.Parameters.AddWithValue("@pidsolicitud", objCDSD.idsolicitud);
                update.Parameters.AddWithValue("@pidcliente", objCDSD.idcliente);
                update.Parameters.AddWithValue("@pidusuario", objCDSD.idusuario);
                update.Parameters.AddWithValue("@pidvehiculo", objCDSD.idvehiculo);
                update.Parameters.AddWithValue("@pchasis", objCDSD.chasis);
                update.Parameters.AddWithValue("@pcantidad", objCDSD.cantidad);
                update.Parameters.AddWithValue("@pdetalles", objCDSD.detalles);
                mensaje = update.ExecuteNonQuery() == 1 ? "Se ha actualizado correctamente" : "Hubo un fallo al dijitar al actualizar";
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

        public static DataTable ConsultationUsuario(string datos)
        {
            DataTable tabla = new DataTable();
            SqlDataReader Lector;
            try
            {
                SqlCommand consultation = new SqlCommand();
                consultation.Connection = new Conexion().dbconexion;
                consultation.Connection.Open();
                consultation.CommandText = "ConsultationUsuario";
                consultation.CommandType = CommandType.StoredProcedure;
                consultation.Parameters.AddWithValue("@pvalor", datos);
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
