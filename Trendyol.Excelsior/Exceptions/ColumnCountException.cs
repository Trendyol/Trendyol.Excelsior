using System;

namespace Trendyol.Excelsior.Exceptions
{
    public class ColumnCountException : ExcelsiorException
    {
        public ColumnCountException(string message) 
            : base(message)
        {
        }
    }
}