using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatosVentas_Vehiculos;

namespace CapaNegocioVenta_Vehiculo
{
    public class CNSolicitud_Cabecera
    {
        public static string insert(int idSolicitud, int idUsuario, int idCliente, string estadoSolicitud, string fechaSolicitud, string tipoSolicitud, string metodoPago)
        {
            CDSolicitud_Cabecera objSC = new CDSolicitud_Cabecera();
            objSC.idsolicitud = idSolicitud;
            objSC.idusuario = idUsuario;
            objSC.idcliente = idCliente;
            objSC.estadosolicitud = estadoSolicitud;
            objSC.fechasolicitud = fechaSolicitud;
            objSC.tiposolicitud = tipoSolicitud;
            objSC.metodopago = metodoPago;

            return objSC.Insertar(objSC);
        }

        public static string update(int idSolicitud, int idUsuario, int idCliente, string estadoSolicitud, string fechaSolicitud, string tipoSolicitud, string metodoPago)
        {
            CDSolicitud_Cabecera objSC = new CDSolicitud_Cabecera();
            objSC.idsolicitud = idSolicitud;
            objSC.idusuario = idUsuario;
            objSC.idcliente = idCliente;
            objSC.estadosolicitud = estadoSolicitud;
            objSC.fechasolicitud = fechaSolicitud;
            objSC.tiposolicitud = tipoSolicitud;
            objSC.metodopago = metodoPago;

            return objSC.Actualizar(objSC);
        }


        public DataTable ObtenerSolicitd_Cabecera(string datos)
        {

            CDSolicitud_Cabecera objCDC = new CDSolicitud_Cabecera();
            DataTable dt = new DataTable();


            dt = objCDC.ConsultarSolicitudCabecera(datos);

            return dt;


        }


    }
}