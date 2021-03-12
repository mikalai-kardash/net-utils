using NetUtils.StringFormatter.Parser;

namespace NetUtils.StringFormatter
{
    public class TemplateParser : TemplateParserContext, SyntaxCollector
    {
        private readonly SyntaxTreeBuilder builder;

        public TemplateParser(SyntaxTreeBuilder builder)
        {
            this.builder = builder;
        }

        #region Syntax Collector (Events)

        public void Start()
        {
            this.state.OnStart(this);
        }

        public void End()
        {
            this.state.OnEnd(this);
        }

        public void LeftCurlyBrace(int pos)
        {
            this.state.OnLeftCurlyBrace(this, pos);
        }

        public void RightCurlyBrace(int pos)
        {
            this.state.OnRightCurlyBrace(this, pos);
        }

        #endregion

        public override void AddConst(int pos)
        {
            this.builder.AddConst(pos);
        }

        public override void AddProp(int pos)
        {
            this.builder.AddProp(pos);
        }

        public override void Finish()
        {
            this.builder.Done();
        }
    }
}