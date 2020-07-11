using System;
using System.Windows.Forms;
namespace Presentacion.Helps
{
    public class Messages
    {
        public static void M_info(String men)
        {
            MessageBox.Show(men, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void M_error(String men)
        {
            MessageBox.Show(men, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void M_warning(String men)
        {
            MessageBox.Show(men, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult M_question(String men)
        {
            return MessageBox.Show(men, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
