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
    public partial class central_user : Form
    {
        public central_user()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LAA976E;" +
                                               "Initial Catalog = ControlMamaGallina;" +
                                               "User ID = sa;" +
                                               "Password = controlmamagallina");

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
            Historial_corte v3 = new Historial_corte();
            v3.Show();
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {
            login v0 = new login();
            this.Hide();
            v0.Show();
        }

        /// <summary>
        /// Evento que carga la información de tareas para el
        /// usuario en dgv_tareas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void central_user_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tarea", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_tareas.DataSource = dt;
            conn.Close();
        }

        private void dgv_tareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
