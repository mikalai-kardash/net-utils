using System;

namespace NetUtils.EnumConverter
{
    class DefaultEnumConverterImpl<T> : DefaultEnumConverter<T>
        where T : struct
    {
        private readonly Func<int, T> fromValueFn;
        private readonly Func<string, T> fromStringFn;

        public DefaultEnumConverterImpl(
            Func<int, T> fromValueFn,
            Func<string, T> fromStringFn
        )
        {
            this.fromValueFn = fromValueFn;
            this.fromStringFn = fromStringFn;
        }

        public T FromValue(int v)
        {
            return fromValueFn(v);
        }

        public T FromValue(string v)
        {
            return fromStringFn(v);
        }

        public int ToValue(T t)
        {
            throw new System.NotImplementedException();
        }

        public string ToStringValue(T t)
        {
            throw new System.NotImplementedException();
        }
    }
}