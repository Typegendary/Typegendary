using System;
using System.Collections.Generic;
using System.Text;

namespace Typegendary_Classes
{
    public class Team
    {
        public List<Player> Players { get; } = new List<Player>();
    }

    public class Room
    {
        public List<Team> Teams { get; } = new List<Team>();
        public Room()
        {

        }
    }
}
