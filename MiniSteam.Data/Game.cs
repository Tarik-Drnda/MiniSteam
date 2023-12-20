using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.Data
{
    public sealed class Game
    {
        public int Rating { get; set;}
        public string GameName { get; set;}
        public string Description { get; set;}
        public string Author { get; set; }

    }
}
