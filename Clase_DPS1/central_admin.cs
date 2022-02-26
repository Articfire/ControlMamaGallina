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
    public partial class central_admin : Form
    {

        public central_admin()
        {
            InitializeComponent();
            
        }

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog = ControlMamaGallina; User ID = sa; Password = controlmamagallina");

        public static string clave="1";

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
