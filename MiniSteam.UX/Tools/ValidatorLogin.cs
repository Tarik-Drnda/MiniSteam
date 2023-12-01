using MiniSteam.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MiniSteam.UX.Tools
{
    internal class ValidatorLogin
    {
        public static bool ValidInput()
        {
            bool valid = true;
            if (frmLogin.txtUsername.Text.isValid() || frmLogin.txtPassword.Text.isValid())
            {

            }
        }
    }
}
