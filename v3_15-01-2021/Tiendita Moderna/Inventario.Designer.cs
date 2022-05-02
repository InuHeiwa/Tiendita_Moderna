
namespace Tiendita_Moderna
{
    partial class Inventario
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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.rbdInventario = new System.Windows.Forms.RadioButton();
            this.rdbModificar = new System.Windows.Forms.RadioButton();
            this.rdbAgrgar = new System.Windows.Forms.RadioButton();
            this.txt_cod_Compra = new System.Windows.Forms.TextBox();
            this.lblCompras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPcompra = new System.Windows.Forms.Label();
            this.lblPventa = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtPcompra = new System.Windows.Forms.TextBox();
            this.txtPventa = new System.Windows.Forms.TextBox();
            this.txtNombre_prod = new System.Windows.Forms.TextBox();
            this.txtCodigo_prod = new System.Windows.Forms.TextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Compras = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_realizar = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(12, 401);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.Size = new System.Drawing.Size(745, 215);
            this.dgvCompras.TabIndex = 48;
            this.dgvCompras.Text = "dataGridView2";
            this.dgvCompras.Click += new System.EventHandler(this.dgvCompras_Click);
            // 
            // rbdInventario
            // 
            this.rbdInventario.AutoSize = true;
            this.rbdInventario.Location = new System.Drawing.Point(173, 62);
            this.rbdInventario.Name = "rbdInventario";
            this.rbdInventario.Size = new System.Drawing.Size(176, 19);
            this.rbdInventario.TabIndex = 47;
            this.rbdInventario.TabStop = true;
            this.rbdInventario.Text = "Agregar compra a inventario";
            this.rbdInventario.UseVisualStyleBackColor = true;
            this.rbdInventario.CheckedChanged += new System.EventHandler(this.rbdInventario_CheckedChanged);
            // 
            // rdbModificar
            // 
            this.rdbModificar.AutoSize = true;
            this.rdbModificar.Location = new System.Drawing.Point(355, 62);
            this.rdbModificar.Name = "rdbModificar";
            this.rdbModificar.Size = new System.Drawing.Size(128, 19);
            this.rdbModificar.TabIndex = 46;
            this.rdbModificar.TabStop = true;
            this.rdbModificar.Text = "Modificar producto";
            this.rdbModificar.UseVisualStyleBackColor = true;
            this.rdbModificar.CheckedChanged += new System.EventHandler(this.rdbModificar_CheckedChanged);
            // 
            // rdbAgrgar
            // 
            this.rdbAgrgar.AutoSize = true;
            this.rdbAgrgar.Location = new System.Drawing.Point(12, 62);
            this.rdbAgrgar.Name = "rdbAgrgar";
            this.rdbAgrgar.Size = new System.Drawing.Size(155, 19);
            this.rdbAgrgar.TabIndex = 44;
            this.rdbAgrgar.TabStop = true;
            this.rdbAgrgar.Text = "Agregar producto nuevo";
            this.rdbAgrgar.UseVisualStyleBackColor = true;
            this.rdbAgrgar.CheckedChanged += new System.EventHandler(this.rdbAgrgar_CheckedChanged);
            // 
            // txt_cod_Compra
            // 
            this.txt_cod_Compra.Location = new System.Drawing.Point(841, 108);
            this.txt_cod_Compra.Name = "txt_cod_Compra";
            this.txt_cod_Compra.Size = new System.Drawing.Size(100, 23);
            this.txt_cod_Compra.TabIndex = 43;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Location = new System.Drawing.Point(716, 108);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(109, 15);
            this.lblCompras.TabIndex = 42;
            this.lblCompras.Text = "Codigo de compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Caducidad";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(726, 367);
            this.txt_fecha.MinDate = new System.DateTime(2021, 1, 14, 0, 0, 0, 0);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(215, 23);
            this.txt_fecha.TabIndex = 39;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(716, 311);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 15);
            this.lblCantidad.TabIndex = 38;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPcompra
            // 
            this.lblPcompra.AutoSize = true;
            this.lblPcompra.Location = new System.Drawing.Point(716, 268);
            this.lblPcompra.Name = "lblPcompra";
            this.lblPcompra.Size = new System.Drawing.Size(103, 15);
            this.lblPcompra.TabIndex = 37;
            this.lblPcompra.Text = "Precio de compra:";
            // 
            // lblPventa
            // 
            this.lblPventa.AutoSize = true;
            this.lblPventa.Location = new System.Drawing.Point(716, 232);
            this.lblPventa.Name = "lblPventa";
            this.lblPventa.Size = new System.Drawing.Size(91, 15);
            this.lblPventa.TabIndex = 36;
            this.lblPventa.Text = "Precio de venta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(716, 191);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(716, 150);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(117, 15);
            this.lblCodigo.TabIndex = 34;
            this.lblCodigo.Text = "Código de producto:";
            // 
            // txtPcompra
            // 
            this.txtPcompra.Location = new System.Drawing.Point(841, 268);
            this.txtPcompra.Name = "txtPcompra";
            this.txtPcompra.Size = new System.Drawing.Size(100, 23);
            this.txtPcompra.TabIndex = 32;
            // 
            // txtPventa
            // 
            this.txtPventa.Location = new System.Drawing.Point(841, 232);
            this.txtPventa.Name = "txtPventa";
            this.txtPventa.Size = new System.Drawing.Size(100, 23);
            this.txtPventa.TabIndex = 31;
            // 
            // txtNombre_prod
            // 
            this.txtNombre_prod.Location = new System.Drawing.Point(841, 191);
            this.txtNombre_prod.Name = "txtNombre_prod";
            this.txtNombre_prod.Size = new System.Drawing.Size(100, 23);
            this.txtNombre_prod.TabIndex = 30;
            // 
            // txtCodigo_prod
            // 
            this.txtCodigo_prod.Location = new System.Drawing.Point(841, 150);
            this.txtCodigo_prod.Name = "txtCodigo_prod";
            this.txtCodigo_prod.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo_prod.TabIndex = 29;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(12, 98);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(646, 292);
            this.dgvInventario.TabIndex = 28;
            this.dgvInventario.Text = "dataGridView1";
            this.dgvInventario.Click += new System.EventHandler(this.dgvInventario_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Compras});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "Compras";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // Compras
            // 
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(67, 20);
            this.Compras.Text = "Compras";
            // 
            // btn_realizar
            // 
            this.btn_realizar.Location = new System.Drawing.Point(813, 468);
            this.btn_realizar.Name = "btn_realizar";
            this.btn_realizar.Size = new System.Drawing.Size(128, 33);
            this.btn_realizar.TabIndex = 49;
            this.btn_realizar.Text = "Realizar operación";
            this.btn_realizar.UseVisualStyleBackColor = true;
            this.btn_realizar.Click += new System.EventHandler(this.btn_realizar_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Enabled = false;
            this.txt_Cantidad.Location = new System.Drawing.Point(841, 303);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 23);
            this.txt_Cantidad.TabIndex = 50;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(59, 33);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(30, 15);
            this.lbl_Id.TabIndex = 51;
            this.lbl_Id.Text = "lblId";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(124, 33);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 52;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 633);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.btn_realizar);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.rbdInventario);
            this.Controls.Add(this.rdbModificar);
            this.Controls.Add(this.rdbAgrgar);
            this.Controls.Add(this.txt_cod_Compra);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPcompra);
            this.Controls.Add(this.lblPventa);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtPcompra);
            this.Controls.Add(this.txtPventa);
            this.Controls.Add(this.txtNombre_prod);
            this.Controls.Add(this.txtCodigo_prod);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.RadioButton rbdInventario;
        private System.Windows.Forms.RadioButton rdbModificar;
        private System.Windows.Forms.RadioButton rdbAgrgar;
        private System.Windows.Forms.TextBox txt_cod_Compra;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPcompra;
        private System.Windows.Forms.Label lblPventa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtPcompra;
        private System.Windows.Forms.TextBox txtPventa;
        private System.Windows.Forms.TextBox txtNombre_prod;
        private System.Windows.Forms.TextBox txtCodigo_prod;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Compras;
        private System.Windows.Forms.Button btn_realizar;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Id;
    }
}