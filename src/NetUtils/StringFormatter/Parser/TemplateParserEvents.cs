namespace NetUtils.StringFormatter.Parser
{
    public interface TemplateParserEvents
    {
        void OnStart(TemplateParserContext context);
        void OnEnd(TemplateParserContext context);
        void OnLeftCurlyBrace(TemplateParserContext context, int pos);
        void OnRightCurlyBrace(TemplateParserContext context, int pos);
    }
}