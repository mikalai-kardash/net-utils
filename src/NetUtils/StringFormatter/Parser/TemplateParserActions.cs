namespace NetUtils.StringFormatter.Parser
{
    public interface TemplateParserActions
    {
        void AddConst(int pos);
        void AddProp(int pos);
        void Finish();
    }
}