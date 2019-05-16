using System;
using System.Collections.Generic;
using No5.Solution.Visitors;
using No5.Solution.Entities;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var docParts = new List<DocumentPart>()
            {
                new BoldText() { Text = "BoldText"},
                new Hyperlink() { Text = "HyperlinkText", Url = "http://test.com"},
                new PlainText() { Text = "PlainText"}
            };
            var doc = new Document(docParts);

            var toHTMLVisitor = new ToHtmlVisitor();
            doc.Accept(toHTMLVisitor);
            System.Console.WriteLine(toHTMLVisitor.GetResult());

            var toPlainTextVisitor = new ToPlainTextVisitor();
            doc.Accept(toPlainTextVisitor);
            System.Console.WriteLine(toPlainTextVisitor.GetResult());

            var toLaTeXVisitor = new ToLaTeXVisitor();
            doc.Accept(toLaTeXVisitor);
            System.Console.WriteLine(toLaTeXVisitor.GetResult());

            System.Console.ReadKey();
        }
    }
}
