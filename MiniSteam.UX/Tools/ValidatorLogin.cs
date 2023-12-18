using MiniSteam.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniSteam.Data;
using MiniSteam.Infrastructure;
using static System.Net.Mime.MediaTypeNames;

namespace MiniSteam.UX.Tools
{
    public class Validator
    {
       public static bool ValidanUnos(Control kontrola,ErrorProvider er,string tekst)
        {
            bool valid = true;
            if(kontrola is TextBox && (kontrola as TextBox) == null)
            {
                valid = false;
            }
            else if(kontrola is ComboBox && (kontrola as ComboBox) == null)
            {
                valid = false;

            }
            else if(kontrola is PictureBox && (kontrola as PictureBox) == null)
            {
                valid = false;
            }
            if(!valid)
            {
                er.SetError(kontrola, tekst);
                return false;
            }    
            return valid;
        }

    }
}
