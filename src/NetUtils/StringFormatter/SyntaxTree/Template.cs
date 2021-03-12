using System.Collections.Generic;

namespace NetUtils.StringFormatter.SyntaxTree
{
    public class Template : VisitablePart
    {
        public List<StringPart> Parts { get; set; }
        public void Accept(PartVisitor v)
        {
            v.Visit(this);
        }
    }
}