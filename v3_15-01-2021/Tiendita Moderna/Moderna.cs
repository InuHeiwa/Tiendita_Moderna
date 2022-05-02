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
    public partial class Moderna : Form
    {
        ConexionBD cbd = new ConexionBD();
        DataTable dt, dc, ultimotabla;
        DataTable historial = new DataTable();
        private DataColumn columna;
        Decimal total=0;
        Int16 ultimo;
        Login x;

        public Moderna(string a, string b, int c, Login z)
        {
            x = z;
            InitializeComponent();
            dgvVentas.Enabled = false;
            if (c == 1)
            {
                menu_empleados.Visible = true;
                menu_finanzas.Visible = true;
            }
            else
            {
                menu_empleados.Visible = false;
                menu_finanzas.Visible = false;
            }
            lbl_id_emp.Text = a;
            lbl_nom_emp.Text = b;
            //Application.Run(new Login());
            lbl_fecha.Text = DateTime.Now.ToString();
            cbxEspecial.Enabled = false;
            llenarListas();
            crearTablaHistorial();
            txtTotal.Text = total.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Empleados":
                    Empleados E = new Empleados();
                    E.Show();
                break;
                case "Pedidos":
                    Pedidos P = new Pedidos();
                    P.Show();
                break;
                case "Finanzas":
                    Finanzas F = new Finanzas(lbl_id_emp.Text, lbl_nom_emp.Text);
                    F.Show();
                    break;
                case "Inventario":
                    Inventario I = new Inventario(lbl_id_emp.Text, lbl_nom_emp.Text);
                    I.Show();
                    break;
                case "Proveedores":
                    Proveedores Pr = new Proveedores();
                    Pr.Show();
                    break;
                case "Clientes":
                    Clientes C = new Clientes();
                    C.Show();
                    break;
                case "Cerrar Sesion":
                    x.recuperarDatos();
                    x.llenarLista();
                    x.Show();
                    this.Close();
                    break;
                    
            }
            
        }
        private void Moderna_FormClosing(Object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (cbxPedido.Checked == true)
            {
                if (cbxEspecial.Checked == true)
                {
                    for (int i = 0; i < dc.Rows.Count; i++)
                    {
                        if (listClientes.Text == dc.Rows[i][1].ToString())
                        {
                            cbd.registrarPedidoSP(Convert.ToInt16(dc.Rows[i][0].ToString()), lbl_fecha.Text, Convert.ToInt16(lbl_id_emp.Text),
                                1, 1, total * (Decimal)0.16, total, Convert.ToString(dtpEntrega.Text));
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dc.Rows.Count; i++)
                    {
                        if (listClientes.Text == dc.Rows[i][1].ToString())
                        {
                            cbd.registrarPedidoSP(Convert.ToInt16(dc.Rows[i][0].ToString()), lbl_fecha.Text, Convert.ToInt16(lbl_id_emp.Text), 
                                1, 2, total * (Decimal)0.16, total, lbl_fecha.Text);
                        }
                    }
                }
                ultimotabla = cbd.Recupera_datos("sp_ultimo_pedido");
                ultimo = Convert.ToInt16(ultimotabla.Rows[0][0].ToString());
                for (int i = 0; i < historial.Rows.Count; i++)
                {
                    cbd.ManejaHistorialSP(1, ultimo, Convert.ToInt16(historial.Rows[i][0]),
                        Convert.ToInt16(historial.Rows[i][1]), Convert.ToDecimal(historial.Rows[i][2]));
                }
            }
            else
            {
                cbd.registrarVentaSP(lbl_fecha.Text, Convert.ToInt16(lbl_id_emp.Text), total*(Decimal)0.16, total);
                ultimotabla = cbd.Recupera_datos("sp_ultima_venta");
                ultimo = Convert.ToInt16(ultimotabla.Rows[0][0].ToString());
                for (int i = 0; i < historial.Rows.Count; i++)
                {
                    cbd.ManejaHistorialSP(3, ultimo, Convert.ToInt16(historial.Rows[i][0]),
                        Convert.ToInt16(historial.Rows[i][1]), Convert.ToDecimal(historial.Rows[i][2]));
                }
                cbd.Quitar_producto_Inventario(ultimo);
            }
            historial.Rows.Clear();
            dgvVentas.Rows.Clear();
            total = 0;
            txtTotal.Text = "";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            llenarListas();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (listProductos.Text == dt.Rows[i][1].ToString())
                {
                    dgvVentas.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), Convert.ToString(Convert.ToDecimal(dt.Rows[i][2].ToString())*(Decimal)0.16), dt.Rows[i][2].ToString());
                    historial.Rows.Add(Convert.ToInt16(dt.Rows[i][0].ToString()), (Int16)1, Convert.ToDecimal(dt.Rows[i][2].ToString()));
                    total += Convert.ToDecimal(dt.Rows[i][2].ToString());
                    txtTotal.Text = total.ToString();
                    break;
                }
            }
            /*dgvHistorial.Rows.Add(cmbProveedor.Text, lbl_Nombre.Text, lbl_Fecha.Text, cmbProductos.Text, numCantidad.Value.ToString(), txtSubtotal.Text);
            productos = cbd.Recupera_datos("sp_ultima_compra");
            id_compra = Convert.ToInt16(productos.Rows[0][0].ToString());
            agregar_historial.Rows.Add(id_compra + 1, id_producto, Convert.ToInt16(numCantidad.Value), Convert.ToDecimal(txtSubtotal.Text));
            total_pago += Convert.ToDecimal(txtSubtotal.Text);
            txtTotal.Text = Convert.ToString(total_pago);*/
        }

        private void cbxPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPedido.Checked == true)
            {
                listClientes.Enabled = true;
                cbxEspecial.Enabled = true;
            }
            else
            {
                cbxEspecial.Checked = false;
                cbxEspecial.Enabled = false;
                listClientes.Enabled = false;
            }
        }
        private void cbxEspecial_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxEspecial.Checked==true)
                dtpEntrega.Enabled = true;
            else
                dtpEntrega.Enabled = false;
        }

        private void cbxPedido_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            total = 0;
            txtTotal.Text = total.ToString();
            historial.Rows.Clear();
            dgvVentas.Rows.Clear();
        }

        private void listProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listProductos_Click(object sender, EventArgs e)
        {
            llenarListas();
        }

        private void llenarListas()
        {
            dt = cbd.Recupera_datos("sp_obtener_productos");
            listProductos.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listProductos.Items.Add(dt.Rows[i][1].ToString());
            }
            dc = cbd.Recupera_datos("sp_obtener_clientes");
            listClientes.Items.Clear();
            for (int i = 0; i < dc.Rows.Count; i++)
            {
                listClientes.Items.Add(dc.Rows[i][1].ToString());
            }
        }
        private void crearTablaHistorial()
        {
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Int16");
            columna.ColumnName = "id_producto";
            historial.Columns.Add(columna);
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Int16");
            columna.ColumnName = "cantidad";
            historial.Columns.Add(columna);
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Decimal");
            columna.ColumnName = "subtotal";
            historial.Columns.Add(columna);
            /*columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Decimal");
            columna.ColumnName = "subtotal";
            historial.Columns.Add(columna);*/
        }
    }
}
