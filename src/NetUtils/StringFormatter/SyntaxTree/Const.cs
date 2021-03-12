namespace NetUtils.StringFormatter.SyntaxTree
{
    public class Const : StringPart
    {
        public string Str { get; set; }
        public void Accept(PartVisitor v)
        {
            v.Visit(this);
        }
    }
}