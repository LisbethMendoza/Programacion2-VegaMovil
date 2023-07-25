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
    public partial class Consultar_Usuarios : Form
    { 

        public int VIdparametro = 0, VTieneparametro = 0, Indice = 1, ID;
        public string Parametro, Mensaje = "";
        CNUsuario objUsuario = new CNUsuario();

        public Consultar_Usuarios()
        {
            InitializeComponent();
        }

        private void Consultar_Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDVenta_VehiculosDataSet1.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.bDVenta_VehiculosDataSet1.Usuario);
            inicio();
        }

        private void DGVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BConsultar_Click(object sender, EventArgs e)
        {

            if (TBBuscar.Text != String.Empty)
            {
                VTieneparametro = 0;
                Parametro = TBBuscar.Text.Trim();
                int.TryParse(Parametro, out ID);
            }
            else
            {
                VTieneparametro = 0;
                Parametro = "";
            }


            if (RadioPrivilegio.Checked == true || RadioEstado.Checked == true)
            {
                Parametro = Combo.Text.Trim();
            }

            MostrarDatos();
            TBBuscar.Focus();
        }

        private void DGVData_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVData.CurrentRow != null)
                Indice = DGVData.CurrentRow.Index;
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVData.RowCount > 1)
            {
                Indice = 0;
                DGVData.CurrentCell = DGVData.Rows[Indice].Cells[DGVData.CurrentCell.ColumnIndex];
            }

        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (Indice > 0)
            {
                Indice--;
                DGVData.CurrentCell = DGVData.Rows[Indice].Cells[DGVData.CurrentCell.ColumnIndex];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (Indice < DGVData.RowCount-1)
            {
                Indice++;
                DGVData.CurrentCell = DGVData.Rows[Indice].Cells[DGVData.CurrentCell.ColumnIndex];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if(Indice < DGVData.RowCount)
            {
                Indice = DGVData.RowCount-1;
                DGVData.CurrentCell = DGVData.Rows[Indice].Cells[DGVData.CurrentCell.ColumnIndex];
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LCantidadUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Radioidnombre.Checked == true)
            {
                Combo.Visible = false;
                TBBuscar.Clear();
                TBBuscar.Visible = true;
                TBBuscar.Focus();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void RadioEstado_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioEstado.Checked == true)
            {
                TBBuscar.Visible = false;
                Combo.Visible = true;
                Combo.Items.Clear();
                Combo.Items.Add("Activo");
                Combo.Items.Add("Inactivo");
            }
        }

        private void RadioPrivilegio_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioPrivilegio.Checked == true)
            {
                TBBuscar.Visible = false;
                Combo.Visible = true;
                Combo.Items.Clear();
                Combo.Items.Add("Admin");
                Combo.Items.Add("Vendedor");
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarDatos()
        {
            if (VTieneparametro == 0)
            {
                DGVData.DataSource = objUsuario.ObtenerUsuarioconsulta(ID, Parametro);
            }
            ContadorDeFilas();
            if (DGVData.RowCount <= 0)
            {
                MessageBox.Show("Ningun dato que mostrar!");
            }

        }
        private void ContadorDeFilas()
        {
            DGVData.Refresh();
            LCantidadUsuarios.Text = Convert.ToString(DGVData.RowCount);
        }
        private void inicio()
        {
            ContadorDeFilas();
            radioButton1_CheckedChanged(null, EventArgs.Empty);
        }

    }
}
