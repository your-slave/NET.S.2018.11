using System;

namespace NET.S._2018.Karakouski._11
{
    public class BookFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter)) return this;
            return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg is Book)
            {
                switch (format)
                {
                    case ("A"):
                    default:
                        throw new ArgumentException(nameof(format) + ": Format is not supported");
                }
            }

        }
    }
}
