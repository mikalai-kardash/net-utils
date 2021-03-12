namespace NetUtils.StringFormatter.SyntaxTree
{
    public interface PartVisitor
    {
        void Visit(Const part);
        void Visit(Prop part);
        void Visit(Template part);
    }
}