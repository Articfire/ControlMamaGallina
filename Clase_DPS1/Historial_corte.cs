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
    public partial class Historial_corte : Form
    {
        public Historial_corte()
        {
            InitializeComponent();
        }


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
