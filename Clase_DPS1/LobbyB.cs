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
    public partial class LobbyB : Form
    {
        public LobbyB()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrartodo);
        }
        private void cerrartodo(object sender, EventArgs e)
        {
            Salir x = new Salir();
            x.Show();
        }
        public void addformulario(Form f)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            central_user f = new central_user();
            addformulario(f);
        }

        private void btn_hi_Click(object sender, EventArgs e)
        {
            Registro_Inventario f = new Registro_Inventario();
            addformulario(f);
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            Corte f = new Corte();
            addformulario(f);
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {
            login v0 = new login();
            this.Hide();
            v0.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salir x = new Salir();
            x.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
