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
    public class CNSolicitud_Detalle
    {

        public static string insertar(int pidsolicituddetalle, int pidsolicitud, int pidcliente, int pidusuario, int pidvehiculo, int pcantidad, string pchasis, string pdetalles)
        {
            CDSolicitud_Detalle objSD = new CDSolicitud_Detalle();
            objSD.idsolicituddetalle = pidsolicituddetalle;
            objSD.idsolicitud = pidsolicitud;
            objSD.idcliente = pidcliente;
            objSD.idusuario = pidusuario;
            objSD.idvehiculo = pidvehiculo;
            objSD.chasis = pchasis;
            objSD.cantidad = pcantidad;
            objSD.detalles = pdetalles;

            return objSD.insert(objSD);

        }

        public static string actualizar(int pidsolicituddetalle, int pidsolicitud, int pidcliente, int pidusuario, int pidvehiculo, int pcantidad, string pchasis, string pdetalles)
        {
            CDSolicitud_Detalle objSD = new CDSolicitud_Detalle();
            objSD.idsolicituddetalle = pidsolicituddetalle;
            objSD.idsolicitud = pidsolicitud;
            objSD.idcliente = pidcliente;
            objSD.idusuario = pidusuario;
            objSD.idvehiculo = pidvehiculo;
            objSD.chasis = pchasis;
            objSD.cantidad = pcantidad;
            objSD.detalles = pdetalles;

            return objSD.update(objSD);

        }

        public DataTable ObtenerSolicitud_Detalle(string datos)
        {
            CDSolicitud_Detalle objCDSD = new CDSolicitud_Detalle();
            DataTable dt = new DataTable();

            dt = objCDSD.ConsultationSolicitud_Detalle(datos);

            return dt;

        }


    }
}