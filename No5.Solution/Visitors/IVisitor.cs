using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No5.Solution.Entities;

namespace No5.Solution.Visitors
{
    public interface IVisitor
    {
        void Visit(BoldText part);
        void Visit(Hyperlink documentPart);
        void Visit(PlainText documentPart);
    }
}
