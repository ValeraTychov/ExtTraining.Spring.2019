using No5.Solution.Visitors;

namespace No5.Solution.Entities
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }

        public abstract void Accept(IVisitor visitor);
    }
}
