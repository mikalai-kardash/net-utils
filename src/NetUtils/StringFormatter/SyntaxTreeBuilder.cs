namespace NetUtils.StringFormatter
{
    public interface SyntaxTreeBuilder
    {
        void AddConst(int pos);
        void AddProp(int pos);
        void Done();
    }
}