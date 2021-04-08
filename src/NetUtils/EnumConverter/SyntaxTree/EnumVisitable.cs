namespace NetUtils.EnumConverter.SyntaxTree
{
    public interface EnumVisitable
    {
        void Accept(EnumVisitor v);
    }
}