using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractServer.Good
{
    class LIght : ISwitchable
    {
        public void TurnOff()
        {
            Console.WriteLine("Turn off the light");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn on the light");
        }
    }
}
