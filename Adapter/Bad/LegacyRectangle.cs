using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Bad
{
    class LegacyRectangle
    {
        public void Draw(int x, int y, int w, int h)
        {
            Console.WriteLine($"Rectangle from ({x}, {y}) with width: {w} and height: {h})");
        }
    }
}
