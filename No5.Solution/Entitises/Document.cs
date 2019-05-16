using System;
using System.Collections.Generic;
using No5.Solution.Visitors;

namespace No5.Solution.Entities
{
    public class Document
    {
        private readonly List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public void Accept(IVisitor visitor)
        {
            if (visitor is null) throw new ArgumentNullException(nameof(visitor));

            foreach (DocumentPart part in this.parts)
            {
                part.Accept(visitor);
            }
        }
    }
}
