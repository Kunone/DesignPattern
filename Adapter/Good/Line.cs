using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Good
{
    class Line : IShape
    {
        private Bad.LegacyLine adaptee = new Bad.LegacyLine();

        public void Draw(int x1, int y1, int x2, int y2)
        {
            adaptee.Draw(x1, y1, x2, y2);
        }
    }
}
