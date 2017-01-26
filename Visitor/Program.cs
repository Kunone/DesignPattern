using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new Normal.IElement[] { new Normal.ThisElement(), new Normal.ThatElement(), new Normal.TheOtherElement() };

            var upVisitor = new Normal.UpVisitor();
            var downVisitor = new Normal.DownVisitor();

            foreach (var e in elements)
            {
                e.Accept(upVisitor);
                e.Accept(downVisitor);
            }
        }
    }
}
