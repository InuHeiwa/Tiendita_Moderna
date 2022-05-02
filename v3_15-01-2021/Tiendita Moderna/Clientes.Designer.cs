
namespace Tiendita_Moderna
{
    partial class Clientes
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
            this.btt_mod = new System.Windows.Forms.Button();
            this.bttn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttn_conf = new System.Windows.Forms.Button();
            this.txt_telf = new System.Windows.Forms.TextBox();
            this.txt_nin = new System.Windows.Forms.TextBox();
            this.txt_next = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lb_con_clien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_mod
            // 
            this.btt_mod.Location = new System.Drawing.Point(778, 410);
            this.btt_mod.Name = "btt_mod";
            this.btt_mod.Size = new System.Drawing.Size(75, 23);
            this.btt_mod.TabIndex = 50;
            this.btt_mod.Text = "Modificar";
            this.btt_mod.UseVisualStyleBackColor = true;
            this.btt_mod.Click += new System.EventHandler(this.btt_mod_Click_1);
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(698, 410);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(75, 23);
            this.bttn_add.TabIndex = 49;
            this.bttn_add.Text = "Agregar";
            this.bttn_add.UseVisualStyleBackColor = true;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(679, 364);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // bttn_conf
            // 
            this.bttn_conf.Location = new System.Drawing.Point(697, 316);
            this.bttn_conf.MaximumSize = new System.Drawing.Size(156, 87);
            this.bttn_conf.MinimumSize = new System.Drawing.Size(156, 87);
            this.bttn_conf.Name = "bttn_conf";
            this.bttn_conf.Size = new System.Drawing.Size(156, 87);
            this.bttn_conf.TabIndex = 47;
            this.bttn_conf.Text = "Confirmar";
            this.bttn_conf.UseVisualStyleBackColor = true;
            this.bttn_conf.Click += new System.EventHandler(this.bttn_conf_Click_1);
            // 
            // txt_telf
            // 
            this.txt_telf.Location = new System.Drawing.Point(699, 287);
            this.txt_telf.Name = "txt_telf";
            this.txt_telf.Size = new System.Drawing.Size(100, 23);
            this.txt_telf.TabIndex = 46;
            // 
            // txt_nin
            // 
            this.txt_nin.Location = new System.Drawing.Point(699, 234);
            this.txt_nin.Name = "txt_nin";
            this.txt_nin.Size = new System.Drawing.Size(100, 23);
            this.txt_nin.TabIndex = 45;
            // 
            // txt_next
            // 
            this.txt_next.Location = new System.Drawing.Point(699, 183);
            this.txt_next.Name = "txt_next";
            this.txt_next.Size = new System.Drawing.Size(100, 23);
            this.txt_next.TabIndex = 44;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(700, 138);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(100, 23);
            this.txt_calle.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Número Interior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Número Exterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Calle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(697, 90);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 23);
            this.txt_nom.TabIndex = 37;
            // 
            // lb_con_clien
            // 
            this.lb_con_clien.AutoSize = true;
            this.lb_con_clien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_con_clien.Location = new System.Drawing.Point(12, 23);
            this.lb_con_clien.Name = "lb_con_clien";
            this.lb_con_clien.Size = new System.Drawing.Size(200, 30);
            this.lb_con_clien.TabIndex = 36;
            this.lb_con_clien.Text = "Control de Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 457);
            this.Controls.Add(this.btt_mod);
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttn_conf);
            this.Controls.Add(this.txt_telf);
            this.Controls.Add(this.txt_nin);
            this.Controls.Add(this.txt_next);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lb_con_clien);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_mod;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttn_conf;
        private System.Windows.Forms.TextBox txt_telf;
        private System.Windows.Forms.TextBox txt_nin;
        private System.Windows.Forms.TextBox txt_next;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lb_con_clien;
    }
}