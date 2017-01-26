using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Normal
{
    class DownVisitor : IVisitor
    {
        public void Visit(TheOtherElement theOtherElement)
        {
            Console.WriteLine($"do Down on: {theOtherElement.Name}");
        }

        public void Visit(ThatElement thatElement)
        {
            Console.WriteLine($"do Down on: {thatElement.Name}");
        }

        public void Visit(ThisElement thisElement)
        {
            Console.WriteLine($"do Down on: {thisElement.Name}");
        }
    }
}
