namespace NetUtils.StringFormatter.SyntaxTree
{
    public class Prop : StringPart
    {
        public string Name { get; set; }
        public void Accept(PartVisitor v)
        {
            v.Visit(this);
        }
    }
}