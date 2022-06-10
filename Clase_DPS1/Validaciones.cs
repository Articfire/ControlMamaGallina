/**
 * @file Validaciones.cs
 * @version 1.6
 * @author Hurtado, Martin.
 * @title Validaciones.
 * @brief Archivo que se encarga de las validaciones en los campos de texto.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_DPS1
{
    
    public class Validaciones
    {
        bool dec = false;
        public readonly static Validaciones va = new Validaciones();

        public void cerrartodo(object sender, EventArgs e)
        {
            Salir x = new Salir();
            x.Show();
        }

        public void verificarnumero(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void verificardecimal(object sender, KeyPressEventArgs e)
        {
            if (dec == false)
            {
                if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
                {
                    e.Handled = false;
                    if (e.KeyChar == '.')
                    {
                        dec = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            
        }

        public void ValidatxtLongitud(TextBox txttoValidate, KeyPressEventArgs e)
        {
            if (txttoValidate.Text.Length < 25 || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Maximo de caracteres alcanzado");
                e.Handled = true;
            }
        }

        public void ValidatxtLongitudT(TextBox txttoValidate, KeyPressEventArgs e)
        {
            if (txttoValidate.Text.Length < 100 || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Maximo de caracteres alcanzado");
                e.Handled = true;
            }
        }

        public void ValidatxtLongitudL(TextBox txttoValidate, KeyPressEventArgs e)
        {
            if (txttoValidate.Text.Length < 15 || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Maximo de caracteres alcanzado");

                e.Handled = true;
            }
        }

        public void ValidatxtLongitudL(MaskedTextBox txttoValidate, KeyPressEventArgs e)
        {
            if (txttoValidate.Text.Length < 15 || Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Maximo de caracteres alcanzado");
                e.Handled = true;
            }
        }

        public void Validanumlongittud(TextBox txttoValidatenum, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (txttoValidatenum.Text.Length < 3 || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Maximo de digitos alcanzados");
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
            
        }

        public void Validalongittuddec(TextBox txttoValidatenum, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                if (txttoValidatenum.Text.Length < 7 || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    if (e.KeyChar == '.')
                    {
                        dec = true;
                    }
                }
                else
                {
                    MessageBox.Show("Maximo de digitos alcanzados");
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        public double FormatearDoubleEnDobleDecimal(double valor_doble)
        {
            return Math.Truncate(valor_doble * 100) / 100;
        }

        public float FormatearFlotanteEnDobleDecimal(float valor_flotante)
        {
            return (float)Math.Truncate(valor_flotante * 100) / 100;
        }

        public float FormatearFlotanteEnDobleDecimal(string valor_flotante)
        {
            return (float)Math.Truncate(Convert.ToDouble(valor_flotante) * 100) / 100;
        }
    }
}
