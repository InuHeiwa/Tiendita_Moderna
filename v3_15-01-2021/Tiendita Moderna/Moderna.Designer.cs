
namespace Tiendita_Moderna
{
    partial class Moderna
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
            this.lbl_Tienda = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listProductos = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.listClientes = new System.Windows.Forms.ComboBox();
            this.cbxPedido = new System.Windows.Forms.CheckBox();
            this.cbxEspecial = new System.Windows.Forms.CheckBox();
            this.lbl_id_emp = new System.Windows.Forms.Label();
            this.lbl_nom_emp = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_finanzas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sesion = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Tienda
            // 
            this.lbl_Tienda.AutoSize = true;
            this.lbl_Tienda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tienda.Location = new System.Drawing.Point(22, 43);
            this.lbl_Tienda.Name = "lbl_Tienda";
            this.lbl_Tienda.Size = new System.Drawing.Size(171, 25);
            this.lbl_Tienda.TabIndex = 1;
            this.lbl_Tienda.Text = "Tiendita Moderna";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(592, 53);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(36, 15);
            this.lbl_fecha.TabIndex = 7;
            this.lbl_fecha.Text = "fecha";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(580, 336);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(160, 44);
            this.btn_confirmar.TabIndex = 4;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(302, 284);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.listProductos);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.dtpEntrega);
            this.panel1.Controls.Add(this.listClientes);
            this.panel1.Controls.Add(this.cbxPedido);
            this.panel1.Controls.Add(this.cbxEspecial);
            this.panel1.Controls.Add(this.lbl_id_emp);
            this.panel1.Controls.Add(this.lbl_nom_emp);
            this.panel1.Controls.Add(this.dgvVentas);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.btn_confirmar);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 409);
            this.panel1.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(491, 284);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 37);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // listProductos
            // 
            this.listProductos.FormattingEnabled = true;
            this.listProductos.Location = new System.Drawing.Point(16, 284);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(280, 23);
            this.listProductos.TabIndex = 14;
            this.listProductos.SelectedIndexChanged += new System.EventHandler(this.listProductos_SelectedIndexChanged);
            this.listProductos.Click += new System.EventHandler(this.listProductos_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(580, 288);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 34);
            this.txtTotal.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Enabled = false;
            this.dtpEntrega.Location = new System.Drawing.Point(156, 356);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(221, 23);
            this.dtpEntrega.TabIndex = 11;
            // 
            // listClientes
            // 
            this.listClientes.Enabled = false;
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(156, 332);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(221, 23);
            this.listClientes.TabIndex = 10;
            // 
            // cbxPedido
            // 
            this.cbxPedido.AutoSize = true;
            this.cbxPedido.Location = new System.Drawing.Point(29, 336);
            this.cbxPedido.Name = "cbxPedido";
            this.cbxPedido.Size = new System.Drawing.Size(63, 19);
            this.cbxPedido.TabIndex = 9;
            this.cbxPedido.Text = "Pedido";
            this.cbxPedido.UseVisualStyleBackColor = true;
            this.cbxPedido.CheckedChanged += new System.EventHandler(this.cbxPedido_CheckedChanged);
            this.cbxPedido.CheckStateChanged += new System.EventHandler(this.cbxPedido_CheckStateChanged);
            // 
            // cbxEspecial
            // 
            this.cbxEspecial.AutoSize = true;
            this.cbxEspecial.Location = new System.Drawing.Point(29, 361);
            this.cbxEspecial.Name = "cbxEspecial";
            this.cbxEspecial.Size = new System.Drawing.Size(108, 19);
            this.cbxEspecial.TabIndex = 8;
            this.cbxEspecial.Text = "Pedido especial";
            this.cbxEspecial.UseVisualStyleBackColor = true;
            this.cbxEspecial.CheckedChanged += new System.EventHandler(this.cbxEspecial_CheckedChanged);
            // 
            // lbl_id_emp
            // 
            this.lbl_id_emp.AutoSize = true;
            this.lbl_id_emp.Location = new System.Drawing.Point(10, 13);
            this.lbl_id_emp.Name = "lbl_id_emp";
            this.lbl_id_emp.Size = new System.Drawing.Size(17, 15);
            this.lbl_id_emp.TabIndex = 7;
            this.lbl_id_emp.Text = "Id";
            // 
            // lbl_nom_emp
            // 
            this.lbl_nom_emp.AutoSize = true;
            this.lbl_nom_emp.Location = new System.Drawing.Point(10, 34);
            this.lbl_nom_emp.Name = "lbl_nom_emp";
            this.lbl_nom_emp.Size = new System.Drawing.Size(51, 15);
            this.lbl_nom_emp.TabIndex = 5;
            this.lbl_nom_emp.Text = "Nombre";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cProducto,
            this.cIva,
            this.cPrecio});
            this.dgvVentas.Location = new System.Drawing.Point(10, 54);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(730, 224);
            this.dgvVentas.TabIndex = 0;
            // 
            // cId
            // 
            this.cId.HeaderText = "Id producto";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cProducto
            // 
            this.cProducto.HeaderText = "Producto";
            this.cProducto.Name = "cProducto";
            this.cProducto.ReadOnly = true;
            this.cProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cProducto.Width = 300;
            // 
            // cIva
            // 
            this.cIva.HeaderText = "IVA";
            this.cIva.Name = "cIva";
            this.cIva.ReadOnly = true;
            this.cIva.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cIva.Width = 150;
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.ReadOnly = true;
            this.cPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cPrecio.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_empleados,
            this.menu_pedidos,
            this.menu_finanzas,
            this.menu_inventario,
            this.menu_proveedores,
            this.menu_clientes,
            this.menu_sesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu_empleados
            // 
            this.menu_empleados.Name = "menu_empleados";
            this.menu_empleados.Size = new System.Drawing.Size(77, 20);
            this.menu_empleados.Text = "Empleados";
            // 
            // menu_pedidos
            // 
            this.menu_pedidos.Name = "menu_pedidos";
            this.menu_pedidos.Size = new System.Drawing.Size(61, 20);
            this.menu_pedidos.Text = "Pedidos";
            // 
            // menu_finanzas
            // 
            this.menu_finanzas.Name = "menu_finanzas";
            this.menu_finanzas.Size = new System.Drawing.Size(64, 20);
            this.menu_finanzas.Text = "Finanzas";
            // 
            // menu_inventario
            // 
            this.menu_inventario.Name = "menu_inventario";
            this.menu_inventario.Size = new System.Drawing.Size(72, 20);
            this.menu_inventario.Text = "Inventario";
            // 
            // menu_proveedores
            // 
            this.menu_proveedores.Name = "menu_proveedores";
            this.menu_proveedores.Size = new System.Drawing.Size(84, 20);
            this.menu_proveedores.Text = "Proveedores";
            // 
            // menu_clientes
            // 
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(61, 20);
            this.menu_clientes.Text = "Clientes";
            // 
            // menu_sesion
            // 
            this.menu_sesion.Name = "menu_sesion";
            this.menu_sesion.Size = new System.Drawing.Size(88, 20);
            this.menu_sesion.Text = "Cerrar Sesion";
            // 
            // Moderna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 502);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_Tienda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Moderna";
            this.Text = "Moderna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Tienda;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_empleados;
        private System.Windows.Forms.Label lbl_nom_emp;
        private System.Windows.Forms.ToolStripMenuItem menu_pedidos;
        private System.Windows.Forms.ToolStripMenuItem menu_finanzas;
        private System.Windows.Forms.ToolStripMenuItem menu_inventario;
        private System.Windows.Forms.ToolStripMenuItem menu_proveedores;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem menu_sesion;
        private System.Windows.Forms.Label lbl_id_emp;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.ComboBox listClientes;
        private System.Windows.Forms.CheckBox cbxPedido;
        private System.Windows.Forms.CheckBox cbxEspecial;
        private System.Windows.Forms.ComboBox listProductos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.Label lblTotal;
    }
}