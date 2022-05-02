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
    public partial class Inventario : Form
    {
        private Int16 seleccion;
        private Int16 id;
        private ConexionBD cbd = new ConexionBD();
        DataTable dt;
        String cadena="", cadena2="";
        public Inventario(String id_emp, String nombre)
        {
            InitializeComponent();            
            lbl_Nombre.Text = nombre;
            lbl_Id.Text = id_emp;
            Desactivatxt();
            btn_realizar.Enabled = false;
            llenarDatos();
            mensajes();

            //cantidad de productos < a 10
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Compras") {
                Compras C = new Compras(lbl_Id.Text, lbl_Nombre.Text);
                C.Show();
             }
        }

        private void rdbAgrgar_CheckedChanged(object sender, EventArgs e)
        {

            txtCodigo_prod.Text = "";
            txtNombre_prod.Text = "";
            txtPcompra.Text = "";
            txtPventa.Text = "";
            txt_Cantidad.Text = "";
            txt_cod_Compra.Text = "";
            txt_cod_Compra.Enabled = false;
            txtCodigo_prod.Enabled = true;
            txtNombre_prod.Enabled = true;
            txtPventa.Enabled = false;
            txtPcompra.Enabled = false;
            txt_fecha.Enabled = false;
            btn_realizar.Enabled = true;
            seleccion = 1;
        }

        private void rbdInventario_CheckedChanged(object sender, EventArgs e)
        {
            Borraatxt();
            txt_cod_Compra.Enabled = false;
            txtCodigo_prod.Enabled = false;
            txtNombre_prod.Enabled = false;
            txtPventa.Enabled = false;
            txtPcompra.Enabled = false;
            txt_fecha.Enabled = false;
            btn_realizar.Enabled = true;
            seleccion = 3;
        }

        private void rdbModificar_CheckedChanged(object sender, EventArgs e)
        {
            datos_en_txt();
            txt_cod_Compra.Enabled = false;
            txtCodigo_prod.Enabled = false;
            txtNombre_prod.Enabled = true;
            txtPventa.Enabled = true;
            txtPcompra.Enabled = false;
            txt_fecha.Enabled = true;
            btn_realizar.Enabled = true;
            seleccion = 2;
        }

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            if (seleccion == 1)
            {
                if (txtCodigo_prod.Text == "" ||
                txtNombre_prod.Text == "")
                {
                    MessageBox.Show(string.Format("Algunos datos son necesarios"));
                    return;
                }
                cbd.ManejaInventarioSP(seleccion, Convert.ToInt16(txtCodigo_prod.Text), txtNombre_prod.Text, (Decimal)0.0 , (Decimal)0.0, DateTime.Now.ToString(), 0);
            } else if (seleccion == 2)
            {
                if (txtNombre_prod.Text == "" ||
                txtPventa.Text == "")
                {
                    MessageBox.Show(string.Format("Algunos datos son necesarios"));
                    return;
                }

                cbd.ManejaInventarioSP(seleccion, Convert.ToInt16(txtCodigo_prod.Text), txtNombre_prod.Text, Convert.ToDecimal(txtPcompra.Text), Convert.ToDecimal(txtPventa.Text),
                    txt_fecha.Text, Convert.ToInt16(txt_Cantidad.Text));
            }
            else if (seleccion == 3)
            {
                if (dgvCompras.CurrentRow.Cells[6].Value.ToString() == "Entregado")
                {
                    MessageBox.Show(string.Format("Esta compra ya fue recibida"));
                    return;
                }
                cbd.actualizarCompraInventario(Convert.ToInt16(txt_cod_Compra.Text));
            }
            llenarDatos();
        }
        private void Activatxt()
        {
            txt_cod_Compra.Enabled = true;
            txtCodigo_prod.Enabled = true;
            txtNombre_prod.Enabled = true;
            txtPventa.Enabled = true;
            txtPcompra.Enabled = true;
            txt_fecha.Enabled = true;
        }
        private void Desactivatxt()
        {
            txt_cod_Compra.Enabled = false;
            txtCodigo_prod.Enabled = false;
            txtNombre_prod.Enabled = false;
            txtPventa.Enabled = false;
            txtPcompra.Enabled = false;
            txt_fecha.Enabled = false;
        }
        private void Borraatxt()
        {
            txt_cod_Compra.Text = "";
            txtCodigo_prod.Text = "";
            txtNombre_prod.Text = "";
            txtPventa.Text = "";
            txtPcompra.Text = "";
            txt_Cantidad.Text = "";
            txt_fecha.Text = "";
        }
        private void llenarDatos()
        {
            dt = cbd.Recupera_datos("sp_mostrar_inventario");
            dgvInventario.DataSource = dt;
            for(int i = 0; i < dgvInventario.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i][5].ToString()) < 10)
                {
                    cadena = cadena + dt.Rows[i][1].ToString() + ", ";                                       
                }
                if (Convert.ToDateTime(dt.Rows[i][4].ToString()) < DateTime.Now.AddDays(7))
                {
                    cadena2 = cadena2 + dt.Rows[i][1].ToString() + ", ";
                }
            }
            if (cadena.Length > 2)
                cadena = cadena.Remove(cadena.Length - 2) + ".";
            else
                cadena = "";
            if (cadena2.Length > 2)
                cadena2 = cadena2.Remove(cadena2.Length - 2) + ".";
            else
                cadena2 = "";
            
            dt = cbd.Recupera_datos("sp_mostrar_compras");
            dgvCompras.DataSource = dt;
        }

        private void dgvInventario_Click(object sender, EventArgs e)
        {
            if(rdbModificar.Checked == true)
            {
                datos_en_txt();
            }
        }

        private void dgvCompras_Click(object sender, EventArgs e)
        {
            if(rbdInventario.Checked == true)
                txt_cod_Compra.Text = dgvCompras.CurrentRow.Cells[0].Value.ToString();
        }
        private void datos_en_txt()
        {
            txtCodigo_prod.Text = dgvInventario.CurrentRow.Cells[0].Value.ToString();
            txtNombre_prod.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
            txtPcompra.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
            txtPventa.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
            txt_Cantidad.Text = dgvInventario.CurrentRow.Cells[5].Value.ToString();
            txt_fecha.Value = Convert.ToDateTime(dgvInventario.CurrentRow.Cells[4].Value.ToString());
        }
        private void mensajes()
        {
            if(cadena.Length!=0)
                MessageBox.Show(string.Format("Quedan menos de 10 productos de: " + cadena));
            
            if(cadena2.Length!=0)
                MessageBox.Show(string.Format("Productos proximos a caducar: " + cadena2));
        }
    }
}
