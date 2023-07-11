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
        public class CDSolicitud_Cabecera
    {
        private int didsolicitud, didusuario, didcliente;
        private string destadosolicitud, dfechasolicitud, dtiposolicitud, dmetodopago;

        public CDSolicitud_Cabecera()
        {

        }

        public CDSolicitud_Cabecera(int idSolicitud, int idUsuario, int idCliente, string estadoSolicitud, string fechaSolicitud, string tipoSolicitud, string metodoPago)
        {
            this.didsolicitud = idSolicitud;
            this.didusuario = idUsuario;
            this.didcliente = idCliente;
            this.destadosolicitud = estadoSolicitud;
            this.dfechasolicitud = fechaSolicitud;
            this.dtiposolicitud = tipoSolicitud;
            this.dmetodopago = metodoPago;
        }

        #region Propiedades

        public int idsolicitud
        {
            get { return didsolicitud; }
            set { didsolicitud = value; }
        }

        public int idusuario
        {
            get { return didusuario; }
            set { didusuario = value; }
        }

        public int idcliente
        {
            get { return didcliente; }
            set { didcliente = value; }
        }

        public string estadosolicitud
        {
            get { return destadosolicitud; }
            set { destadosolicitud = value; }
        }

        public string fechasolicitud
        {
            get { return dfechasolicitud; }
            set { dfechasolicitud = value; }
        }

        public string tiposolicitud
        {
            get { return dtiposolicitud; }
            set { dtiposolicitud = value; }
        }

        public string metodopago
        {
            get { return dmetodopago; }
            set { dmetodopago = value; }
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

                insert.Parameters.AddWithValue("@pidusuario", objCDC.idusuario);
                insert.Parameters.AddWithValue("@pidcliente", objCDC.idcliente);
                insert.Parameters.AddWithValue("@pestado_solicitud", objCDC.estadosolicitud);
                insert.Parameters.AddWithValue("@pfecha_solicitud", objCDC.fechasolicitud);
                insert.Parameters.AddWithValue("@ptipo_solicitud", objCDC.tiposolicitud);
                insert.Parameters.AddWithValue("@pmetodo_de_pago", objCDC.metodopago);

                SqlParameter paramIdSolicitud = new SqlParameter("@pidsolicitud", SqlDbType.Int);
                paramIdSolicitud.Direction = ParameterDirection.Output;
                insert.Parameters.Add(paramIdSolicitud);

                conec.Open();
                insert.ExecuteNonQuery();

                int nuevaIdSolicitud = Convert.ToInt32(paramIdSolicitud.Value);
                objCDC.idsolicitud = nuevaIdSolicitud;

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

                update.Parameters.AddWithValue("@pidsolicitud", objCDC.idsolicitud);
                update.Parameters.AddWithValue("@pidusuario", objCDC.idusuario);
                update.Parameters.AddWithValue("@pidcliente", objCDC.idcliente);
                update.Parameters.AddWithValue("@pestado_solicitud", objCDC.estadosolicitud);
                update.Parameters.AddWithValue("@pfecha_solicitud", objCDC.fechasolicitud);
                update.Parameters.AddWithValue("@ptipo_solicitud", objCDC.tiposolicitud);
                update.Parameters.AddWithValue("@pmetodo_de_pago", objCDC.metodopago);

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
