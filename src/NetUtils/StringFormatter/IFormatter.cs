namespace NetUtils.StringFormatter
{
    public interface IFormatter<in T>
    {
        string GetString(T data);
    }
}