using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_Vehiculos
{
    public partial class administrador : Form
    {
        public administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar_Usuarios consultausuarios = new Consultar_Usuarios();
            consultausuarios.Show();
        }
    }
}
