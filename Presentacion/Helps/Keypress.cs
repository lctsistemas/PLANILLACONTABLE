using System;
using System.Windows.Forms;

namespace Presentacion.Helps
{
    public class Keypress
    {
        #region SON PRUEBAS
        public static void Text(KeyPressEventArgs e, TextBox txt)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }

        }

        //public static void Combo(KeyPressEventArgs e, ComboBox cbo)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Tab) || e.KeyChar == Convert.ToChar(Keys.Enter))
        //    {
        //        cbo.Focus();
        //    }

        //}

        //public static void Button(KeyPressEventArgs e, Button btn)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Tab))
        //    {
        //        MessageBox.Show("Enter");//no captura el tap
        //    }

        //}
        #endregion

        //METODOS QUE SE VAN USAR.
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (!Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void SoloLetras(KeyPressEventArgs e)
        {
            //que permite espacios, / .
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch
            {

            }
        }






    }
}
