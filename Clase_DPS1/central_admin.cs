/**
 * @file central_admin.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Central Administrador.
 * @brief Archivo que maneja la interfaz de la central de administración.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    /**
     * @title central_admin
     * @brief Clase donde se lleva el control de la central de administración.
     */
    public partial class central_admin : Form
    {

        /**
         * @title central_admin
         * @brief Método constructor de la clase.
         * */
        public central_admin()
        {
            InitializeComponent();

        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LAA976E;" +
                                                "Initial Catalog = ControlMamaGallina;" +
                                                "User ID = sa;" +
                                                "Password = controlmamagallina");

        public static string clave = "1";

        /// <summary>
        /// Método para refrescar la información en dgv_tareas
        /// </summary>

        /**
         * @title refrescar
         * @brief Método que refresca la información desplegada desde la base de datos.
         * */
        public void refrescar()
        {
            SqlCommand cmd = new SqlCommand("Select * from Tarea", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_tareas.DataSource = dt;
            conn.Close();
        }

        private void btn_hi_Click(object sender, EventArgs e)
        {
            Registro_Inventario v1 = new Registro_Inventario();
            v1.Show();
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            Corte v2 = new Corte();
            v2.Show();
        }

        private void btn_hc_Click(object sender, EventArgs e)
        {
            Historial_corte v2 = new Historial_corte();
            v2.Show();
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {
            login v0 = new login();
            this.Close();
            v0.Show();
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            Añadir_Tarea v4 = new Añadir_Tarea();
            v4.Show();

        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            Form1 v5 = new Form1();

            v5.Show();
        }

        /// <summary>
        /// Evento que carga la información de tareas para el
        /// administrador en dgv_tareas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /**
         * @title central_admin_Load
         * @brief Evento que carga la información de tareas para el administrador en dgv_tareas.
         * @param sender objeto que disparó el evento
         * @param e tipo de delegado
         */
        public void central_admin_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tarea", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_tareas.DataSource = dt;
            conn.Close();
            //clave = dgv_tareas.Rows[0].Cells[0].Value.ToString();
        }

        private void dgv_tareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clave = dgv_tareas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void dgv_tareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}