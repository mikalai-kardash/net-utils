namespace NetUtils.StringFormatter
{
    public interface SyntaxCollector
    {
        void Start();
        void End();

        void LeftCurlyBrace(int pos);
        void RightCurlyBrace(int pos);
    }
}