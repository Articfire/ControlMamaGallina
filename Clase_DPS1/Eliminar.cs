/**
 * @file Eliminar.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Eliminar Tarea.
 * @brief Archivo que se encarga de eliminar una tarea seleccionada.
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

namespace Clase_DPS1
{
    /**
     * @title Eliminar
     * @brief Clase que se encarga de la eliminación de tareas de la base de datos.
     */
    public partial class Eliminar : Form
    {
        int clave2 = 1;
        string clave;

        ConexionBD bd = new ConexionBD();

        /**
         * @title Eliminar
         * @brief Método constructor.
         */
        public Eliminar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que elimina la tarea seleccionada previamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /**
         * @title button1_Click.
         * @brief Método que elimina la tarea previamente seleccionada.
         * @param sender objeto que disparó el evento
         * @param e tipo de delegado
         */
        private void button1_Click(object sender, EventArgs e)
        {
            clave = central_admin.clave;
            clave2 = Convert.ToInt32(clave);
            string eliminar;
            eliminar = "Delete From Tarea where Clave_Tarea =" + clave2;
            bd.Eliminar(eliminar);
            MessageBox.Show("Tarea eliminada exitosamente ");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 v5 = new Form1();
            v5.Show();
        }
    }
}
