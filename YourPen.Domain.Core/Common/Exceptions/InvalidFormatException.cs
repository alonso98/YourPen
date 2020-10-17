using System;
using System.Collections.Generic;
using System.Text;

namespace YourPen.Domain.Core.Common.Exceptions
{
    public class InvalidFormatException<T> : ApplicationException where T:class
    {
        public InvalidFormatException() : base(string.Format("Invalid format of {0}", typeof(T).ToString()))
        {
        }
    }
}
