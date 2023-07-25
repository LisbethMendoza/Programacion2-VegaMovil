
namespace Venta_Vehiculos
{
    partial class Consultar_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BSalir = new System.Windows.Forms.Button();
            this.BUltimo = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BPrimero = new System.Windows.Forms.Button();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.RadioPrivilegio = new System.Windows.Forms.RadioButton();
            this.RadioEstado = new System.Windows.Forms.RadioButton();
            this.Radioidnombre = new System.Windows.Forms.RadioButton();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.BConsultar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PInformacion = new System.Windows.Forms.Panel();
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDVenta_VehiculosDataSet1 = new Venta_Vehiculos.BDVenta_VehiculosDataSet1();
            this.PBotones = new System.Windows.Forms.Panel();
            this.LCantidadUsuarios = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new Venta_Vehiculos.BDVenta_VehiculosDataSet1TableAdapters.UsuarioTableAdapter();
            this.bdVenta_VehiculosDataSet11 = new Venta_Vehiculos.BDVenta_VehiculosDataSet1();
            this.PTitulo.SuspendLayout();
            this.PInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDVenta_VehiculosDataSet1)).BeginInit();
            this.PBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdVenta_VehiculosDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // BSalir
            // 
            this.BSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BSalir.Location = new System.Drawing.Point(584, 51);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(118, 39);
            this.BSalir.TabIndex = 10;
            this.BSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.BSalir, "Salir del formulario");
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BUltimo
            // 
            this.BUltimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BUltimo.Location = new System.Drawing.Point(460, 51);
            this.BUltimo.Name = "BUltimo";
            this.BUltimo.Size = new System.Drawing.Size(118, 39);
            this.BUltimo.TabIndex = 9;
            this.BUltimo.Text = "Ultimo";
            this.toolTip1.SetToolTip(this.BUltimo, "Ir al ultimo registro");
            this.BUltimo.UseVisualStyleBackColor = true;
            this.BUltimo.Click += new System.EventHandler(this.BUltimo_Click);
            // 
            // BSiguiente
            // 
            this.BSiguiente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSiguiente.Location = new System.Drawing.Point(336, 51);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(118, 39);
            this.BSiguiente.TabIndex = 8;
            this.BSiguiente.Text = "Siguiente";
            this.toolTip1.SetToolTip(this.BSiguiente, "Ir al registro siguiente");
            this.BSiguiente.UseVisualStyleBackColor = true;
            this.BSiguiente.Click += new System.EventHandler(this.BSiguiente_Click);
            // 
            // BAnterior
            // 
            this.BAnterior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BAnterior.Location = new System.Drawing.Point(212, 51);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(118, 39);
            this.BAnterior.TabIndex = 7;
            this.BAnterior.Text = "Anterior";
            this.toolTip1.SetToolTip(this.BAnterior, "Ir al registro anterior");
            this.BAnterior.UseVisualStyleBackColor = true;
            this.BAnterior.Click += new System.EventHandler(this.BAnterior_Click);
            // 
            // BPrimero
            // 
            this.BPrimero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BPrimero.Location = new System.Drawing.Point(88, 51);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(118, 39);
            this.BPrimero.TabIndex = 5;
            this.BPrimero.Text = "Primero";
            this.toolTip1.SetToolTip(this.BPrimero, "Ir al primer registro");
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // PTitulo
            // 
            this.PTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PTitulo.Controls.Add(this.RadioPrivilegio);
            this.PTitulo.Controls.Add(this.RadioEstado);
            this.PTitulo.Controls.Add(this.Radioidnombre);
            this.PTitulo.Controls.Add(this.Combo);
            this.PTitulo.Controls.Add(this.BConsultar);
            this.PTitulo.Controls.Add(this.TBBuscar);
            this.PTitulo.Controls.Add(this.label2);
            this.PTitulo.Controls.Add(this.label1);
            this.PTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTitulo.Location = new System.Drawing.Point(0, 0);
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.Size = new System.Drawing.Size(800, 111);
            this.PTitulo.TabIndex = 0;
            this.PTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PTitulo_Paint);
            // 
            // RadioPrivilegio
            // 
            this.RadioPrivilegio.AutoSize = true;
            this.RadioPrivilegio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.RadioPrivilegio.Location = new System.Drawing.Point(443, 43);
            this.RadioPrivilegio.Name = "RadioPrivilegio";
            this.RadioPrivilegio.Size = new System.Drawing.Size(93, 20);
            this.RadioPrivilegio.TabIndex = 8;
            this.RadioPrivilegio.Text = "Privilegio";
            this.RadioPrivilegio.UseVisualStyleBackColor = true;
            this.RadioPrivilegio.CheckedChanged += new System.EventHandler(this.RadioPrivilegio_CheckedChanged);
            // 
            // RadioEstado
            // 
            this.RadioEstado.AutoSize = true;
            this.RadioEstado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.RadioEstado.Location = new System.Drawing.Point(363, 43);
            this.RadioEstado.Name = "RadioEstado";
            this.RadioEstado.Size = new System.Drawing.Size(74, 20);
            this.RadioEstado.TabIndex = 7;
            this.RadioEstado.Text = "Estado";
            this.RadioEstado.UseVisualStyleBackColor = true;
            this.RadioEstado.CheckedChanged += new System.EventHandler(this.RadioEstado_CheckedChanged);
            // 
            // Radioidnombre
            // 
            this.Radioidnombre.AutoSize = true;
            this.Radioidnombre.Checked = true;
            this.Radioidnombre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Radioidnombre.Location = new System.Drawing.Point(250, 43);
            this.Radioidnombre.Name = "Radioidnombre";
            this.Radioidnombre.Size = new System.Drawing.Size(107, 20);
            this.Radioidnombre.TabIndex = 6;
            this.Radioidnombre.TabStop = true;
            this.Radioidnombre.Text = "ID / Nombre";
            this.Radioidnombre.UseVisualStyleBackColor = true;
            this.Radioidnombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Combo
            // 
            this.Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo.Font = new System.Drawing.Font("Arial", 12F);
            this.Combo.FormattingEnabled = true;
            this.Combo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "",
            "Administrador",
            "Vendedor"});
            this.Combo.Location = new System.Drawing.Point(252, 68);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(280, 26);
            this.Combo.TabIndex = 5;
            this.Combo.Visible = false;
            this.Combo.SelectedIndexChanged += new System.EventHandler(this.Combo_SelectedIndexChanged);
            // 
            // BConsultar
            // 
            this.BConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BConsultar.Location = new System.Drawing.Point(539, 59);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(118, 39);
            this.BConsultar.TabIndex = 4;
            this.BConsultar.Text = "Buscar";
            this.BConsultar.UseVisualStyleBackColor = true;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBuscar.Font = new System.Drawing.Font("Arial", 12F);
            this.TBBuscar.Location = new System.Drawing.Point(252, 68);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(280, 26);
            this.TBBuscar.TabIndex = 3;
            this.TBBuscar.Visible = false;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dijite su busqueda:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(259, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PInformacion
            // 
            this.PInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PInformacion.Controls.Add(this.DGVData);
            this.PInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PInformacion.Location = new System.Drawing.Point(0, 111);
            this.PInformacion.Name = "PInformacion";
            this.PInformacion.Size = new System.Drawing.Size(800, 212);
            this.PInformacion.TabIndex = 1;
            // 
            // DGVData
            // 
            this.DGVData.AllowUserToAddRows = false;
            this.DGVData.AllowUserToDeleteRows = false;
            this.DGVData.AutoGenerateColumns = false;
            this.DGVData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreusuDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.privilegioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.DGVData.DataSource = this.usuarioBindingSource;
            this.DGVData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVData.Location = new System.Drawing.Point(0, 0);
            this.DGVData.Name = "DGVData";
            this.DGVData.ReadOnly = true;
            this.DGVData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVData.Size = new System.Drawing.Size(796, 208);
            this.DGVData.TabIndex = 0;
            this.DGVData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVData_CellContentClick);
            this.DGVData.CurrentCellChanged += new System.EventHandler(this.DGVData_CurrentCellChanged);
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "Idusuario";
            this.idusuarioDataGridViewTextBoxColumn.FillWeight = 38.07107F;
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreusuDataGridViewTextBoxColumn
            // 
            this.nombreusuDataGridViewTextBoxColumn.DataPropertyName = "nombre_usu";
            this.nombreusuDataGridViewTextBoxColumn.FillWeight = 115.4822F;
            this.nombreusuDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.nombreusuDataGridViewTextBoxColumn.Name = "nombreusuDataGridViewTextBoxColumn";
            this.nombreusuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.FillWeight = 115.4822F;
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraseñaDataGridViewTextBoxColumn.Visible = false;
            // 
            // privilegioDataGridViewTextBoxColumn
            // 
            this.privilegioDataGridViewTextBoxColumn.DataPropertyName = "privilegio";
            this.privilegioDataGridViewTextBoxColumn.FillWeight = 115.4822F;
            this.privilegioDataGridViewTextBoxColumn.HeaderText = "Privilegio";
            this.privilegioDataGridViewTextBoxColumn.Name = "privilegioDataGridViewTextBoxColumn";
            this.privilegioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.FillWeight = 115.4822F;
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bDVenta_VehiculosDataSet1;
            // 
            // bDVenta_VehiculosDataSet1
            // 
            this.bDVenta_VehiculosDataSet1.DataSetName = "BDVenta_VehiculosDataSet1";
            this.bDVenta_VehiculosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PBotones
            // 
            this.PBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBotones.Controls.Add(this.BSalir);
            this.PBotones.Controls.Add(this.BUltimo);
            this.PBotones.Controls.Add(this.BSiguiente);
            this.PBotones.Controls.Add(this.BAnterior);
            this.PBotones.Controls.Add(this.BPrimero);
            this.PBotones.Controls.Add(this.LCantidadUsuarios);
            this.PBotones.Controls.Add(this.label3);
            this.PBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBotones.Location = new System.Drawing.Point(0, 343);
            this.PBotones.Name = "PBotones";
            this.PBotones.Size = new System.Drawing.Size(800, 107);
            this.PBotones.TabIndex = 2;
            // 
            // LCantidadUsuarios
            // 
            this.LCantidadUsuarios.AutoSize = true;
            this.LCantidadUsuarios.Font = new System.Drawing.Font("Arial", 13.75F, System.Drawing.FontStyle.Bold);
            this.LCantidadUsuarios.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LCantidadUsuarios.Location = new System.Drawing.Point(223, 11);
            this.LCantidadUsuarios.Name = "LCantidadUsuarios";
            this.LCantidadUsuarios.Size = new System.Drawing.Size(22, 22);
            this.LCantidadUsuarios.TabIndex = 6;
            this.LCantidadUsuarios.Text = "--";
            this.LCantidadUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LCantidadUsuarios.Click += new System.EventHandler(this.LCantidadUsuarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de usuarios:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // bdVenta_VehiculosDataSet11
            // 
            this.bdVenta_VehiculosDataSet11.DataSetName = "BDVenta_VehiculosDataSet1";
            this.bdVenta_VehiculosDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Consultar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PBotones);
            this.Controls.Add(this.PInformacion);
            this.Controls.Add(this.PTitulo);
            this.Name = "Consultar_Usuarios";
            this.Text = "Consultar Usuarios";
            this.Load += new System.EventHandler(this.Consultar_Usuarios_Load);
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.PInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDVenta_VehiculosDataSet1)).EndInit();
            this.PBotones.ResumeLayout(false);
            this.PBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdVenta_VehiculosDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Panel PInformacion;
        private System.Windows.Forms.Panel PBotones;
        private System.Windows.Forms.DataGridView DGVData;
        private BDVenta_VehiculosDataSet1 bDVenta_VehiculosDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private BDVenta_VehiculosDataSet1TableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LCantidadUsuarios;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BUltimo;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private BDVenta_VehiculosDataSet1 bdVenta_VehiculosDataSet11;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.RadioButton RadioPrivilegio;
        private System.Windows.Forms.RadioButton RadioEstado;
        private System.Windows.Forms.RadioButton Radioidnombre;
    }
}