namespace NetUtils.StringFormatter.Parser
{
    public class PropState : TemplateParserState
    {
        public void OnStart(TemplateParserContext context)
        {
        }

        public void OnEnd(TemplateParserContext context)
        {
            context.Finish();
            context.SetState(TemplateParserContext.Finished);
        }

        public void OnLeftCurlyBrace(TemplateParserContext context, int pos)
        {
        }

        public void OnRightCurlyBrace(TemplateParserContext context, int pos)
        {
            context.AddProp(pos);
            context.SetState(TemplateParserContext.Waiting);
        }
    }
}