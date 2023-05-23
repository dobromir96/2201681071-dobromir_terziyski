using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Domashna
{
    public class goal
    {
        int minute;
        player player;

        public int Minute { get { return minute; } set { value = minute; } }
        public player Player { get { return player; } set { value = Player; } }

        public goal(int minute, player player)
        {

            Minute = minute;
            Player = player;
        }
    }
}
