namespace NetUtils.StringFormatter.SyntaxTree
{
    public interface VisitablePart
    {
        void Accept(PartVisitor v);
    }
}