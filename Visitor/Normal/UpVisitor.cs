using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Normal
{
    class UpVisitor : IVisitor
    {
        public void Visit(TheOtherElement element)
        {
            Console.WriteLine($"do Up on: {element.Name}");
        }

        public void Visit(ThatElement element)
        {
            Console.WriteLine($"do Up on: {element.Name}");
        }

        public void Visit(ThisElement element)
        {
            Console.WriteLine($"do Up on: {element.Name}");
        }
    }
}
