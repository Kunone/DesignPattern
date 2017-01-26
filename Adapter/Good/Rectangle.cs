using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Good
{
    class Rectangle : IShape
    {

        private Bad.LegacyRectangle adaptee = new Bad.LegacyRectangle();

        public void Draw(int x1, int y1, int x2, int y2)
        {
            adaptee.Draw(x1, y1, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
        }

    }
}
