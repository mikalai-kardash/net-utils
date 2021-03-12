namespace NetUtils.StringFormatter
{
    public class TemplateLexer
    {
        private readonly SyntaxCollector collector;

        public TemplateLexer(SyntaxCollector collector)
        {
            this.collector = collector;
        }

        public void ParseTemplate(string messageTemplate)
        {
            var pos = 0;

            this.collector.Start();

            while (pos < messageTemplate.Length)
            {
                var ch = messageTemplate[pos];

                switch (ch)
                {
                    case TemplateSpelling.LeftCurlyBracket:
                        collector.LeftCurlyBrace(pos);
                        break;

                    case TemplateSpelling.RightCurlyBracket:
                        collector.RightCurlyBrace(pos);
                        break;
                }

                pos += 1;
            }

            this.collector.End();
        }
    }
}