/**
 * @file ConexionBD.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Central Administrador.
 * @brief Archivo que maneja la conexión con la base de datos.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clase_DPS1
{
    /**
     * @title ConexionBD
     * @brief Clase que se encarga de realizar la conexión del sistema a la base de datos.
     */
    public class ConexionBD
    {
        string connectionString;
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;


        /**
         * @title ConexionBD
         * @brief Método constructor de la clase.
         * */
        public ConexionBD()
        {
            connectionString = "Data Source=TACOSMASH34;" +
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

        /**
         * @title Seleccionar
         * @brief Método utilizado para obtener la información de la base de datos.
         * @param query Parámetro que se utiliza como línea de comando SQL.
         * */
        public object[] Seleccionar(string query)
        {
            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                object[] values = new object[reader.FieldCount];

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int fieldCount = reader.GetValues(values);

                    }
                }
                else
                {
                    return new object[] {};
                }
                command.Dispose();
                conn.Close();

                return values;
            }
            catch (Exception)
            {

                return new object[] {};
            }
        }

        internal object Cerrar()
        {
            throw new NotImplementedException();
        }

        /**
         * @title Insertar
         * @brief Método utilizado para insdertar información en la base de datos.
         * @param query Parámetro que se utiliza como línea de comando SQL.
         * */
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

        /**
         * @title Actualizar
         * @brief Método utilizado para obtener la información de la base de datos y actualizar su despliegue.
         * @param query Parámetro que se utiliza como línea de comando SQL.
         * */
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

        /**
         * @title Eliminar
         * @brief Método utilizado para eliminar un registro de la base de datos
         * @param query Parámetro que se utiliza como línea de comando SQL.
         * */
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
    }
}
