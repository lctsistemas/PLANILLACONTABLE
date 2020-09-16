using System.Windows.Forms;

namespace Presentacion.Helps
{
    public class Tooltip
    {
        private static ToolTip t = new ToolTip();

        public Tooltip()
        {
            //t.IsBalloon = true;
            //t.ToolTipIcon = ToolTipIcon.None;
            //t.BackColor =Color.SteelBlue;
            //t.ForeColor = Color.White;
            //t.AutomaticDelay = 400;
            //t.InitialDelay = 400;
        }

        public static void Title(Control ctr, string alert, bool ballon)
        {
            t.IsBalloon = ballon;
            t.AutomaticDelay = 400;
            t.InitialDelay = 400;
            t.SetToolTip(ctr, alert);           
        }
    }
}
