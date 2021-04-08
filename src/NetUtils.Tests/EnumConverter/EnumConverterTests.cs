using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetUtils.Tests.EnumConverter
{
    [Flags]
    public enum SomeEnum
    {
        None = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    [TestClass]
    public class EnumConverterTests
    {
        private SomeEnum FromValue(int n)
        {
            switch (n)
            {
                case 0: return SomeEnum.None;
                case 1: return SomeEnum.One;
                case 2: return SomeEnum.Two;
                case 3: return SomeEnum.Three;
            }

            throw new ArgumentOutOfRangeException(nameof(n), "Does not see that <value> is supported by <enum>: <values>.");
        }

        private int ToValue(SomeEnum e)
        {
            switch (e)
            {
                case SomeEnum.None: return 0;
                case SomeEnum.One: return 1;
                case SomeEnum.Two: return 2;
                case SomeEnum.Three: return 3;
            }

            throw new ArgumentOutOfRangeException(nameof(e), "Does not see that <value> is supported by <enum>: <values>.");
        }

        private SomeEnum FromString(string s)
        {
            return GetSingleValue(s);
        }

        private SomeEnum FromString2(string s)
        {
            SomeEnum v = 0;

            var prev = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch != ',')
                {
                    continue;
                }

                var sub = s.Substring(prev, i - 1);

                v |= GetSingleValue(sub);
                prev = i + 1;
            }

            return v;
        }

        private static SomeEnum GetSingleValue(string s)
        {
            var len = s.Length;

            switch (len)
            {
                case 4: return SomeEnum.None;
                case 5: return SomeEnum.Three;
                case 3:
                {
                    var ch = s[0];
                    switch (ch)
                    {
                        case 'O': return SomeEnum.One;
                        case 'T': return SomeEnum.Two;
                    }

                    break;
                }
            }

            return SomeEnum.None;

            // switch (s)
            // {
            //     case "None": return SomeEnum.None;
            //     case "One": return SomeEnum.None;
            //     case "Two": return SomeEnum.None;
            //     case "Three": return SomeEnum.None;
            //     default: return SomeEnum.None;
            // }
        }
    }
}