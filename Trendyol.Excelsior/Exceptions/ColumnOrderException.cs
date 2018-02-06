using System;

namespace Trendyol.Excelsior.Exceptions
{
    public class ColumnOrderException : ExcelsiorException
    {
        public ColumnOrderException(string message)
            : base(message)
        {
        }
    }
}