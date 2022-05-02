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
    public partial class Proveedores : Form
    {
        private Int16 seleccion;
        private Int16 id;
        private ConexionBD cbd = new ConexionBD();
        DataTable dt, dp;
        Int16 id_producto;
        public Proveedores()
        {
            InitializeComponent();
            Desactivatxt();
            llenarDatos();
            btn_confirmar.Enabled = false;
            
            dgvProductos.DataSource = cbd.Lista_Prod(Convert.ToInt16(dgvProveedores.Rows[0].Cells[0].Value.ToString()));

            
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (datos_vacios() == 0)
            {
                cbd.ManejaProveedoresSP(seleccion, id, txt_proveedor.Text, txt_municipio.Text, txt_calle.Text, txt_cp.Text, txt_num.Text, txt_telefono.Text, txt_rfc.Text, txt_rep.Text);
            }
        
            else
            {
                MessageBox.Show(string.Format("Algunos datos son necesarios"));
                return;
            }
            llenarDatos();
            
            Desactivatxt();
            llenarDatos();
            btn_confirmar.Enabled = false;
            panel1.Enabled = false;
            btn_Modificar.Enabled = true;
            btn_agregar.Enabled = true;
            Borraatxt();
            dgvProveedores.Enabled = true;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Activatxt();
            dgvProveedores.Enabled = false;
            panel1.Enabled = true;
            btn_agregar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_confirmar.Enabled = true;
            seleccion = 2;
            id = System.Convert.ToInt16(dgvProveedores.CurrentRow.Cells[0].Value.ToString());
            txt_proveedor.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
            txt_municipio.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            txt_calle.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
            txt_cp.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
            txt_num.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();
            txt_telefono.Text = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
            txt_rfc.Text = dgvProveedores.CurrentRow.Cells[7].Value.ToString();
            txt_rep.Text = dgvProveedores.CurrentRow.Cells[8].Value.ToString();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Activatxt();
            btn_agregar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_confirmar.Enabled = true;
            seleccion = 1;
            id = 0;
        }
        
        private void Activatxt()
        {
            txt_calle.Enabled = true;
            txt_cp.Enabled = true;
            txt_municipio.Enabled = true;
            txt_num.Enabled = true;
            txt_proveedor.Enabled = true;
            txt_rep.Enabled = true;
            txt_rfc.Enabled = true;
            txt_telefono.Enabled = true;
        }
        private void Desactivatxt()
        {
            txt_calle.Enabled = false;
            txt_cp.Enabled = false;
            txt_municipio.Enabled = false;
            txt_num.Enabled = false;
            txt_proveedor.Enabled = false;
            txt_rep.Enabled = false;
            txt_rfc.Enabled = false;
            txt_telefono.Enabled = false;
        }
        private void Borraatxt()
        {
            txt_calle.Text = "";
            txt_cp.Text = "";
            txt_municipio.Text = "";
            txt_num.Text = "";
            txt_proveedor.Text = "";
            txt_rep.Text = "";
            txt_rfc.Text = "";
            txt_telefono.Text = "";
        }

        private void llenarDatos()
        {
            dt = cbd.Recupera_datos("sp_mostrar_proveedores");
            dgvProveedores.DataSource = dt;
        }
        private void llenarProductosProveedores()
        {
            dp = cbd.mostrarProductosNoProveedor(Convert.ToInt16(dgvProveedores.CurrentRow.Cells[0].Value.ToString()));
            productos.Items.Clear();
            for (int i = 0; i < dp.Rows.Count; i++)
            {
                productos.Items.Add(dp.Rows[i][1].ToString());
            }
        }

        private void btnAsignarProd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dp.Rows.Count; i++)
                {
                    if (productos.Text == dp.Rows[i][1].ToString())
                        id_producto = Convert.ToInt16(dp.Rows[i][0].ToString());
                }
                cbd.asignaProductoProveedor(id_producto, Convert.ToInt16(dgvProveedores.CurrentRow.Cells[0].Value.ToString()));
                productos.Text = "";
                dgvProductos.DataSource = cbd.Lista_Prod(Convert.ToInt16(dgvProveedores.CurrentRow.Cells[0].Value.ToString()));
                llenarProductosProveedores();
            }
            catch (Exception ex)
            {

            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = cbd.Lista_Prod(Convert.ToInt16(dgvProveedores.CurrentRow.Cells[0].Value.ToString()));
            llenarProductosProveedores();
        }
        private int datos_vacios()
        {

            if (txt_calle.Text == "" ||
                txt_cp.Text == "" ||
                txt_municipio.Text == "" ||
                txt_num.Text == "" ||
                txt_proveedor.Text == "" ||
                txt_rep.Text == "" ||
                txt_rfc.Text == "" ||
                txt_telefono.Text == "" )
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
