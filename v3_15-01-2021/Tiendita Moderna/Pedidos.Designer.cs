
namespace Tiendita_Moderna
{
    partial class Pedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.dgvDescripcion = new System.Windows.Forms.DataGridView();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.listEstados = new System.Windows.Forms.ComboBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(23, 57);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(923, 129);
            this.dgvPedidos.TabIndex = 0;
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.AllowUserToAddRows = false;
            this.dgvDescripcion.AllowUserToDeleteRows = false;
            this.dgvDescripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescripcion.Location = new System.Drawing.Point(23, 263);
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.Size = new System.Drawing.Size(436, 272);
            this.dgvDescripcion.TabIndex = 1;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(23, 211);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(139, 23);
            this.btnDetalles.TabIndex = 2;
            this.btnDetalles.Text = "Detalles del pedido";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // listEstados
            // 
            this.listEstados.FormattingEnabled = true;
            this.listEstados.Location = new System.Drawing.Point(674, 387);
            this.listEstados.Name = "listEstados";
            this.listEstados.Size = new System.Drawing.Size(142, 23);
            this.listEstados.TabIndex = 3;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(664, 358);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(164, 23);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar estado del pedido";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 568);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.listEstados);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.dgvDescripcion);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridView dgvDescripcion;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.ComboBox listEstados;
        private System.Windows.Forms.Button btnCambiar;
    }
}