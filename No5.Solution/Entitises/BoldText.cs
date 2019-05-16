﻿
using No5.Solution.Visitors;

namespace No5.Solution.Entities
{
    public class BoldText : DocumentPart
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}