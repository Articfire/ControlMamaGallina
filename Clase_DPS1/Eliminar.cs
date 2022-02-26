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
    public partial class Eliminar : Form
    {
        int clave2 = 1;
        string clave;

        ConexionBD bd = new ConexionBD();

        public Eliminar()
        {
            InitializeComponent();
        }

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
