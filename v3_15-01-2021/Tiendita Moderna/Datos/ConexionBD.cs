using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;




namespace Tiendita_Moderna.Datos
{
    public class ConexionBD
    {
        private SqlConnection con;
        private SqlCommand comQry;
        private SqlDataReader lec;

        private String cadConexion = "Data Source=DESKTOP-20K6EEL\\SQSERVERB; Initial Catalog=Tiendita_Moderna_v1; Trusted_Connection=True";

        public ConexionBD()
        {
            con = new SqlConnection(cadConexion);
        }
        private void ConBD()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la BD" + ex.ToString());
            }
        }

        public DataTable CompClave(string nombre, string clave)
        {
            DataTable tablaReg = new DataTable();
            con.Open();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("sp_comp_clave", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;

                datos.SelectCommand.Parameters.AddWithValue("@nomE", nombre);
                datos.SelectCommand.Parameters.AddWithValue("@clve", clave);
                
                datos.Fill(tablaReg);
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos: " + ex.ToString());
            }
            con.Close();

            return tablaReg;
        }
        public void ManejaEmpleadosSP(Int16 opcion, Int16 id_emp, String nom_emp, String appat_emp, String apmat_emp, char sexo_emp,
            String fnac_emp, String tel_emp, String con_eme_emp, String rfc_emp, Int16 pues_emp,
            String muni_emp, String calle_emp, String cpos_emp, String next_emp, String nint_emp, Int16 estatus_emp, String clave, String llave)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_manejo_empleados", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@opcion", opcion);
                comQry.Parameters.AddWithValue("@id_emp", id_emp);
                comQry.Parameters.AddWithValue("@nom_emp", nom_emp);
                comQry.Parameters.AddWithValue("@appat_emp", appat_emp);
                comQry.Parameters.AddWithValue("@apmat_emp", apmat_emp);
                comQry.Parameters.AddWithValue("@sexo_emp", sexo_emp);
                comQry.Parameters.AddWithValue("@fnac_emp", Convert.ToDateTime(fnac_emp));
                comQry.Parameters.AddWithValue("@tel_emp", tel_emp);
                comQry.Parameters.AddWithValue("@con_eme_emp", con_eme_emp);
                comQry.Parameters.AddWithValue("@rfc_emp", rfc_emp);
                comQry.Parameters.AddWithValue("@pues_emp", pues_emp);
                comQry.Parameters.AddWithValue("@muni_emp", muni_emp);
                comQry.Parameters.AddWithValue("@calle_emp", calle_emp);
                comQry.Parameters.AddWithValue("@cpos_emp", cpos_emp);
                comQry.Parameters.AddWithValue("@next_emp", next_emp);
                comQry.Parameters.AddWithValue("@nint_emp", nint_emp);
                comQry.Parameters.AddWithValue("@estatus_emp", estatus_emp);
                comQry.Parameters.AddWithValue("@clave", clave);
                comQry.Parameters.AddWithValue("@llave", llave);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void ManejaclientesSP(Int16 opcion, Int16 id_client, String nom_client, String calle_client, String next_client, String nint_client,
            String telf_client)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_maneja_client", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@opcion", opcion);
                comQry.Parameters.AddWithValue("@id_client", id_client);
                comQry.Parameters.AddWithValue("@nom_client", nom_client);
                comQry.Parameters.AddWithValue("@calle_client", calle_client);
                comQry.Parameters.AddWithValue("@next_client", next_client);
                comQry.Parameters.AddWithValue("@nint_client", nint_client);
                comQry.Parameters.AddWithValue("@telf_client", telf_client);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void ManejaHistorialSP(Int16 operacion , Int16 id_op, Int16 id_prod, Int16 cantidad, Decimal subtotal)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_historial", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@operacion", operacion);
                comQry.Parameters.AddWithValue("@id_op", id_op);
                comQry.Parameters.AddWithValue("@id_prod", id_prod);
                comQry.Parameters.AddWithValue("@cantidad", cantidad);
                comQry.Parameters.AddWithValue("@subtotal", subtotal);
                
                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void ManejaComprasSP(Int16 opcion, Int16 id_comp, Int16 id_prov, Int16 id_emp, String fec_comp, Decimal iva_comp, Decimal total, Int16 estado)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_compra_historial", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@opcion", opcion);
                comQry.Parameters.AddWithValue("@id_comp", id_comp);
                comQry.Parameters.AddWithValue("@id_prov", id_prov);
                comQry.Parameters.AddWithValue("@id_emp", id_emp);
                comQry.Parameters.AddWithValue("@fec_comp", Convert.ToDateTime(fec_comp));
                comQry.Parameters.AddWithValue("@iva_comp", iva_comp);
                comQry.Parameters.AddWithValue("@total", total);
                comQry.Parameters.AddWithValue("@estado", estado);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void ManejaProveedoresSP(Int16 opcion, Int16 id_prov, String nom_prov, String muni_prov, String calle_prov, String cp_prov,
            String num_ext_prov, String tel_prov, String rfc_prov, String nom_rep)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_maneja_proveedores", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@opcion", opcion);
                comQry.Parameters.AddWithValue("@id_prov", id_prov);
                comQry.Parameters.AddWithValue("@nom_prov", nom_prov);
                comQry.Parameters.AddWithValue("@muni_prov", muni_prov);
                comQry.Parameters.AddWithValue("@calle_prov", calle_prov);
                comQry.Parameters.AddWithValue("@cp_prov", cp_prov);
                comQry.Parameters.AddWithValue("@num_ext_prov", num_ext_prov);
                comQry.Parameters.AddWithValue("@tel_prov", tel_prov);
                comQry.Parameters.AddWithValue("@rfc_prov", rfc_prov);
                comQry.Parameters.AddWithValue("@nom_rep", nom_rep);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void ManejaInventarioSP(Int16 opcion, Int16 codigo, String nom_prod, Decimal prec_com_prod, Decimal prec_ven_prod, String fec_cad_prod,
            Int16 cant_prod )
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_modificar_inventario", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@opcion", opcion);
                comQry.Parameters.AddWithValue("@codigo", codigo);
                comQry.Parameters.AddWithValue("@nom_prod", nom_prod);
                comQry.Parameters.AddWithValue("@prec_com_prod", prec_com_prod);
                comQry.Parameters.AddWithValue("@prec_ven_prod", prec_ven_prod);
                comQry.Parameters.AddWithValue("@fec_cad_prod", Convert.ToDateTime(fec_cad_prod));
                comQry.Parameters.AddWithValue("@cant_prod", cant_prod);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public DataTable Lista_Prod(Int16 id_prov)
        {
            DataTable tablaReg = new DataTable();
            con.Open();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("sp_mostrar_productos", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;

                datos.SelectCommand.Parameters.AddWithValue("@id_prov", id_prov);

                datos.Fill(tablaReg);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos: " + ex.ToString());
            }
            con.Close();

            return tablaReg;
        }
        public DataTable actualizarCompraInventario(Int16 id_compra)
        {
            DataTable tablaReg = new DataTable();
            con.Open();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("sp_finalizar_compra", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;

                datos.SelectCommand.Parameters.AddWithValue("@id_compra", id_compra);

                datos.Fill(tablaReg);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos: " + ex.ToString());
            }
            con.Close();

            return tablaReg;
        }
        public DataTable Lista_Prod_Prov(Int16 id_prov)
        {
            DataTable tablaReg = new DataTable();
            con.Open();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("sp_listar_productos_proveedores", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;

                datos.SelectCommand.Parameters.AddWithValue("@proveedor", id_prov);

                datos.Fill(tablaReg);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos: " + ex.ToString());
            }
            con.Close();

            return tablaReg;
        }
        public DataTable mostrarDetallesPedido(Int16 id_pedido)
        {
            DataTable tablaReg = new DataTable();
            con.Open();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("sp_mostrar_detalles_pedido", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;

                datos.SelectCommand.Parameters.AddWithValue("@id_pedido", id_pedido);

                datos.Fill(tablaReg);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos: " + ex.ToString());
            }
            con.Close();

            return tablaReg;
        }
        public DataTable mostrarProductosNoProveedor(Int16 id_prov)
        {
            DataTable tablaReg = new DataTable();
            con.Open();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("sp_producto_no_proveedor", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;

                datos.SelectCommand.Parameters.AddWithValue("@id_prov", id_prov);

                datos.Fill(tablaReg);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos: " + ex.ToString());
            }
            con.Close();

            return tablaReg;
        }
        public void asignaProductoProveedor(Int16 id_prod, Int16 id_prov)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_producto_con_proveedor", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@id_prod", id_prod);
                comQry.Parameters.AddWithValue("@id_prov", id_prov);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void registrarPagoEmpleados()
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_pagar_empleados", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void actualizarEstadoPedidos(Int16 id_pedido, Int16 id_estado)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_manejar_estados_pedidos", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@id_pedido", id_pedido);
                comQry.Parameters.AddWithValue("@id_estado", id_estado);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public DataTable Recupera_datos(String sp)
        {
            con.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter clientes = new SqlDataAdapter(sp, con);
                clientes.SelectCommand.CommandType = CommandType.StoredProcedure;

                clientes.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos: " + ex.ToString());
            }
            con.Close();

            return dt;
        }
        public void registrarVentaSP(String fec_vent, Int16 id_emp, Decimal iva_vent,Decimal total)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_venta_historial", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@fec_vent", Convert.ToDateTime(fec_vent));
                comQry.Parameters.AddWithValue("@id_emp", id_emp);
                comQry.Parameters.AddWithValue("@iva_vent", iva_vent);
                comQry.Parameters.AddWithValue("@total", total);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void registrarCorteSP(Decimal ingresos, Decimal egresos, Decimal saldo,Int16 id_emp)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_ingresar_corte", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@ingresos", ingresos);
                comQry.Parameters.AddWithValue("@egresos", egresos);
                comQry.Parameters.AddWithValue("@saldo", saldo);
                comQry.Parameters.AddWithValue("@id_emp", id_emp);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void registrarPedidoSP(Int16 id_client, String fec_ped, Int16 id_emp, Int16 estado_ped , Int16 tip_ped, Decimal iva_comp, 
            Decimal total, String fec_ent)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_pedido_historial", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@id_client", id_client);
                comQry.Parameters.AddWithValue("@fec_ped", Convert.ToDateTime(fec_ped));
                comQry.Parameters.AddWithValue("@id_emp", id_emp);
                comQry.Parameters.AddWithValue("@estado_ped", estado_ped);
                comQry.Parameters.AddWithValue("@tip_ped", tip_ped);
                comQry.Parameters.AddWithValue("@iva_comp", iva_comp);
                comQry.Parameters.AddWithValue("@total", total);
                comQry.Parameters.AddWithValue("@fec_ent", Convert.ToDateTime(fec_ent));

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public void modificarSueldoSP(Int16 id_puesto, Decimal suel_puesto)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_actualizar_sueldo", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@id_puesto", id_puesto);
                comQry.Parameters.AddWithValue("@suel_puesto", suel_puesto);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public DataTable mostrarIngresosEgresos(Int16 opcion)
        {
            DataTable tablaReg = new DataTable();
            con.Open();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("sp_ingresos_egresos", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;

                datos.SelectCommand.Parameters.AddWithValue("@ocpion", opcion);

                datos.Fill(tablaReg);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar los datos: " + ex.ToString());
            }
            con.Close();

            return tablaReg;
        }
        public void Quitar_producto_Inventario(Int16 id_venta)
        {
            bool exito = false;
            con.Open();

            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                comQry = new SqlCommand("sp_quitar_ventas", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();

                comQry.Parameters.AddWithValue("@id_venta", id_venta);

                comQry.ExecuteNonQuery();

                exito = true;
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaccion NO Exitosa: " + ex.ToString());
            }
            finally
            {
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
    }
}
