namespace NetUtils.EnumConverter
{
    public interface IEnumConverterFactory
    {
        DefaultEnumConverter<T> CreateFor<T>()
            where T : struct;
    }
}