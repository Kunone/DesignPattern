using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Normal
{
    interface IVisitor
    {
        void Visit(ThisElement thisElement); // second dispatch
        void Visit(ThatElement thatElement);
        void Visit(TheOtherElement theOtherElement);
    }
}
