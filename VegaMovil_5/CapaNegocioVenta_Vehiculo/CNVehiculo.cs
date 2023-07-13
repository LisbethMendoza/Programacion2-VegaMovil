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
    class CNVehiculo
    {
        public static string Insertar(int pidVehiculo, string pmarca, string pmodelo, string paño, decimal pprecio, string pcolor, string plocacion, string pestado)
        {
            CDVehiculo objVehiculo = new CDVehiculo();
            objVehiculo.Idvehiculo = pidVehiculo;
            objVehiculo.marca = pmarca;
            objVehiculo.modelo = pmodelo;
            objVehiculo.año = paño;
            objVehiculo.precio = pprecio;
            objVehiculo.color = pcolor;
            objVehiculo.locacion = plocacion;
            objVehiculo.estado= pestado;
            return objVehiculo.Insertar(objVehiculo);
        }

        public static string Actualizar(int pidVehiculo, string pmarca, string pmodelo, string paño, decimal pprecio, string pcolor, string plocacion, string pestado)
        {
            CDVehiculo objVehiculo = new CDVehiculo();
            objVehiculo.Idvehiculo = pidVehiculo;
            objVehiculo.marca = pmarca;
            objVehiculo.modelo = pmodelo;
            objVehiculo.año = paño;
            objVehiculo.precio = pprecio;
            objVehiculo.color = pcolor;
            objVehiculo.locacion = plocacion;
            objVehiculo.estado = pestado;

            return objVehiculo.Actualizar(objVehiculo);
        }

        public  DataTable ObtenerVehiculo(string miparametro)
        {
            CDVehiculo objVehiculo = new CDVehiculo();
            DataTable dt = new DataTable();

            dt = objVehiculo.ConsultationVehiculo(miparametro);
            return dt;
        }
    }
}

