using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clase_DPS1
{
    class ConexionBD
    {
        string connectionString;
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        /// <summary>
        /// Credenciales para crear la conección con la base de datos
        /// </summary>
        public ConexionBD()
        {
            connectionString = "Data Source=localhost;" +
                                "Initial Catalog = ControlMamaGallina;" +
                                "User ID = sa;" +
                                "Password = controlmamagallina";
            conn = new SqlConnection(connectionString);

        }

        public SqlConnection Abrir()
        {
            conn.Open();
            return conn;
        }

        public void Cerrar(SqlConnection conn)
        {
            conn.Close();
        }

        public Object[] Seleccionar(string query)
        {
            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                Object[] values = new Object[reader.FieldCount];

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int fieldCount = reader.GetValues(values);

                    }
                }
                else
                {
                    return null;
                }
                command.Dispose();
                conn.Close();

                return values;
            }
            catch (Exception)
            {

                return null;
            }
        }

        internal object Cerrar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(string query)
        {
            conn.Open();
            command = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter();

            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        }

        public void Actualizar(string query)
        {
            conn.Open();
            command = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter();

            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        }

        public void Eliminar(string query)
        {

            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        /*
        public Object[] CargarDGV(string query)
        {
            conn.Open();
            command = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);

            command.Dispose();
            conn.Close();

            return datatable;
        }
        */

    }
}
