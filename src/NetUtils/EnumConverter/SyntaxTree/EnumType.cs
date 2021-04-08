using System.Collections.Generic;

namespace NetUtils.EnumConverter.SyntaxTree
{
    public class EnumType : EnumVisitable
    {
        public bool IsFlag { get; set; }
        public string Name { get; set; }
        public List<EnumValue> Values { get; set; }

        public void Accept(EnumVisitor v)
        {
            v.Visit(this);
        }
    }
}