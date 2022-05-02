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
    public partial class Login : Form
    {
        private ConexionBD cbd = new ConexionBD();
        private DataTable datos;
        public Login()
        {
            InitializeComponent();
            recuperarDatos();
            llenarLista();
        }
       
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int a;
            
            dt = cbd.CompClave(list_nom.Text, txt_clave.Text);
            if (Convert.ToInt32(dt.Rows[0][0]) != 0)
            {
                this.Hide();
                Moderna m = new Moderna(dt.Rows[0][0].ToString(),dt.Rows[0][1].ToString(),Convert.ToInt32(dt.Rows[0][2]),this);
                m.Show();
                txt_clave.Text = "";
                list_nom.Text = "";
            }
            else
            {
                txt_clave.Text = "";
                MessageBox.Show(string.Format("La clave es incorrecta"));
            }
        }
        public void recuperarDatos()
        {
            datos = cbd.Recupera_datos("sp_lista_emp");
            list_nom.Text = datos.Rows[0][0].ToString();
        }
        public void llenarLista()
        {
            list_nom.Items.Clear();
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                list_nom.Items.Add(datos.Rows[i][0].ToString());
            }
        }

        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(Keys.Enter))
            {
                btn_entrar_Click(sender, e);
            }
        }
    }
}
