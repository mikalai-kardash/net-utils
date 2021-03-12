namespace NetUtils.StringFormatter
{
    public interface IFormatterFactory
    {
        IFormatter<T> CreateFormatter<T>(string messageTemplate);
    }
}