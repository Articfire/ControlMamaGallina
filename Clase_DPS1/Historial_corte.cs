/**
 * @file Historial_corte.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Historial de corte.
 * @brief Archivo que se encarga de mostrar el historial de corte de caja.
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
     * @title Historial_corte.
     * @brief Clase que maneja la interfaz gráfica y los eventos para desplegar el historial de cortes de caja
     */
    public partial class Historial_corte : Form
    {
        /**
         * @title Historial_corte.
         * @brief Método constructor.
         */
        public Historial_corte()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reenvia al cliente a la seccion de respaldos de la informacion
        /// de Cortes Diarios, donde se respalda la informacion a un 
        /// archivo de excel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /**
         * @title btn_respaldos_Click.
         * @brief Reenvia al cliente a la sección de respaldos de la información de Cortes diarios, donde
         * se respalda la información a un archivo de excel.
         * @param sender objeto que disparó el evento
         * @param e tipo de delegado
         */
        private void btn_respaldos_Click(object sender, EventArgs e)
        {
            this.Close();
            Respaldos v4 = new Respaldos();
            v4.Show();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
