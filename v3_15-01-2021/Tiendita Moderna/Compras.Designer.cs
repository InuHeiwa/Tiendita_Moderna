
namespace Tiendita_Moderna
{
    partial class Compras
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.columProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(890, 46);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar compra";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(866, 177);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(141, 23);
            this.btnRealizar.TabIndex = 36;
            this.btnRealizar.Text = "Realizar compra";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(705, 181);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(688, 134);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 15);
            this.lblSubtotal.TabIndex = 33;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(684, 105);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 15);
            this.lblCantidad.TabIndex = 32;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(683, 76);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(59, 15);
            this.lblProducto.TabIndex = 31;
            this.lblProducto.Text = "Producto:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(749, 134);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(120, 23);
            this.txtSubtotal.TabIndex = 30;
            this.txtSubtotal.Text = "0";
            // 
            // numCantidad
            // 
            this.numCantidad.Enabled = false;
            this.numCantidad.Location = new System.Drawing.Point(749, 105);
            this.numCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 23);
            this.numCantidad.TabIndex = 29;
            // 
            // cmbProductos
            // 
            this.cmbProductos.Enabled = false;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(748, 76);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(121, 23);
            this.cmbProductos.TabIndex = 28;
            this.cmbProductos.TextChanged += new System.EventHandler(this.cmbProductos_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(496, -15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Fecha";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(678, 47);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(64, 15);
            this.lblProveedor.TabIndex = 26;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(748, 47);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 23);
            this.cmbProveedor.TabIndex = 25;
            this.cmbProveedor.TextChanged += new System.EventHandler(this.cmbProveedor_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(93, -15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(126, 15);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre del empleado";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(67, -15);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(17, 15);
            this.lblEmpleado.TabIndex = 23;
            this.lblEmpleado.Text = "Id";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(748, 178);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.Text = "0";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(913, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(126, 220);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.Size = new System.Drawing.Size(743, 251);
            this.dgvCompras.TabIndex = 20;
            this.dgvCompras.Text = "dataGridView1";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(866, 19);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(38, 15);
            this.lbl_Fecha.TabIndex = 38;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(669, 19);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(30, 15);
            this.lbl_Id.TabIndex = 39;
            this.lbl_Id.Text = "lblId";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(712, 19);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 40;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // columProveedor
            // 
            this.columProveedor.HeaderText = "Proveedor";
            this.columProveedor.Name = "columProveedor";
            this.columProveedor.ReadOnly = true;
            this.columProveedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnEmpleado
            // 
            this.columnEmpleado.HeaderText = "Empleado";
            this.columnEmpleado.Name = "columnEmpleado";
            this.columnEmpleado.ReadOnly = true;
            this.columnEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnFecha
            // 
            this.columnFecha.HeaderText = "Fecha";
            this.columnFecha.Name = "columnFecha";
            this.columnFecha.ReadOnly = true;
            this.columnFecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnProducto
            // 
            this.columnProducto.HeaderText = "Producto";
            this.columnProducto.Name = "columnProducto";
            this.columnProducto.ReadOnly = true;
            this.columnProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnCantidad
            // 
            this.columnCantidad.HeaderText = "Cantidad";
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.ReadOnly = true;
            this.columnCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnSubtotal
            // 
            this.columnSubtotal.HeaderText = "Subtotal";
            this.columnSubtotal.Name = "columnSubtotal";
            this.columnSubtotal.ReadOnly = true;
            this.columnSubtotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columProveedor,
            this.columnEmpleado,
            this.columnFecha,
            this.columnProducto,
            this.columnCantidad,
            this.columnSubtotal});
            this.dgvHistorial.Location = new System.Drawing.Point(12, 19);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(643, 182);
            this.dgvHistorial.TabIndex = 35;
            this.dgvHistorial.Text = "dataGridView2";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 483);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCompras);
            this.Name = "Compras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSubtotal;
    }
}