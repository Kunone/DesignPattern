using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Good
{
    class DrawAllShapes
    {
        public static void Draw()
        {
            var shapes = new IShape[] { new Line(), new Rectangle() };

            int x1 = 10;
            int y1 = 10;
            int x2 = 30;
            int y2 = 30;

            foreach (var shape in shapes)
                shape.Draw(x1, y1, x2, y2);
        }
    }
}
