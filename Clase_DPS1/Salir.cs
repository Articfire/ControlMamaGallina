/**
 * @file Salir.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Salir.
 * @brief Archivo que se encarga de la ventana para salir de la aplicación.
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
     * @title Salir
     * @brief Clase que permite una salida segura de la aplicación
     */
    public partial class Salir : Form
    {
        public Salir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo para salir de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /**
         * @title button1_Click.
         * @brief Método que realiza el cierre de la aplicación
         * @param sender objeto que disparó el evento
         * @param e tipo de delegado
         */
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
