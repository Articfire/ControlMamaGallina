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
    public partial class Registro_Inventario : Form
    {

        int folio = 1;
        float total = (float)0;
        string surtidor = "'SURTIDOR'", area = "'AREA'";
        DateTime fecha;

        public Registro_Inventario()
        {
            InitializeComponent();
            txtbox_surtidor.MaxLength = 50;
            fecha = DateTime.Now;
        }

        ConexionBD bd = new ConexionBD();

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txtbox_surtidor.Text != "" && txtbox_total.Text != "" && cmb_area.Text != "")
            {
                try
                {

                    String query;

                    // Esta parte es para que la tabla de corte tenga un auto incremento en folio.
                    query = "SELECT MAX(Folio) FROM Compra_Producto";
                    var resultados = bd.Seleccionar(query);

                    try
                    {
                        folio = Convert.ToInt32(resultados[0]) + 1;
                    }
                    catch (Exception) { }

                    // En esta parte a fuerzas tenia que usar un query con parametros, asi que lo hice sin mi clase.
                    var conexion = bd.Abrir();

                    query = String.Format("INSERT INTO Compra_Producto VALUES ({0}, {1}, {2}, {3}, {4});", folio, "@DATE", total, surtidor, area);
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@DATE", fecha);
                    cmd.ExecuteNonQuery();

                    bd.Cerrar(conexion);
                    MessageBox.Show(" Registro de compra hecho exitosamente ");
                    cmb_area.ResetText();
                    txtbox_total.Clear();
                    txtbox_surtidor.Clear();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos vacios");
            }

            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog = ControlMamaGallina; User ID = sa; Password = controlmamagallina");
            SqlCommand cmd2 = new SqlCommand("Select * from Compra_Producto", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            area = "'"+cmb_area.Text+"'";
        }

        private void txtbox_surtidor_TextChanged(object sender, EventArgs e)
        {
            surtidor = "'" + txtbox_surtidor.Text + "'";
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            fecha = dtp_fecha.Value;
        }

        private void txtbox_total_TextChanged(object sender, EventArgs e)
        {
            try
            {
                total = Validaciones.va.FormatearFlotanteEnDobleDecimal(txtbox_total.Text);
            }
            catch (Exception) { }
        }

        private void Registro_Inventario_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog = ControlMamaGallina; User ID = sa; Password = controlmamagallina");
            SqlCommand cmd = new SqlCommand("Select * from Compra_Producto", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }


        private void txtbox_total_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                total = Validaciones.va.FormatearFlotanteEnDobleDecimal(txtbox_total.Text);
            }
            catch (Exception) { }
        }

        private void txtbox_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificardecimal(sender, e);
            Validaciones.va.Validalongittuddec(txtbox_total, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_surtidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.ValidatxtLongitud(txtbox_surtidor, e);
        }

        private void txt_productos_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
