using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.UX.Tools
{
    public static class ResourceHandler
    {
       private static ResourceManager manager = new ResourceManager("MiniSteam.UX.Resource_files.errHandlingKeys.resx",Assembly.GetExecutingAssembly());

        public static string GetResource(string key)
        {
            return manager.GetString(key);
        }
    }
}
