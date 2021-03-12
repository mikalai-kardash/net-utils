namespace NetUtils.StringFormatter.Parser
{
    public class WaitingState : TemplateParserState
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
            context.AddConst(pos);
            context.SetState(TemplateParserContext.Prop);
        }

        public void OnRightCurlyBrace(TemplateParserContext context, int pos)
        {
        }
    }
}