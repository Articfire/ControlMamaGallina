/**
 * @file login.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Login.
 * @brief Archivo que se encarga validar las credenciales para el login de usuario.
 */
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    public partial class login : Form
    {
        /**
         * @title login
         * @brief Interfaz del login donde el usuario introduce sus credenciales de acceso.
         */
        public login()
        {
            InitializeComponent();
        }

        ConexionBD bd = new ConexionBD();

        public bool isUserLoginValid(Object[] resultados, string user_field, string password_field)
        {
            if (user_field == "" && password_field == "")
            {
                MessageBox.Show("Favor de llenar los campos vacios.");
                return false;
            }

            if (resultados == null)
            {
                MessageBox.Show("El nombre de usuario no existe.");
                return false;
            }

            if (!(user_field.Equals(resultados[0]) && password_field.Equals(resultados[1])))
            {
                MessageBox.Show("El usuario y la contraseña no concuerdan.");
                return false;
            }
            return true;
        }

        /**
         * @tite Login
         * @brief Método que se encarga de verificar las credenciales de acceso el ingresar
         * al cliente al sistema y, dependiendo del tipo de acceso, darle acceso limitado si
         * es un empleado o ilimitado si es el administrador.
         */
        public void Login()
        {
            // resultados[0] es Usuario, resultados[1] es Clave, resultados[2] es Tipo
            string query = "Select Usuario, Clave, Tipo from Usuarios where Usuario = '" + User.Text + "' ";

            object[] resultados = bd.Seleccionar(query);

            bool condicionSalida;
            condicionSalida = isUserLoginValid(resultados, User.Text, Pass.Text);

            if (!condicionSalida) return;

            if (resultados[2].Equals("Administrador"))
            {
                Lobby1 v1 = new Lobby1();
                MessageBox.Show("Bienvenida Administradora");
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

        public void btn_ingresar_Click(object sender, EventArgs e)
        {
            Login();
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

