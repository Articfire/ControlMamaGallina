/**
 * @file Añadir_Tarea.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Añadir Tarea.
 * @brief Archivo que maneja la interfaz y la creación de nuevas tareas.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clase_DPS1
{
    /**
     * @title Añadir_Tarea
     * @brief Clase donde se lleva a cabo la creación de nuevas tareas.
     */
    public partial class Añadir_Tarea : Form
    {

        int folio = 1;
        string asuntoTarea, detallesTarea, query;
        DateTime fecha;

        /**
         * @title Añadir_Tarea
         * @brief Método constructor de la clase.
         * */
        public Añadir_Tarea()
        {
            InitializeComponent();
            txt_detalles.MaxLength = 100;
            txt_asuntos.MaxLength = 50;
        }

        ConexionBD bd = new ConexionBD();

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        /**
         * @title btn_agregar_Click
         * @brief Evento disparado cuando el botón de agregar es presionado, el cual crea
         * una tarea en al base de datos.
         * @param sender objeto que disparó el evento
         * @param e tipo de delegado
         */
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            query = "Select Asunto From Tarea";
            var resultados2 = bd.Seleccionar(query);

            bool el_asunto_no_se_repite = true;

            for (int i = 0; i < resultados2.Length; i++)
            {
                if (txt_asuntos.Text == resultados2[i].ToString())
                    el_asunto_no_se_repite = false;
            }
            if (el_asunto_no_se_repite)
            {
                if (txt_asuntos.Text != "" && txt_detalles.Text != "")
                {
                    try
                    {

                        String query;

                        //Generar incremento automático en el folio de la tarea.
                        query = "SELECT MAX(Clave_Tarea) FROM Tarea";
                        var resultados = bd.Seleccionar(query);

                        if (resultados != null && !resultados[0].Equals(DBNull.Value))
                            folio = Convert.ToInt32(resultados[0]) + 1;

                        // En esta parte a fuerzas tenia que usar un query con parametros, asi que lo hice sin mi clase.
                        var conexion = bd.Abrir();
                        fecha = dtp_fecha.Value.Date + dtp_hora.Value.TimeOfDay;

                        query = String.Format("INSERT INTO Tarea VALUES " +
                                            "({0}, {1}, {2}, {3});",
                                            folio, asuntoTarea, detallesTarea, "@DATE");

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@DATE", fecha);
                        cmd.ExecuteNonQuery();

                        bd.Cerrar(conexion);
                        MessageBox.Show("Tarea agregada exitosamente ");
                        txt_asuntos.Clear();
                        txt_detalles.Clear();
                        this.Close();
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

        /**
         * @title txt_detalles_KeyPress
         * @brief Evento que realiza la validación del campo detalles.
         * @param sender objeto que disparó el evento
         * @param e tipo de delegado
         * */
        private void txt_detalles_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.ValidatxtLongitudT(txt_detalles, e);
        }

        /**
         * @title txt_detalles_TextChanged
         * @brief Comprueba cambior sealizados en el campo detalles.
         * @param sender objeto que disparó el evento
         * @param e tipo de delegado
         * */
        private void txt_detalles_TextChanged(object sender, EventArgs e)
        {

            detallesTarea = "'" + txt_detalles.Text + "'";
        }

        private void Añadir_Tarea_Load(object sender, EventArgs e)
        {

        }

        /**
         * @tite txt_asuntos_KeyPress
         * @brief Valida la longitud del valor del campo de texto del Asunto
         * @param sender objeto que disparó el evento
         * @param e tipo de delegado
         * */
        private void txt_asuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.ValidatxtLongitud(txt_asuntos, e);
        }

        private void txt_asuntos_TextChanged(object sender, EventArgs e)
        {
            asuntoTarea = "'" + txt_asuntos.Text + "'";
        }
    }
}
