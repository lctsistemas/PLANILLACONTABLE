using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Presentacion.Helps
{
    public class Tooltip
    {
         private static ToolTip t = new ToolTip();

        public Tooltip() {
            //t.IsBalloon = true;
            //t.ToolTipIcon = ToolTipIcon.None;
            //t.BackColor =Color.LightCoral;
            //t.ForeColor = Color.LightBlue;
            //t.AutomaticDelay = 400;
            //t.InitialDelay = 400;
        
        }

        public static void Title(Control ctr, string alert) {
            t.IsBalloon = true;
            t.AutomaticDelay = 400;
            t.InitialDelay = 400;
            t.SetToolTip(ctr,alert);
        }
    }
}
