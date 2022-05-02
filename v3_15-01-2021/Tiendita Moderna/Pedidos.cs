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
    public partial class Pedidos : Form
    {
        DataTable dt, de;
        ConexionBD cbd = new ConexionBD();
        Int16 id_estado;
        public Pedidos()
        {
            InitializeComponent();
            recuperarLlenarPedidos();
            llenarEstados();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow.Cells[4].Value.ToString() == "Entregado")
            {
                MessageBox.Show(string.Format("Este Pedido ya fue entregado"));
                return;
            }
            for (int i = 0; i < de.Rows.Count; i++)
            {
                if (listEstados.Text == de.Rows[i][1].ToString())
                    id_estado = Convert.ToInt16(de.Rows[i][0].ToString());
            }
            cbd.actualizarEstadoPedidos(Convert.ToInt16(dgvPedidos.CurrentRow.Cells[0].Value.ToString()), id_estado);
            recuperarLlenarPedidos();
            listEstados.Text = "";
        }
        private void recuperarLlenarPedidos()
        {
            dt = cbd.Recupera_datos("sp_mostrar_pedidos");
            dgvPedidos.DataSource = dt;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            dgvDescripcion.DataSource = cbd.mostrarDetallesPedido(Convert.ToInt16(dgvPedidos.CurrentRow.Cells[0].Value.ToString()));

        }
        private void llenarEstados()
        {
            de = cbd.Recupera_datos("sp_mostrar_estados");
            listEstados.Items.Clear();
            for (int i = 1; i < de.Rows.Count; i++)
            {
                listEstados.Items.Add(de.Rows[i][1].ToString());
            }
        }
    }
}
