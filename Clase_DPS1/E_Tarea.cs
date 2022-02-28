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
    public partial class Form1 : Form
    {
        int folio = 1, clave2=1;
        string asuntoTarea, detallesTarea, query;
        string clave;
        DateTime fecha;


        public Form1()
        {
            InitializeComponent();
            txtbos_detalles.MaxLength = 100;
            txtbox_asunto.MaxLength = 50;
            
        }

        ConexionBD bd = new ConexionBD();

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar x = new Eliminar();
            x.Show();
            this.Hide();
        }

        private void txtbox_asunto_TextChanged(object sender, EventArgs e)
        {
            asuntoTarea = "'" + txtbox_asunto.Text + "'";
        }

        private void txtbos_detalles_TextChanged(object sender, EventArgs e)
        {
            detallesTarea = "'" + txtbos_detalles.Text + "'";
        }

        private void txtbos_detalles_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.ValidatxtLongitudT(txtbos_detalles, e);
        }

        private void txtbox_asunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.ValidatxtLongitud(txtbox_asunto, e);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clave = central_admin.clave;
            clave2 = Convert.ToInt32(clave);
            query = "Select * From Tarea where Clave_Tarea =" + clave2;
            var resultados = bd.Seleccionar(query);

            fecha = Convert.ToDateTime(resultados[3]);

            //dtp_fecha.Value = fecha.Date;
            txtbos_detalles.Text = resultados[2].ToString();
            txtbox_asunto.Text = resultados[1].ToString();
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Select Asunto From Tarea";
                var resultados = bd.Seleccionar(query);

                bool algo = true;

                for (int i = 0; i < resultados.Length; i++)
                {
                    if (txtbox_asunto.Text == resultados[i].ToString())
                    {
                        algo = false;
                    }
                }
                if (algo == true)
                {
                    if (txtbox_asunto.Text != "" && txtbos_detalles.Text != "")
                    {
                        try
                        {
                            String query;

                            var conexion = bd.Abrir();

                            fecha = dtp_fecha.Value.Date + dtp_hora.Value.TimeOfDay;

                            query = String.Format("UPDATE Tarea SET Asunto=" + asuntoTarea + ", Mensaje=" + detallesTarea + ", Fecha_hora=@DATE WHERE Clave_Tarea=" + clave2);

                            SqlCommand cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@DATE", fecha);
                            cmd.ExecuteNonQuery();

                            bd.Cerrar(conexion);
                            MessageBox.Show("Tarea editada exitosamente ");
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
                }
                else
                {
                    MessageBox.Show("Ya hay una tarea con ese asunto, verificar que no este repetida");
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}
