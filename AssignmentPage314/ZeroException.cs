using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPage314
{
    class ZeroException : Exception
    {
        public ZeroException()
            : base() { }
        public ZeroException(string message)
            : base(message) { }
    }
}
