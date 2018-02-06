using System;

namespace Trendyol.Excelsior.Exceptions
{
    public class ExcelsiorException : Exception
    {
        public ExcelsiorException(string message)
            : base(message)
        {
        }
    }
}