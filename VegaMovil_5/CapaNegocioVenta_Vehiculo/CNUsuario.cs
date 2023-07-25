using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaDatosVentas_Vehiculos;

namespace CapaNegocioVenta_Vehiculo
{
    public class CNUsuario
    {
        public static string Insert(int pIDusuario, string pNombre_usu, string pcontrasenia, string pprivilegio, string pestado)
        {
            CDUsuario objUsuario = new CDUsuario()
            {
                IDUsuario = pIDusuario,
                Nombre_usu = pNombre_usu,
                contrasenia = pcontrasenia,
                privilegio = pprivilegio,
                estado = pestado
            };

            return objUsuario.insert(objUsuario);
        }

        public static string Update(int pIDusuario, string pNombre_usu, string pcontrasenia, string pprivilegio, string pestado)
        {
            CDUsuario objUsuario = new CDUsuario()
            {
                IDUsuario = pIDusuario,
                Nombre_usu = pNombre_usu,
                contrasenia = pcontrasenia,
                privilegio = pprivilegio,
                estado = pestado
            };

            return objUsuario.update(objUsuario);
        }

        public static DataTable ObtenerUsuario(string nombreUsuario, string contrasenia)
        {
            CDUsuario objUsuario = new CDUsuario();
            DataTable dt = new DataTable();
            dt=  CDUsuario.ConsultationUsuario(nombreUsuario, contrasenia);

            return dt;
        }

        public  DataTable ObtenerUsuarioconsulta(int IDUsuario, string NombreUsuario)
        {
            CDUsuario objUsuario = new CDUsuario();
            DataTable dt = new DataTable();
            dt = CDUsuario.ConsultarUsuarios(IDUsuario, NombreUsuario);

            return dt;
        }
    }
}

