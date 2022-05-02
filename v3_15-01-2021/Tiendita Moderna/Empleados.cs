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
    public partial class Empleados : Form
    {
        private ConexionBD cbd = new ConexionBD();
        private Int16 opcion=0;
        private Int16 id=0;
        DataTable datos;
        Int16 Pst, stat;

        public Empleados()
        {
            InitializeComponent();

            llenarDatos();
            desactivarTxt();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (datos_vacios() == 0)
            {
                if(txt_puesto.Text == "Gerente")
                    Pst = 1;
                if (txt_puesto.Text == "Empleado")
                    Pst = 2;
                if (txt_estatus.Text == "Activo")
                    stat = 1;
                if (txt_estatus.Text == "Inactivo")
                    stat = 2;
                if (txt_estatus.Text == "Despedido")
                    stat = 3;
                cbd.ManejaEmpleadosSP(opcion, id, txt_nombre.Text, txt_ap_paterno.Text, txt_ap_materno.Text, Convert.ToChar(txt_sexo.Text),
                txt_fech_nac.Text, txt_telefono.Text, txt_tel_emerg.Text, txt_rfc.Text, Pst,
                txt_municipio.Text, txt_calle.Text, txt_cp.Text, txt_num_ext.Text, txt_num_int.Text, stat,
                txt_clave.Text, "clave");
            }
            else
            {
                MessageBox.Show(string.Format("Algunos datos son necesarios"));
                return;
            }
            
            opcion = 0;
            desactivarTxt();
            borrarTxt();
            llenarDatos();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnConfirmar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            activarTxt();
            btnConfirmar.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            opcion = 1;
            id = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activarTxt();
            txt_clave.Text = "1";
            btnConfirmar.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            opcion = 2;
            id = System.Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txt_clave.Enabled = false;
            txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ap_paterno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_ap_materno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_sexo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_fech_nac.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            txt_telefono.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_tel_emerg.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_rfc.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_puesto.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_municipio.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txt_calle.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txt_cp.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txt_num_ext.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txt_num_int.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txt_estatus.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
        }
        private void llenarDatos()
        {
            datos = cbd.Recupera_datos("sp_emp");
            dataGridView1.DataSource = datos;
        }
        private void activarTxt()
        {
            txt_ap_materno.Enabled = true;
            txt_ap_paterno.Enabled = true;
            txt_calle.Enabled = true;
            txt_clave.Enabled = true;
            txt_cp.Enabled = true;
            txt_estatus.Enabled = true;
            txt_fech_nac.Enabled = true;
            txt_municipio.Enabled = true;
            txt_nombre.Enabled = true;
            txt_num_ext.Enabled = true;
            txt_num_int.Enabled = true;
            txt_puesto.Enabled = true;
            txt_rfc.Enabled = true;
            txt_sexo.Enabled = true;
            txt_telefono.Enabled = true;
            txt_tel_emerg.Enabled = true;
        }
        private void desactivarTxt()
        {
            txt_ap_materno.Enabled = false;
            txt_ap_paterno.Enabled = false;
            txt_calle.Enabled = false;
            txt_clave.Enabled = false;
            txt_cp.Enabled = false;
            txt_estatus.Enabled = false;
            txt_fech_nac.Enabled = false;
            txt_municipio.Enabled = false;
            txt_nombre.Enabled = false;
            txt_num_ext.Enabled = false;
            txt_num_int.Enabled = false;
            txt_puesto.Enabled = false;
            txt_rfc.Enabled = false;
            txt_sexo.Enabled = false;
            txt_telefono.Enabled = false;
            txt_tel_emerg.Enabled = false;
        }
        private void borrarTxt()
        {
            txt_ap_materno.Text = "";
            txt_ap_paterno.Text = "";
            txt_calle.Text = "";
            txt_clave.Text = "";
            txt_cp.Text = "";
            txt_estatus.Text = "";
            txt_fech_nac.Text = "";
            txt_municipio.Text = "";
            txt_nombre.Text = "";
            txt_num_ext.Text = "";
            txt_num_int.Text = "";
            txt_puesto.Text = "";
            txt_rfc.Text = "";
            txt_sexo.Text = "";
            txt_telefono.Text = "";
            txt_tel_emerg.Text = "";
        }
        private int datos_vacios()
        {
            
            if( txt_ap_materno.Text == "" ||
                txt_ap_paterno.Text == "" ||
                txt_calle.Text == "" ||
                txt_clave.Text == "" ||
                txt_cp.Text == "" ||
                txt_estatus.Text == "" ||
                txt_fech_nac.Text == "" ||
                txt_municipio.Text == "" ||
                txt_nombre.Text == "" ||
                txt_num_ext.Text == "" ||
                txt_puesto.Text == "" ||
                txt_rfc.Text == "" ||
                txt_sexo.Text == "" ||
                txt_telefono.Text == "" ||
                txt_tel_emerg.Text == "")
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
            
        }

        private void txt_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void txt_estatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void txt_sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.KeyChar = '\0';
            
        }
    }
}
