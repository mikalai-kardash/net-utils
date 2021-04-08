namespace NetUtils.EnumConverter
{
    public interface DefaultEnumConverter<T>
        where T : struct
    {
        T FromValue(int v);
        T FromValue(string v);

        int ToValue(T t);
        string ToStringValue(T t);
    }
}