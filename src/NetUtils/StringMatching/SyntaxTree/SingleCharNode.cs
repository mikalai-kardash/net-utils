namespace NetUtils.StringMatching.SyntaxTree
{
    public class SingleCharNode : CharNode
    {
        public char Event { get; set; }
        public CharNode Next { get; set; }
    }
}