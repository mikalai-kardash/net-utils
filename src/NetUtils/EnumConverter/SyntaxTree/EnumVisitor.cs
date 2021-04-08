namespace NetUtils.EnumConverter.SyntaxTree
{
    public interface EnumVisitor
    {
        void Visit(EnumType t);
        void Accept(EnumValue v);
    }
}