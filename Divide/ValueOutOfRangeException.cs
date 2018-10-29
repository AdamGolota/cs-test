using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divide
{
    public class ValueOutOfRangeException : Exception
    {
        public ValueOutOfRangeException() : base("Value is out of range")
        {

        }
    }
}
