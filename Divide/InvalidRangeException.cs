using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divide
{
    public class InvalidRangeException : Exception
    {
        public InvalidRangeException() : base("Min value can not be higher than max value")
        {

        }
    }
}
