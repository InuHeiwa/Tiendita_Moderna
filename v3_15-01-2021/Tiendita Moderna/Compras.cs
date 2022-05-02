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
    public partial class Compras : Form
    {
        private ConexionBD cbd = new ConexionBD();
        private DataTable proveedores, productos, dt;
        private DataTable agregar_historial = new DataTable();
        private DataColumn columna;
        Int16 id_proveedor=1, id_producto=1, id_compra=0;
        Decimal total_pago = (Decimal)0.0;
        public Compras(string id_emp, string nombre)
        {
            InitializeComponent();
            lbl_Id.Text = id_emp;
            lbl_Nombre.Text = nombre;
            lbl_Fecha.Text = DateTime.Today.ToString();
            mostrarCompras();
            recuperarProveedores();
            llenarProveedores();
            crearTablaHistorial();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            cbd.ManejaComprasSP(0, 0, id_proveedor, Convert.ToInt16(lbl_Id.Text), DateTime.Today.ToString(), total_pago * (Decimal)0.16, total_pago, 1);
            for(int i=0; i<agregar_historial.Rows.Count; i++)
            {
                cbd.ManejaHistorialSP(2, Convert.ToInt16(agregar_historial.Rows[i][0]), Convert.ToInt16(agregar_historial.Rows[i][1]), 
                    Convert.ToInt16(agregar_historial.Rows[i][2]), Convert.ToDecimal(agregar_historial.Rows[i][3]));
            }
            mostrarCompras();
        }

        private void cmbProveedor_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < proveedores.Rows.Count; i++)
            {
                if (cmbProveedor.Text == proveedores.Rows[i][0].ToString())
                    id_proveedor = System.Convert.ToInt16(proveedores.Rows[i][1].ToString());
            }
            recuperarProductos();
            llenarProductos();
            cmbProveedor.Enabled = false;
            cmbProductos.Enabled = true;
        }

        private void cmbProductos_TextChanged(object sender, EventArgs e)
        {
            cmbProductos.Enabled = false;
            numCantidad.Enabled = true;
            txtSubtotal.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            recuperarProductos();
            for (int i = 0; i < productos.Rows.Count; i++)
            {
                if (cmbProductos.Text == productos.Rows[i][0].ToString())
                {
                    id_producto = System.Convert.ToInt16(productos.Rows[i][1].ToString());
                    break;
                }
            }
            dgvHistorial.Rows.Add(cmbProveedor.Text,lbl_Nombre.Text,lbl_Fecha.Text, cmbProductos.Text, numCantidad.Value.ToString(), txtSubtotal.Text);
            productos = cbd.Recupera_datos("sp_ultima_compra");
            id_compra = Convert.ToInt16(productos.Rows[0][0].ToString());
            agregar_historial.Rows.Add(id_compra+1, id_producto, Convert.ToInt16(numCantidad.Value), Convert.ToDecimal(txtSubtotal.Text));
            total_pago += Convert.ToDecimal(txtSubtotal.Text);
            txtTotal.Text = Convert.ToString(total_pago);
            //aqui se agrega al grid
            cmbProductos.Text = "";
            numCantidad.Value = 0;
            txtSubtotal.Text = "0";
            cmbProductos.Enabled = true;
            numCantidad.Enabled = false;
            txtSubtotal.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            total_pago = (Decimal)0.0;
            agregar_historial.Rows.Clear();
            dgvHistorial.Rows.Clear();
            cmbProductos.Items.Clear();
            cmbProductos.Text = "";
            numCantidad.Value = 0;
            txtSubtotal.Text = "";
            txtTotal.Text = Convert.ToString(total_pago);
            cmbProveedor.Text = "";
            recuperarProveedores();
            llenarProveedores();
            cmbProveedor.Enabled = true;
            cmbProductos.Enabled = false;
            numCantidad.Enabled = false;
            txtSubtotal.Enabled = false;
            txtTotal.Enabled = false;
        }
        private void recuperarProveedores()
        {
            proveedores = cbd.Recupera_datos("sp_listar_proveedores");
        }
        private void recuperarProductos()
        {
            productos = cbd.Lista_Prod_Prov(id_proveedor);
        }
        private void llenarProveedores()
        {
            cmbProveedor.Items.Clear();
            for (int i = 0; i < proveedores.Rows.Count; i++)
            {
                cmbProveedor.Items.Add(proveedores.Rows[i][0].ToString());
            }
        }

        private void llenarProductos()
        {
            cmbProductos.Items.Clear();
            for (int i = 0; i < productos.Rows.Count; i++)
            {
                cmbProductos.Items.Add(productos.Rows[i][0].ToString());
            }
        }

        private void mostrarCompras()
        {
            dt = cbd.Recupera_datos("sp_mostrar_compras");
            dgvCompras.DataSource = dt;
        }

        private void crearTablaHistorial()
        {
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Int16");
            columna.ColumnName = "id_compr";
            agregar_historial.Columns.Add(columna);
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Int16");
            columna.ColumnName = "id_produ";
            agregar_historial.Columns.Add(columna);
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Int16");
            columna.ColumnName = "cantidad";
            agregar_historial.Columns.Add(columna);
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Decimal");
            columna.ColumnName = "subtotal";
            agregar_historial.Columns.Add(columna);
        }
    }
}
