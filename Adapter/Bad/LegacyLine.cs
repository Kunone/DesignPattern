using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Bad
{
    class LegacyLine
    {
        public void Draw(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Line from ({x1}, {y1}) to ({x2}, {y2})");
        }
    }
}
