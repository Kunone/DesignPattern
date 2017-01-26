using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Bad
{
    class DrawAllShapes
    {
        public static void Draw()
        {
            var shapes = new object[] { new LegacyLine(), new LegacyRectangle() };

            int x1 = 10;
            int y1 = 10;
            int x2 = 30;
            int y2 = 30;

            foreach(var shape in shapes)
            {
                var line = shape as LegacyLine;
                if (line != null)
                    line.Draw(x1, y1, x2, y2);
                else
                {
                    var rect = shape as LegacyRectangle;
                    if (rect != null)
                        rect.Draw(x1, y1, (x2 - x1), (y2 - y1));
                }
            }
        }
    }
}
