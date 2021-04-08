namespace NetUtils.EnumConverter.SyntaxTree
{
    public class EnumValue : EnumVisitable
    {
        public string Number { get; set; }
        public string Name { get; set; }

        public void Accept(EnumVisitor v)
        {
            v.Accept(this);
        }
    }
}