using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency
{
    public class ValueNotPositiveException : Exception
    {
        public ValueNotPositiveException() : base("Price must be positive")
        {

        }
    }
}
