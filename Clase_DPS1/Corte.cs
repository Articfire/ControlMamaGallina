using System;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    public partial class Corte : Form
    {

        double b1000 =0;
        double b500 =0;
        double b200 = 0;
        double b100 = 0;
        double b50 = 0;
        double b20 = 0;
        double m10 = 0;
        double m5 = 0;
        double m2 = 0;
        double m1 = 0;
        double c50 = 0;
        double bancos = 0;
        double entradas = 0;
        double retiros = 0;
        double tcaja = 0;
        double toefectivo = 0;
        double dif = 0;
        double totalgeneral = 0;

        int folio = 1;
        int m20 = 0;

        public Corte()
        {
            InitializeComponent();
        }

        ConexionBD bd = new ConexionBD();

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                String query;

                // Esta parte es para que la tabla de corte tenga un auto incremento en folio.
                query = "SELECT MAX(Folio) FROM Corte";
                var resultados = bd.Seleccionar(query);

                if (resultados[0] != null)
                {
                    folio = Convert.ToInt32(resultados[0]) + 1;
                }


                // En esta parte a fuerzas tenia que usar un query con parametros, asi que lo hice sin mi clase.
                var conexion = bd.Abrir();

                query = String.Format("INSERT INTO Corte VALUES (" +
                                        "{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}," +
                                        "{10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18});",
                                        folio, "@DATE", (float)toefectivo, (float)bancos, (float)tcaja,
                                        (int)b1000, (int)b500, (int)b200, (int)b100, (int)b50, (int)b20,
                                        (int)m20, (int)m10, (int)m5, (int)m2, (int)m1, (int)c50,
                                        (float)totalgeneral,(float)retiros);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@DATE", DateTime.Now);
                cmd.ExecuteNonQuery();

                bd.Cerrar(conexion);
                MessageBox.Show(" Corte echo exitosamente ", " corte completado");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            this.Close();
        }

        private void bi500_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b500 = Convert.ToInt32(bi500.Text);

            }
            catch (Exception) { }
        }

        private void bi200_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b200 = Convert.ToInt32(bi200.Text);

            }
            catch (Exception) { }
        }

        private void bi100_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b100 = Convert.ToInt32(bi100.Text);

            }
            catch (Exception) { }
        }

        private void bi50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b50 = Convert.ToInt32(bi50.Text);

            }
            catch (Exception) { }
        }

        private void bi20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b20 = Convert.ToInt32(bi20.Text);

            }
            catch (Exception) { }
        }

        private void mo10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m10 = Convert.ToInt32(mo10.Text);

            }
            catch (Exception) { }
        }

        private void mo5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m5 = Convert.ToInt32(mo5.Text);

            }
            catch (Exception) { }
        }

        private void mo2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m2 = Convert.ToInt32(mo2.Text);

            }
            catch (Exception) { }
        }

        private void mo1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m1 = Convert.ToInt32(mo1.Text);

            }
            catch (Exception) { }
        }

        private void ce50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c50 = Convert.ToInt32(ce50.Text);

            }
            catch (Exception) { }
        }

        private void bi1000_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b1000 = Convert.ToInt32(bi1000.Text);

            }
            catch (Exception) { }
        }

        private void Retiros_TextChanged(object sender, EventArgs e)
        {
            try
            {
                retiros = (float)Convert.ToDouble(ret.Text);
            }
            catch (Exception) { }
        }

        private void total_tarjeta_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                tarjeta = (float)Convert.ToDouble(banco.Text);
            }
            catch (Exception) { }*/
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            MessageBox.Show("Este es el 15");
        }

        private void total_tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificardecimal(sender, e);
            Validaciones.va.Validanumlongittud(bi1000, e);
        }

        private void bi1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(bi1000, e);
        }

        private void bi500_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(bi500, e);
        }

        private void bi200_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(bi200, e);
        }

        private void bi100_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(bi100, e);
        }

        private void bi50_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(bi50, e);
        }

        private void bi20_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(bi20, e);
        }

        private void mo10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(mo10, e);
        }

        private void mo5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(mo5, e);
        }

        private void mo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(mo2, e);
        }

        private void mo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(mo1, e);
        }

        private void ce50_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificarnumero(sender, e);
            Validaciones.va.Validanumlongittud(ce50, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (bi1000.Text != "")
            {
                b1000 = Convert.ToDouble(bi1000.Text);
                b1000 = b1000 * 1000;
            }
            else
            {
                b1000 = 0;
            }


            if (bi500.Text != "")
            {
                b500 = Convert.ToDouble(bi500.Text);
                b500 = b500 * 500;
            }
            else
            {
                b500 = 0;
            }


            if (bi200.Text != "")
            {
                b200 = Convert.ToDouble(bi200.Text);
                b200 = b200 * 200;
            }
            else
            {
                b200 = 0;
            }

            if (bi100.Text != "")
            {
                b100 = Convert.ToDouble(bi100.Text);
                b100 = b100 * 100;
            }
            else
            {
                b100 = 0;
            }

            if (bi50.Text != "")
            {
                b50 = Convert.ToDouble(bi50.Text);
                b50 = b50 * 50;

            }
            else
            {
                b50 = 0;
            }
            if (bi20.Text != "")
            {
                b20 = Convert.ToDouble(bi20.Text);
                b20 = b20 * 20;
            }
            else
            {
                b20 = 0;
            }

            if (mo10.Text != "")
            {
                m10 = Convert.ToDouble(mo10.Text);
                m10 = m10 * 10;
            }
            else
            {
                m10 = 0;
            }

            if (mo5.Text != "")
            {
                m5 = Convert.ToDouble(mo5.Text);
                m5 = m5 * 5;
            }
            else
            {
                m5 = 0;
            }

            if (mo2.Text != "")
            {
                m2 = Convert.ToDouble(mo2.Text);
                m2 = m2 * 2;
            }
            else
            {
                m2 = 0;
            }

            if (mo1.Text != "")
            {
                m1 = Convert.ToDouble(mo1.Text);
            }
            else
            {
                m1 = 0;
            }

            if (ce50.Text != "")
            {
                c50 = Convert.ToDouble(ce50.Text);
                c50 = c50 * 0.5;
            }
            else
            {
                c50 = 0;
            }

            if (Totalcaja.Text != "")
            {
                tcaja = Convert.ToDouble(Totalcaja.Text);
            }
            else
            {
                tcaja = 0;
            }
            if (ret.Text != "")
            {
                retiros = Convert.ToDouble(ret.Text);
            }
            else
            {
                retiros = 0;
            }
            if (ent.Text != "")
            {
                entradas = Convert.ToDouble(ent.Text);
            }
            else
            {
                entradas = 0;
            }
            if (banco.Text != "")
            {
                bancos = Convert.ToDouble(banco.Text);
            }
            else
            {
                bancos = 0;
            }


            toefectivo = b1000 + b500 + b200 + b100 + b50 + b20 + m10 + m5 + m2 + m1 + c50;
            totalgeneral = toefectivo + bancos - retiros + entradas;
            tbancos.Text = "Total Bancos: " + Validaciones.va.FormatearDoubleEnDobleDecimal(bancos);
            tefectivo.Text = "Total Efectivo: " + Validaciones.va.FormatearDoubleEnDobleDecimal(toefectivo);
            label13.Text = "Total:  $" + Validaciones.va.FormatearDoubleEnDobleDecimal(toefectivo);
            tretiros.Text = "Total retiros: " + Validaciones.va.FormatearDoubleEnDobleDecimal(retiros);
            tentradas.Text = "Total Entradas: " + Validaciones.va.FormatearDoubleEnDobleDecimal(entradas);
            tcajas.Text = "Total (Segun caja): " + Validaciones.va.FormatearDoubleEnDobleDecimal(tcaja);
            tcorte.Text = "Total Corte: " + Validaciones.va.FormatearDoubleEnDobleDecimal(totalgeneral);
            if (totalgeneral >= tcaja)
            {
                dif = totalgeneral - tcaja;
                tsobrante.Text = "Faltante: " + Validaciones.va.FormatearDoubleEnDobleDecimal(dif);
                tfaltante.Text = "Sobrante: - -";
            }
            else
            {
                dif = tcaja - totalgeneral;
                tfaltante.Text = "Faltante: " + Validaciones.va.FormatearDoubleEnDobleDecimal(dif);
                tsobrante.Text = "Sobrante: - -";
            }
        }

        private void Corte_Load(object sender, EventArgs e)
        {
            label_fecha.Text = DateTime.Now.ToString();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Totalcaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificardecimal(sender, e);
            Validaciones.va.Validalongittuddec(Totalcaja, e);
        }

        private void ret_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificardecimal(sender, e);
            Validaciones.va.Validalongittuddec(ret, e);
        }

        private void ent_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificardecimal(sender, e);
            Validaciones.va.Validalongittuddec(ent, e);
        }

        private void banco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.va.verificardecimal(sender, e);
            Validaciones.va.Validalongittuddec(banco, e);
        }
    }
}