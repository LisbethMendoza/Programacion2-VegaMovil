using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CapaNegocioVenta_Vehiculo
{
    class CNUsuario
    {
        public static string Insert (int pIDusuario, string pNombre_usu, string pcontrasenia, string pprivilegio, string pestado)
        {
            objIdusuario = pIDusuario;
            objNombre_usu = pNombre_usu;
            objcontrasenia = pcontrasenia;
            objprivilegio = pprivilegio;
            objestado = pestado;
        
            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objUsuario.Insertar(objUsuario);
        } //Fin del método Insertar


        public static string update(int pIDusuario, string pNombre_usu, string pcontrasenia, string pprivilegio, string pestado)
        {
            objIdusuario = pIDusuario;
            objNombre_usu = pNombre_usu;
            objcontrasenia = pcontrasenia;
            objprivilegio = pprivilegio;
            objestado = pestado;

            //Llamamos al método insertar del suplidor pasándole el objeto creado
            //y retornando el mensaje que indica si se pudo o no realizar la acción
            return objUsuario.update(objUsuario);
        } //Fin del método update




        //Método utilizado para obtener un DataTable con todos los datos de la tabla
        //correspondiente
        public DataTable ObtenerUsuario(string miparametro)
        {
            CDUsuario objSuplidor = new CDUsuario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objSuplidor.UsuarioConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }
    }
}
