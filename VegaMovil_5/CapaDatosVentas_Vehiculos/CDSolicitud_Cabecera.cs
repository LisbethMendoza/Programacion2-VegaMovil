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
    class CDSolicitud_Cabecera
    {
        private int idSolicitud, idUsuario, idCliente;
        private string estadoSolicitud, fechaSolicitud, tipoSolicitud, metodoPago;

        public CDSolicitud_Cabecera()
        {

        }

        public CDSolicitud_Cabecera(int idSolicitud, int idUsuario, int idCliente, string estadoSolicitud, string fechaSolicitud, string tipoSolicitud, string metodoPago)
        {
            this.idSolicitud = idSolicitud;
            this.idUsuario = idUsuario;
            this.idCliente = idCliente;
            this.estadoSolicitud = estadoSolicitud;
            this.fechaSolicitud = fechaSolicitud;
            this.tipoSolicitud = tipoSolicitud;
            this.metodoPago = metodoPago;
        }

        #region Propiedades

        public int IdSolicitud
        {
            get { return idSolicitud; }
            set { idSolicitud = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string EstadoSolicitud
        {
            get { return estadoSolicitud; }
            set { estadoSolicitud = value; }
        }

        public string FechaSolicitud
        {
            get { return fechaSolicitud; }
            set { fechaSolicitud = value; }
        }

        public string TipoSolicitud
        {
            get { return tipoSolicitud; }
            set { tipoSolicitud = value; }
        }

        public string MetodoPago
        {
            get { return metodoPago; }
            set { metodoPago = value; }
        }

        #endregion

        // Insertar

        public string Insertar(CDSolicitud_Cabecera objCDC)
        {
            string mensaje = "";
            SqlConnection conec = new SqlConnection();

            try
            {
                conec.ConnectionString = Conexion.miconexion;
                SqlCommand insert = new SqlCommand("InsertarSolicitud_Cabecera", conec);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("@pidusuario", objCDC.IdUsuario);
                insert.Parameters.AddWithValue("@pidcliente", objCDC.IdCliente);
                insert.Parameters.AddWithValue("@pestado_solicitud", objCDC.EstadoSolicitud);
                insert.Parameters.AddWithValue("@pfecha_solicitud", objCDC.FechaSolicitud);
                insert.Parameters.AddWithValue("@ptipo_solicitud", objCDC.TipoSolicitud);
                insert.Parameters.AddWithValue("@pmetodo_de_pago", objCDC.MetodoPago);

                SqlParameter paramIdSolicitud = new SqlParameter("@pidsolicitud", SqlDbType.Int);
                paramIdSolicitud.Direction = ParameterDirection.Output;
                insert.Parameters.Add(paramIdSolicitud);

                conec.Open();
                insert.ExecuteNonQuery();

                int nuevaIdSolicitud = Convert.ToInt32(paramIdSolicitud.Value);
                objCDC.IdSolicitud = nuevaIdSolicitud;

                mensaje = "Solicitud insertada correctamente. Nuevo ID de solicitud: " + nuevaIdSolicitud;
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

        // Actualizar

        public string Actualizar(CDSolicitud_Cabecera objCDC)
        {
            string mensaje = "";
            SqlConnection conec = new SqlConnection();

            try
            {
                conec.ConnectionString = Conexion.miconexion;
                SqlCommand update = new SqlCommand("UpdateSolicitud_Cabecera", conec);
                update.CommandType = CommandType.StoredProcedure;

                update.Parameters.AddWithValue("@pidsolicitud", objCDC.IdSolicitud);
                update.Parameters.AddWithValue("@pidusuario", objCDC.IdUsuario);
                update.Parameters.AddWithValue("@pidcliente", objCDC.IdCliente);
                update.Parameters.AddWithValue("@pestado_solicitud", objCDC.EstadoSolicitud);
                update.Parameters.AddWithValue("@pfecha_solicitud", objCDC.FechaSolicitud);
                update.Parameters.AddWithValue("@ptipo_solicitud", objCDC.TipoSolicitud);
                update.Parameters.AddWithValue("@pmetodo_de_pago", objCDC.MetodoPago);

                conec.Open();
                update.ExecuteNonQuery();

                mensaje = "Actualización de datos completada correctamente!";
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

        // Consultar

        public static DataTable ConsultarSolicitudCabecera(string datos)
        {
            DataTable tabla = new DataTable();
            SqlDataReader lector;

            try
            {
                SqlCommand consulta = new SqlCommand();
                consulta.Connection = new Conexion().dbconexion;
                consulta.Connection.Open();
                consulta.CommandText = "ConsultationSolicitud_Cabecera";
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.AddWithValue("@pvalor", datos);
                lector = consulta.ExecuteReader();
                tabla.Load(lector);
                consulta.Connection.Close();
            }
            catch (Exception a)
            {
                tabla = null;
            }

            return tabla;
        }

    }
}
