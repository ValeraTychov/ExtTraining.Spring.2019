using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No5.Solution.Entities;

namespace No5.Solution.Visitors
{
    public class ToHtmlVisitor : IVisitor
    {
        StringBuilder sb = new StringBuilder();

        public string GetResult()
        {
            return sb.ToString();
        }

        public void Visit(BoldText part)
        {
            sb.Append("<b>" + part.Text + "</b>");
        }

        public void Visit(Hyperlink part)
        {
            sb.Append("<a href=\"" + part.Url + "\">" + part.Text + "</a>");
        }

        public void Visit(PlainText part)
        {
            sb.Append(part.Text);
        }
    }
}
