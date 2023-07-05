using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDatosVentas_Vehiculos
{
    public class Conexion
    {
        public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programacion2-VegaMovil\VegaMovil_4\CapaDatosVentas_Vehiculos\BDVenta_Vehiculos.mdf;Integrated Security=True";
        public SqlConnection dbconexion = new SqlConnection(miconexion);
    }

}
