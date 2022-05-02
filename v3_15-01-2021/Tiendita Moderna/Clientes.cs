using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tiendita_Moderna.Datos;

namespace Tiendita_Moderna
{
    public partial class Clientes : Form
    {
        private Int16 seleccion;
        private Int16 id; 
        private ConexionBD cbd = new ConexionBD();
        DataTable dt, em;
        public Clientes()
        {
            InitializeComponent();
            llenarDatos();
            Desactivartxt();
            bttn_conf.Enabled = false;
            em = cbd.Recupera_datos("sp_compra_mas");
            try
            {
                MessageBox.Show(string.Format("¡" + em.Rows[0][0].ToString() + " es nuestro mejor cliente!"));
            }
            catch (Exception ex)
            {

            }
        }
        private void bttn_conf_Click_1(object sender, EventArgs e)
        {
            if (datos_vacios() == 0)
            {
                cbd.ManejaclientesSP(seleccion, id, txt_nom.Text, txt_calle.Text, txt_next.Text, txt_nin.Text, txt_telf.Text);
            }
            else
            {
                MessageBox.Show(string.Format("Algunos datos son necesarios"));
                return;
            }
            Borrartxt();
            Desactivartxt();
            bttn_conf.Enabled = false;
            btt_mod.Enabled = true;
            bttn_add.Enabled = true;
            llenarDatos();
        }

        private void bttn_add_Click_1(object sender, EventArgs e)
        {
            Activartxt();
            bttn_conf.Enabled = true;
            btt_mod.Enabled = false;
            bttn_add.Enabled = false;
            seleccion = 1;
            id = 0;
        }

        private void btt_mod_Click_1(object sender, EventArgs e)
        {
            Activartxt();
            bttn_conf.Enabled = true;
            btt_mod.Enabled = false;
            bttn_add.Enabled = false;
            seleccion = 2;
            id = System.Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txt_nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_calle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_next.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_nin.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_telf.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void Activartxt()
        {
            txt_nom.Enabled = true;
            txt_calle.Enabled = true;
            txt_nin.Enabled = true;
            txt_next.Enabled = true;
            txt_telf.Enabled = true;
        }
        private void Desactivartxt()
        {
            txt_nom.Enabled = false;
            txt_calle.Enabled = false;
            txt_nin.Enabled = false;
            txt_next.Enabled = false;
            txt_telf.Enabled = false;
        }
        private void Borrartxt()
        {
            txt_nom.Text = "";
            txt_calle.Text = "";
            txt_nin.Text = "";
            txt_next.Text = "";
            txt_telf.Text = "";
        }
        private void llenarDatos()
        {
            dt = cbd.Recupera_datos("sp_mostrar_datos_cliente");
            dataGridView1.DataSource = dt;
        }
        private int datos_vacios()
        {

            if (txt_nom.Text == "" ||
                txt_calle.Text == "" ||
                txt_next.Text == "" ||
                txt_telf.Text == "")
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
    }
}
