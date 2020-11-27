using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
namespace Presentacion.Helps
{
    public class ValidateError
    {
        public static ErrorProvider validate = new ErrorProvider();

        public static void Validate_text(CancelEventArgs e, TextBox txt, string m)
        {

            if (String.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                validate.SetError(txt, m);
            }
            else
            {
                e.Cancel = false;
                validate.SetError(txt, null);
            }

        }

        public static void Validate_text(TextBox txt, string m)
        {

            //validate.Icon = Properties.Resources.java2;
            validate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            // validate.BlinkRate = 250 velocidad en milesegundos en que parpadea
            if (String.IsNullOrWhiteSpace(txt.Text))
                validate.SetError(txt, m);
            else
                validate.SetError(txt, null);
        }

        //VALIDAR COMBO
        public static void Validate_combo(CancelEventArgs e, ComboBox cbo, string m)
        {
            if (String.IsNullOrWhiteSpace(cbo.Text))
            {
                e.Cancel = true;
                cbo.Focus();
                validate.SetError(cbo, m);
            }
            else
            {
                validate.SetError(cbo, null);
            }
        }

        public static void Validate_combo(ComboBox cbo, string m)
        {
            if (String.IsNullOrWhiteSpace(cbo.Text))
            {
                validate.SetError(cbo, m);
            }
            else
            {
                validate.SetError(cbo, null);
            }
        }

    }
}
