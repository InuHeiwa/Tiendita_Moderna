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
    public partial class Finanzas : Form
    {
        ConexionBD cbd = new ConexionBD();
        DataTable dtI, dtE, dtPuestos;
        int fila = 0;
        public Finanzas(string i, string n)
        {
            InitializeComponent();
            llenarDatos();
            lblId.Text = i;
            lblNombre.Text = n;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (fila != 0)
            {
                fila -= 1;
                txtPuesto.Text = dtPuestos.Rows[fila][1].ToString();
                txtSalario.Text = dtPuestos.Rows[fila][2].ToString();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (fila < dtPuestos.Rows.Count - 1)
            {
                fila++;
                txtPuesto.Text = dtPuestos.Rows[fila][1].ToString();
                txtSalario.Text = dtPuestos.Rows[fila][2].ToString();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtSalario.Enabled = true;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            cbd.registrarPagoEmpleados();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            cbd.registrarCorteSP(Convert.ToDecimal(txtIngresos.Text), Convert.ToDecimal(txtEgresos.Text), Convert.ToDecimal(txtSaldo.Text), Convert.ToInt16(lblId.Text));
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            cbd.modificarSueldoSP(Convert.ToInt16(dtPuestos.Rows[fila][0].ToString()), Convert.ToDecimal(txtSalario.Text));
            txtSalario.Enabled = false;
            dtPuestos = cbd.Recupera_datos("sp_mostrar_puestos");
        }
        private void llenarDatos()
        {
            dtI = cbd.mostrarIngresosEgresos((Int16)0);
            dtE = cbd.mostrarIngresosEgresos((Int16)1);
            dtPuestos = cbd.Recupera_datos("sp_mostrar_puestos");
            dvgIngresos.DataSource = dtI;
            dgvEgresos.DataSource = dtE;
            txtIngresos.Text = cbd.Recupera_datos("sp_total_ingresos").Rows[0][0].ToString();
            txtEgresos.Text = cbd.Recupera_datos("sp_total_egresos").Rows[0][0].ToString();
            if (txtEgresos.Text.Length == 0)
                txtEgresos.Text = "0";
            if (txtIngresos.Text.Length == 0)
                txtIngresos.Text = "0";
            txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtIngresos.Text) - Convert.ToDecimal(txtEgresos.Text));
            txtPuesto.Text = dtPuestos.Rows[fila][1].ToString();
            txtSalario.Text = dtPuestos.Rows[fila][2].ToString();
            txtSaldoCaja.Text = cbd.Recupera_datos("sp_saldo_caja").Rows[0][0].ToString();
        }
    }
}
