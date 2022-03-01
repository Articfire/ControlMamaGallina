using System;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace Clase_DPS1
{
    public partial class Corte : Form
    {

        double billete1000 =0;
        double billete500 =0;
        double billete200 = 0;
        double billete100 = 0;
        double billete50 = 0;
        double billete20 = 0;
        double moneda10 = 0;
        double moneda5 = 0;
        double moneda2 = 0;
        double moneda1 = 0;
        double centavo50 = 0;
        double bancos = 0;
        double entradas = 0;
        double retiros = 0;
        double tcaja = 0;
        double toefectivo = 0;
        double dif = 0;
        double totalgeneral = 0;

        int folio = 1;
        int moneda20 = 0;

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
                                        (int)billete1000, (int)billete500, (int)billete200, (int)billete100, (int)billete50, (int)billete20,
                                        (int)moneda20, (int)moneda10, (int)moneda5, (int)moneda2, (int)moneda1, (int)centavo50,
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
                billete500 = Convert.ToInt32(bi500.Text);

            }
            catch (Exception) { }
        }

        private void bi200_TextChanged(object sender, EventArgs e)
        {
            try
            {
                billete200 = Convert.ToInt32(bi200.Text);

            }
            catch (Exception) { }
        }

        private void bi100_TextChanged(object sender, EventArgs e)
        {
            try
            {
                billete100 = Convert.ToInt32(bi100.Text);

            }
            catch (Exception) { }
        }

        private void bi50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                billete50 = Convert.ToInt32(bi50.Text);

            }
            catch (Exception) { }
        }

        private void bi20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                billete20 = Convert.ToInt32(bi20.Text);

            }
            catch (Exception) { }
        }

        private void mo10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                moneda10 = Convert.ToInt32(mo10.Text);

            }
            catch (Exception) { }
        }

        private void mo5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                moneda5 = Convert.ToInt32(mo5.Text);

            }
            catch (Exception) { }
        }

        private void mo2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                moneda2 = Convert.ToInt32(mo2.Text);

            }
            catch (Exception) { }
        }

        private void mo1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                moneda1 = Convert.ToInt32(mo1.Text);

            }
            catch (Exception) { }
        }

        private void ce50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                centavo50 = Convert.ToInt32(ce50.Text);

            }
            catch (Exception) { }
        }

        private void bi1000_TextChanged(object sender, EventArgs e)
        {
            try
            {
                billete1000 = Convert.ToInt32(bi1000.Text);

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
                billete1000 = Convert.ToDouble(bi1000.Text);
                billete1000 = billete1000 * 1000;
            }
            else
            {
                billete1000 = 0;
            }


            if (bi500.Text != "")
            {
                billete500 = Convert.ToDouble(bi500.Text);
                billete500 = billete500 * 500;
            }
            else
            {
                billete500 = 0;
            }


            if (bi200.Text != "")
            {
                billete200 = Convert.ToDouble(bi200.Text);
                billete200 = billete200 * 200;
            }
            else
            {
                billete200 = 0;
            }

            if (bi100.Text != "")
            {
                billete100 = Convert.ToDouble(bi100.Text);
                billete100 = billete100 * 100;
            }
            else
            {
                billete100 = 0;
            }

            if (bi50.Text != "")
            {
                billete50 = Convert.ToDouble(bi50.Text);
                billete50 = billete50 * 50;

            }
            else
            {
                billete50 = 0;
            }
            if (bi20.Text != "")
            {
                billete20 = Convert.ToDouble(bi20.Text);
                billete20 = billete20 * 20;
            }
            else
            {
                billete20 = 0;
            }

            if (mo10.Text != "")
            {
                moneda10 = Convert.ToDouble(mo10.Text);
                moneda10 = moneda10 * 10;
            }
            else
            {
                moneda10 = 0;
            }

            if (mo5.Text != "")
            {
                moneda5 = Convert.ToDouble(mo5.Text);
                moneda5 = moneda5 * 5;
            }
            else
            {
                moneda5 = 0;
            }

            if (mo2.Text != "")
            {
                moneda2 = Convert.ToDouble(mo2.Text);
                moneda2 = moneda2 * 2;
            }
            else
            {
                moneda2 = 0;
            }

            if (mo1.Text != "")
            {
                moneda1 = Convert.ToDouble(mo1.Text);
            }
            else
            {
                moneda1 = 0;
            }

            if (ce50.Text != "")
            {
                centavo50 = Convert.ToDouble(ce50.Text);
                centavo50 = centavo50 * 0.5;
            }
            else
            {
                centavo50 = 0;
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


            toefectivo = billete1000 + billete500 + billete200 + billete100 + billete50 + billete20 + moneda10 + moneda5 + moneda2 + moneda1 + centavo50;
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