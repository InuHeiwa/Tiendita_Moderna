
namespace Tiendita_Moderna
{
    partial class Login
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
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.list_nom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(151, 130);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(125, 29);
            this.txt_clave.TabIndex = 2;
            this.txt_clave.UseSystemPasswordChar = true;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_KeyPress);
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_clave.Location = new System.Drawing.Point(159, 112);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(108, 15);
            this.lbl_clave.TabIndex = 3;
            this.lbl_clave.Text = "Clave de Empleado";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_entrar.Location = new System.Drawing.Point(151, 181);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(125, 24);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // list_nom
            // 
            this.list_nom.FormattingEnabled = true;
            this.list_nom.Location = new System.Drawing.Point(153, 46);
            this.list_nom.Name = "list_nom";
            this.list_nom.Size = new System.Drawing.Size(121, 29);
            this.list_nom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Empleado";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_nom);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.txt_clave);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(471, 250);
            this.MinimumSize = new System.Drawing.Size(471, 250);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.ComboBox list_nom;
        private System.Windows.Forms.Label label1;
    }
}