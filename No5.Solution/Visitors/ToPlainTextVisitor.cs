using No5.Solution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution.Visitors
{
    public class ToPlainTextVisitor : IVisitor
    {
        StringBuilder sb = new StringBuilder();

        public string GetResult()
        {
            return sb.ToString();
        }

        public void Visit(BoldText part)
        {
            sb.Append(" * *" + part.Text + " * *");
        }

        public void Visit(Hyperlink part)
        {
            sb.Append(part.Text + " [" + part.Url + "]");
        }

        public void Visit(PlainText part)
        {
            sb.Append(part.Text);
        }
    }
}
