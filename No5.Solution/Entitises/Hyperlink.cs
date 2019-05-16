using No5.Solution.Visitors;

namespace No5.Solution.Entities
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
