using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        ConexionBD bd = new ConexionBD();

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (User.Text != "" && Pass.Text != "")
            {
                if (User.Text.Length > 0)
                {
                    try
                    {
                        string query = "Select Usuario, Clave, Tipo from Usuarios where Usuario = '" + User.Text + "' ";
                        Object[] resultados = bd.Seleccionar(query);

                        if (User.Text.Equals(resultados[0].ToString())
                            && Pass.Text.Equals(resultados[1].ToString()))
                        {
                            if (resultados[2].ToString().Equals("Administrador"))
                            {
                                Lobby1 v1 = new Lobby1();
                                MessageBox.Show("Bienvenida Aministrador");
                                this.Hide();
                                v1.Show();
                            }
                            else
                            {
                                LobbyB v1 = new LobbyB();
                                MessageBox.Show("Bienvenid@ emplead@");
                                this.Hide();
                                v1.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }

                }
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos vacios");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        public void Form2_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrartodo);
        }
        public void cerrartodo(object sender, EventArgs e)
        {
            Salir x = new Salir();
            x.Show();
        }

        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.ValidatxtLongitudL(User, e);
        }

        private void Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.ValidatxtLongitudL(Pass, e);
        }
    }
    }

