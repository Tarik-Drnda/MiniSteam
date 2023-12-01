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
    public class ValidatorLogin
    {
        public static User FindUser(string username,string password)
        {
            dynamic usr=null;
            foreach (var user in InMemoryDB.users)
            {
                if (username == user.Ime && password == user.Password)
                {
                    usr=user;
                    break;
                }
            }


            return usr;
        }


    }
}
