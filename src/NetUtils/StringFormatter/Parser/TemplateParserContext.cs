namespace NetUtils.StringFormatter.Parser
{
    public abstract class TemplateParserContext : TemplateParserActions
    {
        protected TemplateParserState state;

        public static readonly TemplateParserState Prop = new PropState();
        public static readonly TemplateParserState Waiting = new WaitingState();
        public static readonly TemplateParserState Finished = new FinishedState();

        protected TemplateParserContext()
        {
            SetState(Waiting);
        }

        public void SetState(TemplateParserState newState)
        {
            this.state = newState;
        }

        public abstract void AddConst(int pos);
        public abstract void AddProp(int pos);
        public abstract void Finish();
    }
}