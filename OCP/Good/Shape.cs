using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Good
{
    abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("this is base class Shape");
        }
    }
}
