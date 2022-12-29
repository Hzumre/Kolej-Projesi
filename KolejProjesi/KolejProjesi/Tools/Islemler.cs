using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolejProjesi.Tools
{
    internal class Islemler
    {
        public static void Clear(Control.ControlCollection control)
        {
            foreach(Control ctrl in control)
            {
                if(ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                }
                else if (ctrl.Controls.Count > 0)
                {
                    Clear(ctrl.Controls);
                }
            }
        }

       
    }
}
