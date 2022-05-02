
namespace Tiendita_Moderna
{
    partial class Empleados
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
            this.lbl_Tit_form = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_estatus = new System.Windows.Forms.ComboBox();
            this.txt_puesto = new System.Windows.Forms.ComboBox();
            this.txt_sexo = new System.Windows.Forms.ComboBox();
            this.txt_fech_nac = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_municipio = new System.Windows.Forms.TextBox();
            this.txt_tel_emerg = new System.Windows.Forms.TextBox();
            this.txt_ap_paterno = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_num_ext = new System.Windows.Forms.TextBox();
            this.txt_ap_materno = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_num_int = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tit_form
            // 
            this.lbl_Tit_form.AutoSize = true;
            this.lbl_Tit_form.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tit_form.Location = new System.Drawing.Point(13, 13);
            this.lbl_Tit_form.Name = "lbl_Tit_form";
            this.lbl_Tit_form.Size = new System.Drawing.Size(231, 30);
            this.lbl_Tit_form.TabIndex = 15;
            this.lbl_Tit_form.Text = "Control De Empleados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_estatus);
            this.panel1.Controls.Add(this.txt_puesto);
            this.panel1.Controls.Add(this.txt_sexo);
            this.panel1.Controls.Add(this.txt_fech_nac);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_municipio);
            this.panel1.Controls.Add(this.txt_tel_emerg);
            this.panel1.Controls.Add(this.txt_ap_paterno);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_num_ext);
            this.panel1.Controls.Add(this.txt_ap_materno);
            this.panel1.Controls.Add(this.txt_calle);
            this.panel1.Controls.Add(this.txt_num_int);
            this.panel1.Controls.Add(this.txt_cp);
            this.panel1.Controls.Add(this.txt_rfc);
            this.panel1.Controls.Add(this.txt_telefono);
            this.panel1.Location = new System.Drawing.Point(168, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 288);
            this.panel1.TabIndex = 16;
            // 
            // txt_estatus
            // 
            this.txt_estatus.DisplayMember = "Activo";
            this.txt_estatus.FormattingEnabled = true;
            this.txt_estatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Desempleado"});
            this.txt_estatus.Location = new System.Drawing.Point(517, 123);
            this.txt_estatus.Name = "txt_estatus";
            this.txt_estatus.Size = new System.Drawing.Size(113, 23);
            this.txt_estatus.TabIndex = 66;
            this.txt_estatus.ValueMember = "1";
            this.txt_estatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_estatus_KeyPress);
            // 
            // txt_puesto
            // 
            this.txt_puesto.FormattingEnabled = true;
            this.txt_puesto.Items.AddRange(new object[] {
            "Gerente",
            "Empleado"});
            this.txt_puesto.Location = new System.Drawing.Point(411, 123);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(101, 23);
            this.txt_puesto.TabIndex = 65;
            this.txt_puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_puesto_KeyPress);
            // 
            // txt_sexo
            // 
            this.txt_sexo.FormattingEnabled = true;
            this.txt_sexo.Items.AddRange(new object[] {
            "H",
            "M",
            "X"});
            this.txt_sexo.Location = new System.Drawing.Point(639, 54);
            this.txt_sexo.MaxLength = 1;
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(100, 23);
            this.txt_sexo.TabIndex = 61;
            this.txt_sexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sexo_KeyPress);
            // 
            // txt_fech_nac
            // 
            this.txt_fech_nac.Location = new System.Drawing.Point(361, 54);
            this.txt_fech_nac.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.txt_fech_nac.Name = "txt_fech_nac";
            this.txt_fech_nac.Size = new System.Drawing.Size(256, 23);
            this.txt_fech_nac.TabIndex = 60;
            this.txt_fech_nac.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 84;
            this.label3.Text = "Clave";
            // 
            // txt_clave
            // 
            this.txt_clave.Enabled = false;
            this.txt_clave.Location = new System.Drawing.Point(639, 123);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(100, 23);
            this.txt_clave.TabIndex = 67;
            this.txt_clave.UseSystemPasswordChar = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(639, 152);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 63);
            this.btnConfirmar.TabIndex = 82;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(517, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 34);
            this.btnAgregar.TabIndex = 81;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(639, 239);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 34);
            this.btnModificar.TabIndex = 80;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(129, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 15);
            this.label20.TabIndex = 75;
            this.label20.Text = "Calle";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(341, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 15);
            this.label19.TabIndex = 74;
            this.label19.Text = "N° Interior";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(142, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 15);
            this.label18.TabIndex = 73;
            this.label18.Text = "Telefono de emergencia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(305, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 15);
            this.label17.TabIndex = 72;
            this.label17.Text = "RFC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(235, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 15);
            this.label16.TabIndex = 71;
            this.label16.Text = "C.P";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 70;
            this.label15.Text = "Telefono";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(411, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 69;
            this.label14.Text = "Puesto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 68;
            this.label13.Text = "Municipio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 67;
            this.label12.Text = "Apellido Paterno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(639, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 66;
            this.label11.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 65;
            this.label10.Text = "Apellido Materno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 64;
            this.label9.Text = "N° Exterior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 63;
            this.label5.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombre(s)";
            // 
            // txt_municipio
            // 
            this.txt_municipio.Enabled = false;
            this.txt_municipio.Location = new System.Drawing.Point(23, 192);
            this.txt_municipio.Name = "txt_municipio";
            this.txt_municipio.Size = new System.Drawing.Size(100, 23);
            this.txt_municipio.TabIndex = 68;
            // 
            // txt_tel_emerg
            // 
            this.txt_tel_emerg.Enabled = false;
            this.txt_tel_emerg.Location = new System.Drawing.Point(147, 123);
            this.txt_tel_emerg.Name = "txt_tel_emerg";
            this.txt_tel_emerg.Size = new System.Drawing.Size(113, 23);
            this.txt_tel_emerg.TabIndex = 63;
            // 
            // txt_ap_paterno
            // 
            this.txt_ap_paterno.Enabled = false;
            this.txt_ap_paterno.Location = new System.Drawing.Point(129, 54);
            this.txt_ap_paterno.Name = "txt_ap_paterno";
            this.txt_ap_paterno.Size = new System.Drawing.Size(100, 23);
            this.txt_ap_paterno.TabIndex = 58;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(23, 54);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 57;
            // 
            // txt_num_ext
            // 
            this.txt_num_ext.Enabled = false;
            this.txt_num_ext.Location = new System.Drawing.Point(449, 192);
            this.txt_num_ext.Name = "txt_num_ext";
            this.txt_num_ext.Size = new System.Drawing.Size(100, 23);
            this.txt_num_ext.TabIndex = 72;
            // 
            // txt_ap_materno
            // 
            this.txt_ap_materno.Enabled = false;
            this.txt_ap_materno.Location = new System.Drawing.Point(235, 54);
            this.txt_ap_materno.Name = "txt_ap_materno";
            this.txt_ap_materno.Size = new System.Drawing.Size(100, 23);
            this.txt_ap_materno.TabIndex = 59;
            // 
            // txt_calle
            // 
            this.txt_calle.Enabled = false;
            this.txt_calle.Location = new System.Drawing.Point(129, 192);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(100, 23);
            this.txt_calle.TabIndex = 69;
            // 
            // txt_num_int
            // 
            this.txt_num_int.Enabled = false;
            this.txt_num_int.Location = new System.Drawing.Point(341, 192);
            this.txt_num_int.Name = "txt_num_int";
            this.txt_num_int.Size = new System.Drawing.Size(100, 23);
            this.txt_num_int.TabIndex = 71;
            // 
            // txt_cp
            // 
            this.txt_cp.Enabled = false;
            this.txt_cp.Location = new System.Drawing.Point(235, 192);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(100, 23);
            this.txt_cp.TabIndex = 70;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Enabled = false;
            this.txt_rfc.Location = new System.Drawing.Point(305, 123);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(100, 23);
            this.txt_rfc.TabIndex = 64;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Enabled = false;
            this.txt_telefono.Location = new System.Drawing.Point(23, 123);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(113, 23);
            this.txt_telefono.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Tit_form);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Tit_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_municipio;
        private System.Windows.Forms.TextBox txt_tel_emerg;
        private System.Windows.Forms.TextBox txt_ap_paterno;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_num_ext;
        private System.Windows.Forms.TextBox txt_ap_materno;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_num_int;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.DateTimePicker txt_fec_nac;
        private System.Windows.Forms.DateTimePicker txt_fech_nac;
        private System.Windows.Forms.ComboBox txt_sexo;
        private System.Windows.Forms.ComboBox txt_estatus;
        private System.Windows.Forms.ComboBox txt_puesto;
    }
}