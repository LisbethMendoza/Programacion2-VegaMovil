using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocioVenta_Vehiculo; 

namespace Venta_Vehiculos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = usuario.Text; // Here you get the username entered by the user.
            string contrasenia = contraseña.Text; // Here you get the password entered by the user.

            DataTable dtUsuario = CNUsuario.ObtenerUsuario(nombreUsuario, contrasenia);

            if (dtUsuario != null && dtUsuario.Rows.Count > 0)
            {
                // We have retrieved user data based on the provided value. Now, we need to verify the password.

                foreach (DataRow row in dtUsuario.Rows)
                {
                    string usuarioEncontrado = row["nombre_usu"].ToString();
                    string passwordEncontrado = row["contraseña"].ToString();
                    string estado = row["estado"].ToString();
                    string privilegio = row["privilegio"].ToString();

                    if (usuarioEncontrado == nombreUsuario && passwordEncontrado == contrasenia && estado == "activo" && privilegio == "admin")
                    {
                        MessageBox.Show("¡¡¡ Bienvenido !!! ", "Mensaje Vega Movil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        administrador Pagina_Adminitrador = new administrador();
                        Pagina_Adminitrador.Show();
                        
                        this.Hide(); // Opcionalmente, puedes ocultar la ventana actual (Login) después de abrir la página principal.
                        return;

                    }

                    if (usuarioEncontrado == nombreUsuario && passwordEncontrado == contrasenia && estado == "activo" && privilegio == "vendedor")
                    {
                        MessageBox.Show("¡¡¡ Bienvenido !!! ", "Mensaje Vega Movil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        vendedor Pagina_Vendedor = new vendedor();
                        Pagina_Vendedor.Show();

                        this.Hide(); // Opcionalmente, puedes ocultar la ventana actual (Login) después de abrir la página principal.
                        return;

                    }
                }

                MessageBox.Show("Usuario o contraseña incorrectos.", "Mensaje Vega Movil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Usuario no registrado.", "Mensaje Vega Movil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar_Usuarios Usu = new Consultar_Usuarios();
            Usu.Show();
        }
    }
}

