namespace NetUtils.StringMatching
{
    public class SyntaxTreeBuilder
    {
        private INode root = new StartNode();

        public void AddString(string s)
        {
            var head = root;
            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                head.AddEvent(ch);
            }
        }
    }

    internal class StartNode : INode
    {
        public INode Next = new EmptyNode();

        public void AddEvent(char ch)
        {
        }
    }

    internal class EmptyNode : INode
    {
        public void AddEvent(char ch)
        {
        }
    }

    internal interface INode
    {
        void AddEvent(char ch);
    }
}