using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPage314
{
    public class NumberException : Exception
    {
        public NumberException()
            : base() { }
        public NumberException(string message)
            : base(message) { }
    }
}
