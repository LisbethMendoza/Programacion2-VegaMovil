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
    class CNCliente
    {
        public static string Insertar(int pidcliente, string pnombre_cliente, string ptipo_documento, string pdocumento, string pdireccion, string ptelefono, string pmovil, string pestado)
        {
            CDCliente objCliente = new CDCliente();
            objCliente.idcliente = pidcliente;
            objCliente.nombre_cliente = pnombre_cliente;
            objCliente.tipo_documento = ptipo_documento;
            objCliente.documento = pdocumento;
            objCliente.direccion = pdireccion;
            objCliente.telefono = ptelefono;
            objCliente.movil = pmovil;
            objCliente.estado = pestado;

            return objCliente.Insertar(objCliente);
        }

        public static string Actualizar(int pidcliente, string pnombre_cliente, string ptipo_documento, string pdocumento, string pdireccion, string ptelefono, string pmovil, string pestado)
        {
            CDCliente objCliente = new CDCliente();
            objCliente.idcliente = pidcliente;
            objCliente.nombre_cliente = pnombre_cliente;
            objCliente.tipo_documento = ptipo_documento;
            objCliente.documento = pdocumento;
            objCliente.direccion = pdireccion;
            objCliente.telefono = ptelefono;
            objCliente.movil = pmovil;
            objCliente.estado = pestado;

            return objCliente.Actualizar(objCliente);
        }

        public DataTable ObtenerCliente(string miparametro)
        {
            CDCliente objCliente = new CDCliente();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objCliente.ConsultationCliente(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }


    }
}
