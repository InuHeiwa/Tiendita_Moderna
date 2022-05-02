
namespace Tiendita_Moderna
{
    partial class Finanzas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCorte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.dvgIngresos = new System.Windows.Forms.DataGridView();
            this.txtSaldoCaja = new System.Windows.Forms.TextBox();
            this.lblSaldoCaja = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAplicar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnSiguiente);
            this.groupBox2.Controls.Add(this.btnAnterior);
            this.groupBox2.Controls.Add(this.lblSalario);
            this.groupBox2.Controls.Add(this.lblPuesto);
            this.groupBox2.Controls.Add(this.txtSalario);
            this.groupBox2.Controls.Add(this.txtPuesto);
            this.groupBox2.Location = new System.Drawing.Point(48, 491);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 125);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control de salarios";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(607, 73);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 19;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(526, 73);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(222, 73);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(141, 73);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 15;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(227, 30);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(45, 15);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Salario:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(68, 29);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(46, 15);
            this.lblPuesto.TabIndex = 13;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(278, 30);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 23);
            this.txtSalario.TabIndex = 12;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Location = new System.Drawing.Point(116, 30);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(100, 23);
            this.txtPuesto.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaldoCaja);
            this.groupBox1.Controls.Add(this.txtSaldoCaja);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.Controls.Add(this.btnCorte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblIngresos);
            this.groupBox1.Controls.Add(this.txtEgresos);
            this.groupBox1.Controls.Add(this.txtIngresos);
            this.groupBox1.Controls.Add(this.dgvEgresos);
            this.groupBox1.Controls.Add(this.dvgIngresos);
            this.groupBox1.Location = new System.Drawing.Point(37, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 411);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos/egresos";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(11, 331);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 40);
            this.btnPagar.TabIndex = 24;
            this.btnPagar.Text = "Pagar a empleados";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(467, 340);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 15);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(512, 340);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 23);
            this.txtSaldo.TabIndex = 8;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(629, 331);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 41);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Reporte semanal";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnCorte
            // 
            this.btnCorte.Location = new System.Drawing.Point(316, 331);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(75, 41);
            this.btnCorte.TabIndex = 6;
            this.btnCorte.Text = "Corte ";
            this.btnCorte.UseVisualStyleBackColor = true;
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Egresos:";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(163, 283);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(54, 15);
            this.lblIngresos.TabIndex = 4;
            this.lblIngresos.Text = "Ingresos:";
            // 
            // txtEgresos
            // 
            this.txtEgresos.Enabled = false;
            this.txtEgresos.Location = new System.Drawing.Point(552, 283);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(100, 23);
            this.txtEgresos.TabIndex = 3;
            // 
            // txtIngresos
            // 
            this.txtIngresos.Enabled = false;
            this.txtIngresos.Location = new System.Drawing.Point(223, 283);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(100, 23);
            this.txtIngresos.TabIndex = 2;
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Location = new System.Drawing.Point(363, 32);
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.Size = new System.Drawing.Size(340, 248);
            this.dgvEgresos.TabIndex = 1;
            this.dgvEgresos.Text = "dataGridView2";
            // 
            // dvgIngresos
            // 
            this.dvgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgIngresos.Location = new System.Drawing.Point(6, 29);
            this.dvgIngresos.Name = "dvgIngresos";
            this.dvgIngresos.Size = new System.Drawing.Size(340, 248);
            this.dvgIngresos.TabIndex = 0;
            this.dvgIngresos.Text = "dataGridView1";
            // 
            // txtSaldoCaja
            // 
            this.txtSaldoCaja.Enabled = false;
            this.txtSaldoCaja.Location = new System.Drawing.Point(208, 340);
            this.txtSaldoCaja.Name = "txtSaldoCaja";
            this.txtSaldoCaja.Size = new System.Drawing.Size(100, 23);
            this.txtSaldoCaja.TabIndex = 25;
            // 
            // lblSaldoCaja
            // 
            this.lblSaldoCaja.AutoSize = true;
            this.lblSaldoCaja.Location = new System.Drawing.Point(123, 340);
            this.lblSaldoCaja.Name = "lblSaldoCaja";
            this.lblSaldoCaja.Size = new System.Drawing.Size(79, 15);
            this.lblSaldoCaja.TabIndex = 26;
            this.lblSaldoCaja.Text = "Saldo en caja:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(37, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(70, 15);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "IdEmpleado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(149, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // Finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 634);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Finanzas";
            this.Text = "Finanzas";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.DataGridView dgvEgresos;
        private System.Windows.Forms.DataGridView dvgIngresos;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblSaldoCaja;
        private System.Windows.Forms.TextBox txtSaldoCaja;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
    }
}